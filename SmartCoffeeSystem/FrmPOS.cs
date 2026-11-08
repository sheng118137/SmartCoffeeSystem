using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCoffeeSystem;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem
{
    public partial class FrmPOS : Form
    {
        private bool _isPreviewMode = false;
        public bool IsPreviewMode
        {
            get { return _isPreviewMode; }
            set
            {
                _isPreviewMode = value;

                //外面設f.IsPreviewMode = true,那就鎖結帳扭
                if (_isPreviewMode)
                {
                    btnCheckout.Enabled = false;
                    btnCheckout.Text = "預覽模式無法下單";

                    //連清空購物車也一起鎖，避免亂點
                    btnClear.Enabled = false;
                }
            }
        }
        private bool isDineIn = true;

        //啟動時把上架商品一次撈進來,切分類才不卡
        private List<Product> Products = new List<Product>();
        private List<CartItem> shoppingCart = new List<CartItem>();
        private IconButton currentBtn = null;

        // 記錄現在點擊的是哪一個分類,預設是1
        private int currentCategoryId = 1;

        public FrmPOS()
        {
            InitializeComponent();
            SetupSearchBox();
            UpdateCartUI();

            // 連線診斷（若連線失敗會顯示錯誤訊息）
            var (ok, msg) = DBHelper.TestSqlConnection();
            if (!ok)
            {
                MessageBox.Show("資料庫連線失敗：\n" + msg, "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 不強制中斷，讓呼叫端視需要處理
            }

            // ESC 快捷鍵退出
            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape) Close();
            };


            List<Category> categories = null;
            Exception dbError = null;



            // EF連線與查詢
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        // 一次把商品跟分類都直接撈進記憶體
                        Products = db.Products.OrderBy(p => p.Sort).Where(p => p.IsActive == true).ToList();
                        categories = db.Categories.OrderBy(c => c.SortOrder).ToList();
                    }
                }
                catch (Exception ex)
                {
                    dbError = ex;
                }

                // 如果發生錯誤，在主執行緒跳出提示
                if (dbError != null)
                {
                    MessageBox.Show("讀取資料庫失敗：" + dbError.Message, "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //背景撈完後，回到主執行緒再畫出左側分類按鈕
                if (categories != null)
                {
                    //左側面板先停畫，加入商品卡
                    panelLeft.SuspendLayout();
                    panelLeft.Controls.Clear();

                    foreach (var cat in categories)
                    {
                        CreateCategoryButton(cat);
                    }

                    //一次性把所有商品卡顯示出來
                    panelLeft.ResumeLayout();

                    //預設顯示第一個分類的商品
                    if (categories.Count > 0)
                    {
                        currentCategoryId = categories[0].CategoryID;
                        LoadProductsByCategory(currentCategoryId);

                        // 第一個分類按鈕預設點亮
                        if (panelLeft.Controls.Count > 0 && panelLeft.Controls[0] is IconButton firstBtn)
                        {
                            ActivateButton(firstBtn);
                        }
                    }
                }

            }
        }


        private void SetupSearchBox()
        {
            txtSearch.Font = new Font("微軟正黑體", 16F);
            txtSearch.Text = "搜尋商品...";
            txtSearch.ForeColor = Color.Gray;

            // 點文字框清空提示字
            txtSearch.Enter += (s, ev) =>
            {
                if (txtSearch.Text == "搜尋商品...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };

            // 離開文字框，恢復提示字，空白就留著原本的字
            txtSearch.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "搜尋商品...";
                    txtSearch.ForeColor = Color.Gray;
                }
            };
        }

        //記憶體過濾商品不連DB比較快
        private void LoadProductsByCategory(int categoryId, string keyword = "")
        {
            //暫停中央面板排版，不然每加一張卡片就畫面會閃一次
            panelCenter.SuspendLayout();
            panelCenter.Controls.Clear();

            // 用 LINQ 從剛剛撈出來的 Products 快取中進行過濾
            var filteredProducts = Products.Where(p => p.CategoryID == categoryId).ToList();

            if (!string.IsNullOrWhiteSpace(keyword) && keyword != "搜尋商品...")
            {
                filteredProducts = filteredProducts
                                   .Where(p => p.ProductName.ToLower().Contains(keyword.ToLower()))
                                   .ToList();
            }

            foreach (var prod in filteredProducts)
            {
                CreateProductCard(prod);
            }

            //卡片都加進去後，再一次性把渲染畫面
            panelCenter.ResumeLayout();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProductsByCategory(currentCategoryId, txtSearch.Text);
        }

        private void CreateProductCard(Product prod)
        {
            if (prod.Stock > 0)
            {
                Panel card = new Panel();
                card.Width = 280;
                card.Height = 360;
                card.BackColor = Color.White;
                card.Margin = new Padding(30, 15, 20, 20);
                card.Cursor = Cursors.Hand;
                card.Tag = prod;

                PictureBox pic = new PictureBox();
                pic.SetBounds(10, 10, 280, 230);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.BackColor = Color.FromArgb(250, 250, 250);

                if (!string.IsNullOrEmpty(prod.ImagePath))
                {
                    string fullImagePath = Path.Combine(Application.StartupPath, "ProductImages", prod.ImagePath);
                    if (File.Exists(fullImagePath))
                    {
                        pic.Image = Image.FromFile(fullImagePath);
                    }
                    else
                    {
                        string defaultPath = Path.Combine(Application.StartupPath, "ProductImages", "default.png");
                        if (File.Exists(defaultPath)) pic.Image = Image.FromFile(defaultPath);
                    }
                }

                Label lblName = new Label();
                lblName.Text = prod.ProductName;
                lblName.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
                lblName.ForeColor = Color.FromArgb(50, 50, 50);
                lblName.SetBounds(15, 255, 300, 40);
                lblName.TextAlign = ContentAlignment.MiddleLeft;

                Label lblPrice = new Label();
                lblPrice.Text = $"${Convert.ToInt32(prod.Price)}";
                lblPrice.Font = new Font("微軟正黑體", 20F, FontStyle.Bold);
                lblPrice.ForeColor = Color.FromArgb(230, 85, 30);
                lblPrice.SetBounds(15, 300, 150, 40);
                lblPrice.TextAlign = ContentAlignment.BottomLeft;

                Button btnAdd = new Button();
                btnAdd.Text = "+";
                btnAdd.Font = new Font("Arial", 24F, FontStyle.Bold);
                btnAdd.SetBounds(230, 300, 40, 40);
                btnAdd.FlatStyle = FlatStyle.Flat;
                btnAdd.FlatAppearance.BorderSize = 0;
                btnAdd.BackColor = Color.FromArgb(230, 85, 30);
                btnAdd.ForeColor = Color.White;
                btnAdd.Cursor = Cursors.Hand;
                btnAdd.Tag = prod;

                card.Click += ProductCard_Click;
                pic.Click += (s, e) => ProductCard_Click(card, e);
                lblName.Click += (s, e) => ProductCard_Click(card, e);
                btnAdd.Click += (s, e) => ProductCard_Click(card, e);

                card.Controls.Add(pic);
                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(btnAdd);

                panelCenter.Controls.Add(card);
            }
            else
            {
                Panel card = new Panel();
                card.Width = 280;
                card.Height = 360;
                card.BackColor = Color.White;
                card.Margin = new Padding(30, 15, 20, 20);
                card.Cursor = Cursors.Hand;
                card.Tag = prod;

                PictureBox pic = new PictureBox();
                pic.SetBounds(10, 10, 280, 230);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.BackColor = Color.FromArgb(250, 250, 250);

                if (!string.IsNullOrEmpty(prod.ImagePath))
                {
                    string fullImagePath = Path.Combine(Application.StartupPath, "ProductImages", prod.ImagePath);
                    if (File.Exists(fullImagePath))
                    {
                        pic.Image = Image.FromFile(fullImagePath);
                    }
                    else
                    {
                        string defaultPath = Path.Combine(Application.StartupPath, "ProductImages", "default.png");
                        if (File.Exists(defaultPath)) pic.Image = Image.FromFile(defaultPath);
                    }
                }

                Label lblName = new Label();
                lblName.Text = $"{prod.ProductName}(補貨中)";
                lblName.Font = new Font("微軟正黑體", 18F, FontStyle.Bold);
                lblName.ForeColor = Color.FromArgb(50, 50, 50);
                lblName.SetBounds(15, 255, 300, 40);
                lblName.TextAlign = ContentAlignment.MiddleLeft;
                lblName.Enabled = false;

                Label lblPrice = new Label();
                lblPrice.Text = $"${Convert.ToInt32(prod.Price)}";
                lblPrice.Font = new Font("微軟正黑體", 20F, FontStyle.Bold);
                lblPrice.ForeColor = Color.FromArgb(230, 85, 30);
                lblPrice.SetBounds(15, 300, 150, 40);
                lblPrice.TextAlign = ContentAlignment.BottomLeft;

                Button btnAdd = new Button();
                btnAdd.Text = "+";
                btnAdd.Font = new Font("Arial", 24F, FontStyle.Bold);
                btnAdd.SetBounds(230, 300, 40, 40);
                btnAdd.FlatStyle = FlatStyle.Flat;
                btnAdd.FlatAppearance.BorderSize = 0;
                btnAdd.BackColor = Color.FromArgb(230, 85, 30);
                btnAdd.ForeColor = Color.White;
                btnAdd.Cursor = Cursors.Hand;
                btnAdd.Tag = prod;

                card.Controls.Add(pic);
                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(btnAdd);
                panelCenter.Controls.Add(card);

            }

        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            Product selectedProduct = clickedControl?.Tag as Product;

            if (selectedProduct != null)
            {
                FrmProductModal modal = new FrmProductModal(selectedProduct);
                modal.StartPosition = FormStartPosition.CenterScreen;

                if (modal.ShowDialog() == DialogResult.OK)
                {
                    var existingItem = shoppingCart.FirstOrDefault(x =>
                        x.ProductID == selectedProduct.ProductID &&
                        x.SpecString == modal.SelectedSpecString);

                    if (existingItem != null)
                    {
                        existingItem.Quantity += modal.FinalQuantity;
                    }
                    else
                    {
                        shoppingCart.Add(new CartItem
                        {
                            ProductID = selectedProduct.ProductID,
                            ProductName = selectedProduct.ProductName,
                            SpecString = modal.SelectedSpecString,
                            UnitPrice = modal.FinalUnitPrice,
                            Quantity = modal.FinalQuantity
                        });
                    }

                    UpdateCartUI();
                }
            }
        }

        private void UpdateCartUI()
        {
            panelCart.Controls.Clear();
            int grandTotal = 0;
            int totalCount = 0;

            if (shoppingCart.Count == 0)
            {
                lblEmpty.Text = "購物車目前是空的";
                lblEmpty.Font = new Font("微軟正黑體", 16F, FontStyle.Bold);
                lblEmpty.ForeColor = Color.FromArgb(160, 160, 160);
                lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
                lblEmpty.Dock = DockStyle.Fill;
                panelCart.Controls.Add(lblEmpty);

                btnClear.Enabled = false;
                btnCheckout.Enabled = false;
                btnClear.BackColor = Color.FromArgb(200, 200, 200);
                btnCheckout.BackColor = Color.FromArgb(200, 200, 200);
                btnCheckout.Text = " 前往結帳 ($0)";
                lblTotalCount.Text = "共 0 件商品";
                lblGrandTotal.Text = "應付總額：$0";
                return;
            }

            if (_isPreviewMode)
            {
                //愈覽模式鎖扭
                btnClear.Enabled = false;
                btnCheckout.Enabled = false;
            }
            else
            {
                //前台模式解鎖按鈕
                btnClear.Enabled = true;
                btnCheckout.Enabled = true;
            }

            btnClear.BackColor = Color.FromArgb(160, 160, 160);
            btnCheckout.BackColor = Color.FromArgb(230, 85, 30);

            foreach (var item in shoppingCart)
            {
                Panel row = new Panel();
                row.Width = panelCart.ClientSize.Width - 15;
                row.BackColor = Color.White;
                row.Margin = new Padding(0, 0, 0, 10);
                row.Padding = new Padding(10);

                Label lblName = new Label();
                lblName.Text = item.ProductName;
                lblName.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
                lblName.ForeColor = Color.FromArgb(60, 40, 30);
                lblName.SetBounds(10, 8, 220, 25);

                Label lblSpec = new Label();
                lblSpec.Text = string.IsNullOrEmpty(item.SpecString) ? "無備註" : item.SpecString;
                lblSpec.Font = new Font("微軟正黑體", 11F);
                lblSpec.ForeColor = Color.FromArgb(120, 120, 120);
                lblSpec.Location = new Point(10, 38);
                lblSpec.AutoSize = true;
                lblSpec.MaximumSize = new Size(230, 0);

                Label lblPriceQty = new Label();
                lblPriceQty.Text = $"x{item.Quantity}   ${item.Subtotal}";
                lblPriceQty.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
                lblPriceQty.ForeColor = Color.FromArgb(230, 85, 30);
                lblPriceQty.SetBounds(250, 25, 120, 30);
                lblPriceQty.TextAlign = ContentAlignment.MiddleRight;

                Button btnDelete = new Button();
                btnDelete.Text = "✕";
                btnDelete.Font = new Font("Arial", 14F, FontStyle.Bold);
                btnDelete.SetBounds(380, 22, 35, 35);
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.BackColor = Color.FromArgb(240, 240, 240);
                btnDelete.ForeColor = Color.FromArgb(180, 50, 50);
                btnDelete.Cursor = Cursors.Hand;

                btnDelete.Click += (s, e) =>
                {
                    shoppingCart.Remove(item);
                    UpdateCartUI();
                };

                row.Controls.Add(lblName);
                row.Controls.Add(lblSpec);
                row.Controls.Add(lblPriceQty);
                row.Controls.Add(btnDelete);

                row.Height = Math.Max(85, lblSpec.Bottom + 12);

                panelCart.Controls.Add(row);

                grandTotal += item.Subtotal;
                totalCount += item.Quantity;
            }

            lblTotalCount.Text = $"共 {totalCount} 件商品";
            lblGrandTotal.Text = $"應付總額：${grandTotal}";
            btnCheckout.Text = $"前往結帳 (${grandTotal})";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要清空購物車裡所有的餐點嗎？", "清空確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                shoppingCart.Clear();
                lblTotalCount.Text = $"共 0 件商品";
                lblGrandTotal.Text = $"應付總額：$0元";
                UpdateCartUI();
            }
        }

        // 結帳寫入主訂單、明細與會員點數
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string orderTypeStr = isDineIn ? "內用" : "外帶";
            int grandTotal = shoppingCart.Sum(x => x.Subtotal);

            FrmCheckout checkoutModal = new FrmCheckout(grandTotal);

            if (checkoutModal.ShowDialog() == DialogResult.OK)
            {
                var res = checkoutModal.Result;

                using (var db = new POSContext())
                {
                    // Transaction 交易：確保訂單、明細、會員點數要嘛一起成功，要嘛一起失敗
                    using (var dbContextTransaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            //新增主訂單 (Order)
                            var newOrder = new Order
                            {
                                OrderDate = DateTime.Now,
                                OrderType = orderTypeStr,
                                OriginalTotal = res.TotalAmount,
                                MemberID = res.MemberID,
                                DiscountAmount = res.DiscountAmount,
                                FinalAmount = res.FinalAmount,
                                PaymentMethod = res.PaymentMethod,
                                CarrierType = res.CarrierType,
                                CarrierNum = string.IsNullOrEmpty(res.CarrierNumber) ? null : res.CarrierNumber,
                                OrderStatus = 1,
                                OrderSort = 1
                            };
                            db.Orders.Add(newOrder);
                            db.SaveChanges();

                            //新增訂單明細 (OrderDetail) 與扣除庫存
                            foreach (var item in shoppingCart)
                            {
                                var detail = new OrderDetail
                                {
                                    OrderID = newOrder.OrderID,
                                    ProductID = item.ProductID,
                                    ProductName = item.ProductName,
                                    UnitPrice = item.UnitPrice,
                                    Quantity = item.Quantity,
                                    SpecString = item.SpecString ?? "",
                                    Subtotal = item.Subtotal
                                };
                                db.OrderDetails.Add(detail);

                                //依據購買數量扣除商品庫存
                                var product = db.Products.FirstOrDefault(p => p.ProductID == item.ProductID);
                                if (product != null)
                                {
                                    product.Stock -= item.Quantity; // 扣除對應購買數量
                                    if (product.Stock < 0) product.Stock = 0; // 防呆避免負數
                                }

                                //同步扣除記憶體快取中的庫存，讓畫面即時反應
                                var cachedProduct = Products.FirstOrDefault(p => p.ProductID == item.ProductID);
                                if (cachedProduct != null)
                                {
                                    cachedProduct.Stock -= item.Quantity;
                                    if (cachedProduct.Stock < 0) cachedProduct.Stock = 0;
                                }
                            }
                            db.SaveChanges();

                            //處理會員點數累積與消費
                            int earnedPoints = 0;
                            if (res.IsMember && res.MemberID.HasValue)
                            {
                                //拿掉Include，單撈會員
                                var member = db.Members.FirstOrDefault(m => m.MemberID == res.MemberID.Value);
                                if (member != null)
                                {
                                    //讀取現有點數,如果null就塞0
                                    int currentPoints = member.Point ?? 0;

                                    //讀取剛剛結帳畫面決定要扣除的點數
                                    int usedPoints = res.UsedPoints;

                                    // 先扣除使用的點數
                                    currentPoints -= usedPoints;

                                    //透過 LevelID 去 MemberLevels 表找出倍率
                                    decimal multiplier = 1.0m; // 預設是1倍
                                    if (member.LevelID != null)
                                    {
                                        var level = db.MemberLevels.FirstOrDefault(l => l.LevelID == member.LevelID);
                                        if (level != null)
                                        {
                                            multiplier = level.PointMultiplier;
                                        }
                                    }

                                    //規則是滿 100 元得 1 點
                                    earnedPoints = (int)Math.Floor(res.FinalAmount * multiplier);

                                    //原有點數 - 使用點數 + 獲得點數
                                    member.Point = currentPoints + earnedPoints;
                                    db.SaveChanges();
                                }
                            }
                            //所有動作完成，丟給資料庫 Commit
                            dbContextTransaction.Commit();

                            //顯示結帳完成訊息
                            string memberInfo = res.IsMember ? $"會員手機：{res.MemberPhone}\n折扣金額：-${res.DiscountAmount}\n使用點數：-{res.UsedPoints} 點\n獲得點數：+{earnedPoints} 點\n" : "非會員結帳\n";
                            string carrierInfo = res.CarrierType == "紙本發票" ? "紙本發票" : $"{res.CarrierType}: {res.CarrierNumber}";

                            string summary = $"【訂單完成！】\n\n" +
                                             $"單號：{newOrder.OrderID}\n" +
                                             $"用餐方式：{orderTypeStr}\n" +
                                             $"商品總數：{shoppingCart.Sum(x => x.Quantity)} 件\n" +
                                             $"付款方式：{res.PaymentMethod}\n" +
                                             $"發票方式：{carrierInfo}\n" +
                                             $"----------------------\n" +
                                             $"原始金額：${res.TotalAmount}\n" +
                                             $"{memberInfo}" +
                                             $"實收總額：${res.FinalAmount}\n\n" +
                                             $"感謝您的光臨！";

                            MessageBox.Show(summary, "結帳成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 清空購物車
                            shoppingCart.Clear();
                            UpdateCartUI();

                            //重新整理目前分類畫面，若商品剛好賣到庫存為 0 會即時變成補貨中
                            LoadProductsByCategory(currentCategoryId);
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            MessageBox.Show("寫入資料庫失敗：" + ex.Message, "系統錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void CreateCategoryButton(Category cat)
        {
            IconButton btn = new IconButton();
            btn.Width = panelLeft.ClientSize.Width - 30;
            btn.Height = 80;
            btn.Text = "  " + cat.CategoryName;
            btn.Tag = cat; // 把 EF 的物件塞進 Tag
            btn.Font = new Font("微軟正黑體", 16F, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(0, 0, 0, 0);
            btn.Margin = new Padding(0, 0, 0, 5);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.BackColor = Color.FromArgb(60, 40, 30);
            btn.ForeColor = Color.White;
            btn.IconColor = Color.FromArgb(230, 85, 30);
            btn.IconSize = 40;

            if (Enum.TryParse(cat.IconName, true, out IconChar iconEnum))
            {
                btn.IconChar = iconEnum;
            }
            else
            {
                btn.IconChar = IconChar.Utensils;
            }
            btn.Click += CategoryButton_Click;

            panelLeft.Controls.Add(btn);
        }

        private void ActivateButton(IconButton senderBtn)
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(60, 40, 30);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.FromArgb(230, 85, 30);
            }

            currentBtn = senderBtn;
            currentBtn.BackColor = Color.FromArgb(230, 85, 30);
            currentBtn.ForeColor = Color.White;
            currentBtn.IconColor = Color.White;
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            IconButton clickedBtn = sender as IconButton;
            if (clickedBtn != null)
            {
                ActivateButton(clickedBtn);

                Category selectedCat = clickedBtn.Tag as Category;

                if (selectedCat != null)
                {
                    // 記錄當前點擊的分類 ID
                    currentCategoryId = selectedCat.CategoryID;

                    // 清空搜尋框並恢復提示狀態
                    txtSearch.Text = "搜尋商品...";
                    txtSearch.ForeColor = Color.Gray;

                    // 載入該分類的商品
                    LoadProductsByCategory(currentCategoryId);
                }
            }
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消點餐並返回首頁嗎?", "返回首頁", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Close();
            }
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            isDineIn = !isDineIn;

            int targetX = isDineIn ? 5 : 90;
            panelToggleSlider.Location = new Point(targetX, 5);

            if (isDineIn)
            {
                panelToggleContainer.BackColor = Color.FromArgb(160, 82, 45);
                lblToggleText.Text = "內用";
                lblToggleText.ForeColor = Color.Black;
            }
            else
            {
                panelToggleContainer.BackColor = Color.FromArgb(230, 85, 30);
                lblToggleText.Text = "外帶";
                lblToggleText.ForeColor = Color.Black;
            }

            panelToggleSlider.BringToFront();
            lblToggleText.BringToFront();
            panelToggleContainer.Refresh();
        }
    }
}