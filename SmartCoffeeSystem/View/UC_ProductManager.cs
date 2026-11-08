using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem
{
    public partial class UC_ProductManager : UserControl
    {
        //商品列表分頁痊癒變數
        private int currentPage = 1;
        private int pageSize = 20;
        private int totalPages = 1;
        private int totalRecords = 0;

        //關鍵防呆旗標
        private bool _isLoaded = false;

        public UC_ProductManager()
        {
            InitializeComponent();
            this.Load += UC_ProductManager_Load;
            BindEvents();

        }

        private void UC_ProductManager_Load(object sender, EventArgs e)
        {
            //關閉自動產生欄位
            dgvProducts.AutoGenerateColumns = false;
            dgvCategories.AutoGenerateColumns = false;

            //DataGridView商品
            colProdID.DataPropertyName = "ProductID";
            colProdName.DataPropertyName = "ProductName";
            colCategory.DataPropertyName = "Category";
            colPrice.DataPropertyName = "Price";
            colStock.DataPropertyName = "Stock";
            colIsActive.DataPropertyName = "Status";
            colSort.DataPropertyName = "Sort";

            //綁DataGridView分類
            colCatID.DataPropertyName = "CatID";
            colCatName.DataPropertyName = "CatName";
            colCatSort.DataPropertyName = "SortOrder";

            //載下拉選單
            LoadCategoryComboBox();
            LoadSortCategoryComboBox();

            //設計師可能產生的預設文字清空，確保一開始是查全部！
            if (txtSearchProd.Text == "txtSearchProd" || txtSearchProd.Text == "🔍 搜尋商品名稱")
            {
                txtSearchProd.Text = "";
            }

            //解除防呆
            _isLoaded = true;

            //載入資料
            LoadProducts();
            LoadCategories();

            //預設載入第一個分類的排序資料
            if (cboSortCategory.Items.Count > 0)
            {
                cboSortCategory.SelectedIndex = 0;
                LoadSortProducts();
            }
        }

        private void BindEvents()
        {
            cboFilterCategory.SelectedIndexChanged += (s, e) =>
            {
                if (_isLoaded)
                {
                    currentPage = 1;
                    LoadProducts();
                }
            };
            cboSortCategory.SelectedIndexChanged += (s, e) =>
            {
                if (_isLoaded) LoadSortProducts();
            };

            txtSearchProd.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { currentPage = 1; LoadProducts(); e.Handled = true; } };

            btnFirstPage.Click += (s, e) => { if (currentPage > 1) { currentPage = 1; LoadProducts(); } };
            btnPrevPage.Click += (s, e) => { if (currentPage > 1) { currentPage--; LoadProducts(); } };
            btnNextPage.Click += (s, e) => { if (currentPage < totalPages) { currentPage++; LoadProducts(); } };
            btnLastPage.Click += (s, e) => { if (currentPage < totalPages) { currentPage = totalPages; LoadProducts(); } };
        }

        //商品讀取標籤
        private void LoadCategoryComboBox()
        {
            try
            {
                using (var db = new POSContext())
                {
                    var cats = db.Categories
                        .OrderBy(c => c.SortOrder)
                        .Select(c => new { c.CategoryID, c.CategoryName })
                        .ToList();

                    cats.Insert(0, new { CategoryID = 0, CategoryName = "全部分類" });

                    cboFilterCategory.DataSource = cats;
                    cboFilterCategory.DisplayMember = "CategoryName";
                    cboFilterCategory.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"載入分類下拉選單錯誤: {ex.Message}");
            }
        }

        private void LoadProducts()
        {
            if (!_isLoaded) return;

            try
            {
                using (var db = new POSContext())
                {
                    var query = db.Products.AsQueryable();

                    if (cboFilterCategory.SelectedValue != null)
                    {
                        if (int.TryParse(cboFilterCategory.SelectedValue.ToString(), out int catId) && catId > 0)
                        {
                            query = query.Where(p => p.CategoryID == catId);
                        }
                    }

                    string keyword = txtSearchProd.Text.Trim();
                    // 確認關鍵字不是空的，也不是浮水印文字才執行篩選
                    if (!string.IsNullOrEmpty(keyword) && keyword != "🔍 搜尋商品名稱" && keyword != "txtSearchProd")
                    {
                        query = query.Where(p => p.ProductName.Contains(keyword));
                    }

                    totalRecords = query.Count();
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (totalPages == 0) totalPages = 1;
                    if (currentPage > totalPages) currentPage = totalPages;

                    var pagedProducts = query
                        .OrderBy(p => p.CategoryID).ThenBy(p => p.Sort)
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    var allCategories = db.Categories.ToList();

                    List<ProductView> list = new List<ProductView>();
                    foreach (var p in pagedProducts)
                    {
                        var catName = allCategories.FirstOrDefault(c => c.CategoryID == p.CategoryID)?.CategoryName ?? "未分類";

                        list.Add(new ProductView
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName ?? "未命名",
                            Category = catName,
                            Price = p.Price ?? 0,
                            Stock = p.Stock ?? 0,
                            Status = p.IsActive == true ? "上架中" : "已下架",
                            Sort = p.Sort ?? 0
                        });
                    }

                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = list;

                    lblPageInfo.Text = $"第 {currentPage} 頁 / 共 {totalPages} 頁 (總計 {totalRecords} 筆)";
                    btnFirstPage.Enabled = btnPrevPage.Enabled = (currentPage > 1);
                    btnNextPage.Enabled = btnLastPage.Enabled = (currentPage < totalPages);
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"載入商品發生錯誤：\n{ex.Message}");
            }
        }

        //分類維護標籤
        private void LoadCategories()
        {
            if (!_isLoaded) return;

            try
            {
                using (var db = new POSContext())
                {
                    var list = db.Categories
                        .OrderBy(c => c.SortOrder)
                        .Select(c => new
                        {
                            CatID = c.CategoryID,
                            CatName = c.CategoryName,
                            SortOrder = c.SortOrder
                        }).ToList();

                    dgvCategories.DataSource = null;
                    dgvCategories.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("載入分類錯誤：" + ex.Message);
            }
        }

        //CRUD
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //開空白視窗
            ProductEditForm frm = new ProductEditForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        //表單準備好的ProductEntity加入資料庫
                        db.Products.Add(frm.ProductEntity);
                        db.SaveChanges(); //寫資料庫

                        UIMessageBox.ShowSuccess("商品新增成功！");
                    }

                    //重載
                    LoadProducts();
                    LoadSortProducts();
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"新增失敗：{ex.Message}");
                }
            }
        }

        //前台排序邏輯
        private void LoadSortCategoryComboBox()
        {
            try
            {
                using (var db = new POSContext())
                {
                    var cats = db.Categories
                        .OrderBy(c => c.SortOrder)
                        .Select(c => new { c.CategoryID, c.CategoryName })
                        .ToList();

                    cboSortCategory.DataSource = cats;
                    cboSortCategory.DisplayMember = "CategoryName";
                    cboSortCategory.ValueMember = "CategoryID";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"載入分類排序下拉選單錯誤: {ex.Message}");
            }
        }

        private void LoadSortProducts()
        {
            if (cboSortCategory.SelectedValue == null) return;

            if (int.TryParse(cboSortCategory.SelectedValue.ToString(), out int catId))
            {
                using (var db = new POSContext())
                {
                    var prods = db.Products
                        .Where(p => p.CategoryID == catId && p.IsActive == true)
                        .OrderBy(p => p.Sort)
                        .Select(p => new SortItem { ID = p.ProductID, Name = p.ProductName })
                        .ToList();

                    listSortProducts.DataSource = null;
                    listSortProducts.DataSource = prods;
                    listSortProducts.DisplayMember = "Name";
                    listSortProducts.ValueMember = "ID";
                }
            }
        }

        private void btnPriview_Click(object sender, EventArgs e)
        {
            FrmPOS openForm = Application.OpenForms.OfType<FrmPOS>().FirstOrDefault();
            if (openForm != null)
            {
                openForm.BringToFront();
                return;
            }

            FrmPOS f = new FrmPOS();

            //開啟預覽模式,把結帳按鈕鎖一所
            f.IsPreviewMode = true;

            f.WindowState = FormWindowState.Normal;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Size = new Size(1024, 768);
            f.FormBorderStyle = FormBorderStyle.FixedDialog;
            f.Text = "POS 系統預覽畫面 (預覽模式)";
            f.MaximizeBox = false;

            f.Show();
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                UIMessageBox.ShowWarning("請先選擇要修改的商品！");
                return;
            }

            // 1. 取得選擇的商品 ID
            int prodId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["colProdID"].Value);

            Product prodToEdit;
            using (var db = new POSContext())
            {
                // 2. 從資料庫撈出該筆商品的完整實體 (Entity)
                prodToEdit = db.Products.Find(prodId);
            }

            if (prodToEdit == null)
            {
                UIMessageBox.ShowError("找不到該筆商品資料，可能已被刪除！");
                return;
            }

            // 3. 將撈出來的商品實體傳入編輯表單 (使用多載建構子)
            ProductEditForm frm = new ProductEditForm(prodToEdit);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        // 4. 因為 EF Tracking 的關係，最安全的更新方式是撈出舊資料，把新值蓋過去
                        var dbProd = db.Products.Find(frm.ProductEntity.ProductID);
                        if (dbProd != null)
                        {
                            dbProd.ProductName = frm.ProductEntity.ProductName;
                            dbProd.Price = frm.ProductEntity.Price;
                            dbProd.Stock = frm.ProductEntity.Stock;
                            dbProd.Sort = frm.ProductEntity.Sort;
                            dbProd.ImagePath = frm.ProductEntity.ImagePath;
                            dbProd.IsActive = frm.ProductEntity.IsActive;
                            dbProd.CategoryID = frm.ProductEntity.CategoryID;

                            db.SaveChanges(); // 真正更新資料庫
                            UIMessageBox.ShowSuccess("商品修改成功！");
                        }
                    }

                    // 5. 重新載入畫面與排序下拉選單
                    LoadProducts();
                    LoadSortProducts();
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"修改失敗：{ex.Message}");
                }
            }

        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                UIMessageBox.ShowWarning("請先選擇要操作的商品！");
                return;
            }

            int prodId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["colProdID"].Value);
            string prodName = dgvProducts.CurrentRow.Cells["colProdName"].Value.ToString();

            // 讀取當前畫面上的狀態，來決定要詢問「上架」還是「下架」
            string currentStatus = dgvProducts.CurrentRow.Cells["colIsActive"].Value?.ToString() ?? "";
            string actionText = currentStatus.Contains("上架") ? "下架" : "上架";

            if (UIMessageBox.ShowAsk($"確定要將商品「{prodName}」{actionText}嗎？"))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var prod = db.Products.Find(prodId);
                        if (prod != null)
                        {
                            // 狀態切換：如果是 true 就變 false，反之亦然
                            // (加上 == true 是為了防止資料庫欄位為 nullable bool 造成的錯誤)
                            prod.IsActive = !(prod.IsActive == true);

                            db.SaveChanges();
                            UIMessageBox.ShowSuccess($"{actionText}成功！");

                            LoadProducts(); // 刷新列表
                            LoadSortProducts(); // 刷新排序清單
                        }
                        else
                        {
                            UIMessageBox.ShowError("找不到該筆商品資料，可能已被移除！");
                        }
                    }
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"更新狀態失敗。\n錯誤訊息：{ex.Message}");
                }
            }
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            if (_isLoaded)
            {
                currentPage = 1;
                LoadProducts();
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (listSortProducts.Items.Count == 0) return;

            try
            {
                using (var db = new POSContext())
                {
                    var list = (List<SortItem>)listSortProducts.DataSource;

                    for (int i = 0; i < list.Count; i++)
                    {
                        var prod = db.Products.Find(list[i].ID);
                        if (prod != null)
                        {
                            prod.Sort = i + 1;
                        }
                    }
                    db.SaveChanges();
                    UIMessageBox.ShowSuccess("前台排序更新成功！");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"儲存失敗：{ex.Message}");
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            int index = listSortProducts.SelectedIndex;
            if (index < listSortProducts.Items.Count - 1 && index != -1)
            {
                var item = listSortProducts.SelectedItem;
                var list = (List<SortItem>)listSortProducts.DataSource;

                list.RemoveAt(index);
                list.Insert(index + 1, (SortItem)item);

                listSortProducts.DataSource = null;
                listSortProducts.DataSource = list;
                listSortProducts.DisplayMember = "Name";
                listSortProducts.ValueMember = "ID";
                listSortProducts.SelectedIndex = index + 1;
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            int index = listSortProducts.SelectedIndex;
            if (index > 0)
            {
                var item = listSortProducts.SelectedItem;
                var list = (List<SortItem>)listSortProducts.DataSource;

                list.RemoveAt(index);
                list.Insert(index - 1, (SortItem)item);

                listSortProducts.DataSource = null;
                listSortProducts.DataSource = list;
                listSortProducts.DisplayMember = "Name";
                listSortProducts.ValueMember = "ID";
                listSortProducts.SelectedIndex = index - 1;
            }
        }

        private void btnDelCat_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null) return;
            int catId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["colCatID"].Value);
            string catName = dgvCategories.CurrentRow.Cells["colCatName"].Value.ToString();

            if (UIMessageBox.ShowAsk($"確定要刪除分類「{catName}」嗎？\n這可能會影響該分類下的所有商品！"))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        // 防呆檢查：分類下是否還有商品？
                        bool hasProducts = db.Products.Any(p => p.CategoryID == catId);
                        if (hasProducts)
                        {
                            UIMessageBox.ShowWarning("無法刪除！此分類下還有商品，請先清空或轉移商品。");
                            return;
                        }

                        var cat = db.Categories.Find(catId);
                        if (cat != null)
                        {
                            db.Categories.Remove(cat);
                            db.SaveChanges();
                            UIMessageBox.ShowSuccess("分類刪除成功！");

                            // 刷新全域資料
                            LoadCategories();
                            LoadCategoryComboBox(); // 更新搜尋下拉選單
                            LoadSortCategoryComboBox(); // 更新排序下拉選單
                        }
                    }
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"刪除失敗：{ex.Message}");
                }
            }

        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            FrmCategoryEdit frm = new FrmCategoryEdit("新增商品分類");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string newName = frm.CategoryName;
                string newIcon = frm.SelectedIconName; //取得選中的圖示字串

                try
                {
                    using (var db = new POSContext())
                    {
                        if (db.Categories.Any(c => c.CategoryName == newName))
                        {
                            UIMessageBox.ShowWarning("已經有相同名稱的分類了！");
                            return;
                        }

                        int maxSort = db.Categories.Any() ? (db.Categories.Max(c => c.SortOrder) ?? 0) : 0;

                        var newCat = new Category
                        {
                            CategoryName = newName,
                            IconName = newIcon, //存入圖示字串
                            SortOrder = maxSort + 1
                        };

                        db.Categories.Add(newCat);
                        db.SaveChanges();
                    }

                    UIMessageBox.ShowSuccess("分類新增成功！");
                    LoadCategories();
                    LoadCategoryComboBox();
                    LoadSortCategoryComboBox();
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"新增分類失敗：{ex.Message}");
                }
            }
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                UIMessageBox.ShowWarning("請先選擇要修改的分類！");
                return;
            }

            int catId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["colCatID"].Value);
            string oldName = dgvCategories.CurrentRow.Cells["colCatName"].Value.ToString();

            //先去資料庫撈這個分類原本設定的 Icon，丟給視窗讓它亮起來
            string oldIcon = "Utensils";
            using (var db = new POSContext())
            {
                var currentCat = db.Categories.Find(catId);
                if (currentCat != null && !string.IsNullOrEmpty(currentCat.IconName))
                {
                    oldIcon = currentCat.IconName;
                }
            }

            //舊名稱和舊圖示傳進去
            FrmCategoryEdit frm = new FrmCategoryEdit("修改商品分類", oldName, oldIcon);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string newName = frm.CategoryName;
                string newIcon = frm.SelectedIconName;

                // 如果完全沒改，直接離開
                if (newName == oldName && newIcon == oldIcon) return;

                try
                {
                    using (var db = new POSContext())
                    {
                        if (db.Categories.Any(c => c.CategoryName == newName && c.CategoryID != catId))
                        {
                            UIMessageBox.ShowWarning("已經有相同名稱的分類了！");
                            return;
                        }

                        var cat = db.Categories.Find(catId);
                        if (cat != null)
                        {
                            cat.CategoryName = newName;
                            cat.IconName = newIcon; //圖示
                            db.SaveChanges();
                        }
                    }

                    UIMessageBox.ShowSuccess("分類修改成功！");
                    LoadCategories();
                    LoadCategoryComboBox();
                    LoadSortCategoryComboBox();
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"修改分類失敗：{ex.Message}");
                }
            }
        }
        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                UIMessageBox.Show("請先選擇要刪除的商品！");
                return;

            }
            int prodId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["colProdID"].Value);
            string prodName = dgvProducts.CurrentRow.Cells["colProdName"].Value.ToString();
            if (UIMessageBox.ShowAsk($"確定要刪除商品「{prodName}」嗎？\n(注意：此動作無法復原)"))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var prod = db.Products.Find(prodId);
                        if (prod != null)
                        {
                            //實體刪除
                            db.Products.Remove(prod);
                            db.SaveChanges();
                            UIMessageBox.ShowSuccess("刪除成功！");
                            LoadProducts(); // 刷新列表
                            LoadSortProducts(); // 刷新排序清單
                        }
                    }
                }

                catch (Exception ex)

                {
                    UIMessageBox.ShowError($"刪除失敗，可能有其他訂單關聯此商品。\n錯誤訊息：{ex.Message}");
                }
            }
        }

        private void btnOptional_Click(object sender, EventArgs e)
        {
            //防呆~
            if (dgvProducts.CurrentRow == null)
            {
                UIMessageBox.ShowWarning("請先選擇一個商品，才能設定它的自訂選項！");
                return;
            }

            int prodId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["colProdID"].Value);
            string prodName = dgvProducts.CurrentRow.Cells["colProdName"].Value.ToString();

            //商品ID和名稱傳建構子
            FrmProductOptionManager frm = new FrmProductOptionManager(prodId, prodName);
            frm.ShowDialog();
        }

        private void btnCatUp_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null || dgvCategories.CurrentRow.Index <= 0) return;

            int currentIndex = dgvCategories.CurrentRow.Index;
            int currentId = Convert.ToInt32(dgvCategories.Rows[currentIndex].Cells["colCatID"].Value);
            int prevId = Convert.ToInt32(dgvCategories.Rows[currentIndex - 1].Cells["colCatID"].Value);

            SwapCategorySort(currentId, prevId);
        }

        private void btnCatDown_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null || dgvCategories.CurrentRow.Index >= dgvCategories.Rows.Count - 1) return;

            int currentIndex = dgvCategories.CurrentRow.Index;
            int currentId = Convert.ToInt32(dgvCategories.Rows[currentIndex].Cells["colCatID"].Value);
            int nextId = Convert.ToInt32(dgvCategories.Rows[currentIndex + 1].Cells["colCatID"].Value);

            SwapCategorySort(currentId, nextId);
        }
        private void SwapCategorySort(int id1, int id2)
        {
            try
            {
                using (var db = new POSContext())
                {
                    var cat1 = db.Categories.Find(id1);
                    var cat2 = db.Categories.Find(id2);

                    if (cat1 != null && cat2 != null)
                    {
                        //因為你的 SortOrder是int?所以要加??--如果是null值預設0
                        int tempSort = cat1.SortOrder ?? 0;
                        cat1.SortOrder = cat2.SortOrder ?? 0;
                        cat2.SortOrder = tempSort;

                        db.SaveChanges();
                    }
                }

                // 更新畫面
                LoadCategories();
                LoadCategoryComboBox(); // 左下拉選單也一起更新排序
                LoadSortCategoryComboBox();

                //保持剛剛那一個分類，使用者可以狂點上移
                foreach (DataGridViewRow row in dgvCategories.Rows)
                {
                    if (Convert.ToInt32(row.Cells["colCatID"].Value) == id1)
                    {
                        dgvCategories.CurrentCell = row.Cells["colCatName"];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"排序修改失敗：{ex.Message}");
            }
        }
    }

    public class SortItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}