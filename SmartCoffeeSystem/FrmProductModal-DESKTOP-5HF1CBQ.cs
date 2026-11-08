using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCoffeeSystem;
using SmartCoffeeSystem.models;
using System.IO;

namespace SmartCoffeeSystem
{
    public partial class FrmProductModal : Form
    {
        private Product currentProduct;
        private int quantity = 1;
        private int basePrice = 0;
        private int totalAmount = 0;
        private TextBox txtRemark;

        // 要給購物頁面讀的屬性資料~所以設公開
        public string SelectedSpecString { get; private set; } = "";
        public int FinalQuantity { get; private set; } = 1;
        public int FinalUnitPrice { get; private set; } = 0;
        public string RemarkString { get; private set; } = "";


        // 接首頁傳的Product
        public FrmProductModal(Product prod)
        {
            InitializeComponent();
            currentProduct = prod;
            basePrice = (int)prod.Price;

            // 介面定個位
            lblName.Text = prod.ProductName;
            lblPrice.Text = $"${basePrice}";

            // 產品圖片展示
            picProduct.SetBounds(30, 30, 220, 220);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.BackColor = Color.FromArgb(245, 245, 245);

            if (!string.IsNullOrEmpty(prod.ImagePath))
            {
                string fullImagePath = Path.Combine(Application.StartupPath, "ProductImages", prod.ImagePath);
                if (File.Exists(fullImagePath))
                {
                    picProduct.Image = Image.FromFile(fullImagePath);
                }
                else
                {
                    string defaultPath = Path.Combine(Application.StartupPath, "ProductImages", "default.png");
                    if (File.Exists(defaultPath)) picProduct.Image = Image.FromFile(defaultPath);
                }
            }

            if (txtQuantity != null)
            {
                txtQuantity.MaxLength = 3;//算長度最多只能3位數
                txtQuantity.TextAlign = HorizontalAlignment.Center;
                txtQuantity.KeyPress += txtQuantity_KeyPress;
                txtQuantity.TextChanged += txtQuantity_TextChanged;
                txtQuantity.Leave += txtQuantity_Leave;
            }

            // 動態產生選項並計算初始價格
            GenerateCustomOptions();
            UpdateTotalAmount();
        }

        private string SanitizeRemark(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";
            // 移除前後多餘空白
            string clean = input.Trim();
            // 避免多餘符號
            clean = System.Text.RegularExpressions.Regex.Replace(clean, @"[<'"">;]|(--)|(/\*)|(\*/)", "");
            //過濾ASCII換行、ESC 指令、Tab
            clean = new string(clean.Where(c => !char.IsControl(c)).ToArray());
            //最多30個字
            if (clean.Length > 30) clean = clean.Substring(0, 30);
            return clean;
        }

        private void AddRemarkGroup()
        {
            // 標題與字數限制提示
            Label lblTitle = new Label();
            lblTitle.Text = "其他備註 (選填，限30字內)";
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(60, 40, 30);
            lblTitle.Width = 300;
            lblTitle.Margin = new Padding(5, 15, 0, 5);
            flowOptions.Controls.Add(lblTitle);

            // 文字輸入框
            txtRemark = new TextBox();
            txtRemark.Font = new Font("微軟正黑體", 16F);
            txtRemark.Width = 500;

            //最多只能輸入 30 個字元，到時候m/4資料庫 一樣可以設nvarchar(30)
            txtRemark.MaxLength = 30;
            txtRemark.BorderStyle = BorderStyle.FixedSingle;
            txtRemark.Margin = new Padding(5, 0, 0, 20);

            flowOptions.Controls.Add(txtRemark);
        }
        // 動態生成客製化選項
        private void GenerateCustomOptions()
        {
            flowOptions.Controls.Clear();

            switch (currentProduct.OptionType)
            {
                case "Coffee":
                    AddOptionGroup("容量選擇", new OptionItem[] {
                        new OptionItem { Name = "中杯 ", ExtraPrice = 0 },
                        new OptionItem { Name = "大杯", ExtraPrice = 10 }
                    });
                    AddOptionGroup("冰塊選擇", new OptionItem[] {
                        new OptionItem { Name = "正常冰", ExtraPrice = 0 },
                        new OptionItem { Name = "少冰", ExtraPrice = 0 },
                        new OptionItem { Name = "去冰", ExtraPrice = 0 },
                        new OptionItem { Name = "熱飲", ExtraPrice = 0 }
                    });
                    AddOptionGroup("甜度選擇", new OptionItem[] {
                        new OptionItem { Name = "正常糖", ExtraPrice = 0 },
                        new OptionItem { Name = "半糖", ExtraPrice = 0 },
                        new OptionItem { Name = "微糖", ExtraPrice = 0 },
                        new OptionItem { Name = "無糖", ExtraPrice = 0 }
                    });
                    break;

                case "Food":
                    AddOptionGroup("加熱服務", new OptionItem[] {
                        new OptionItem { Name = "現烤加熱", ExtraPrice = 0 },
                        new OptionItem { Name = "不需加熱", ExtraPrice = 0 }
                    });
                    AddOptionGroup("吐司處理", new OptionItem[] {
                        new OptionItem { Name = "正常 (保留吐司邊)", ExtraPrice = 0 },
                        new OptionItem { Name = "去邊", ExtraPrice = 0 }
                    });
                    break;

                case "Dessert":
                    AddOptionGroup("餐具選擇", new OptionItem[] {
                        new OptionItem { Name = "附叉盤組", ExtraPrice = 0 },
                        new OptionItem { Name = "不需要餐具", ExtraPrice = 0 }
                    });
                    break;

                case "None":
                default:
                    Label lblNone = new Label();
                    lblNone.Text = "此商品無客製化選項，請直接選擇數量後加入購物車。";
                    lblNone.Font = new Font("微軟正黑體", 14F);
                    lblNone.AutoSize = true;
                    flowOptions.Controls.Add(lblNone);
                    break;
            }
            AddRemarkGroup();
        }


        // 產生一組選項按鈕

        private void AddOptionGroup(string title, OptionItem[] options)
        {
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("微軟正黑體", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(60, 40, 30);
            lblTitle.Width = flowOptions.Width - 40;
            lblTitle.Margin = new Padding(5, 15, 0, 10);
            flowOptions.Controls.Add(lblTitle);

            FlowLayoutPanel panelGroup = new FlowLayoutPanel();
            panelGroup.Width = flowOptions.Width - 40;
            panelGroup.AutoSize = true;
            panelGroup.Margin = new Padding(0, 0, 0, 10);

            for (int i = 0; i < options.Length; i++)
            {
                RadioButton btnRadio = new RadioButton();
                btnRadio.Appearance = Appearance.Button;

                // 畫面上顯示組裝好的字眼 (如: 大杯 (+$10))
                btnRadio.Text = options[i].GetDisplayText();

                // 將純資料卡片藏在 Tag 裡
                btnRadio.Tag = options[i];

                btnRadio.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
                btnRadio.Size = new Size(150, 50);
                btnRadio.TextAlign = ContentAlignment.MiddleCenter;
                btnRadio.FlatStyle = FlatStyle.Flat;
                btnRadio.FlatAppearance.BorderSize = 1;
                btnRadio.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
                btnRadio.Margin = new Padding(0, 0, 15, 15);
                btnRadio.Cursor = Cursors.Hand;

                if (i == 0)
                {
                    btnRadio.Checked = true;
                    btnRadio.BackColor = Color.FromArgb(230, 85, 30); // 橘底
                    btnRadio.ForeColor = Color.White;
                }
                else
                {
                    btnRadio.BackColor = Color.White;
                    btnRadio.ForeColor = Color.FromArgb(60, 40, 30); // 深咖啡字
                }

                btnRadio.CheckedChanged += (s, e) =>
                {
                    if (btnRadio.Checked)
                    {
                        btnRadio.BackColor = Color.FromArgb(230, 85, 30);
                        btnRadio.ForeColor = Color.White;
                    }
                    else
                    {
                        btnRadio.BackColor = Color.White;
                        btnRadio.ForeColor = Color.FromArgb(60, 40, 30);
                    }

                    UpdateTotalAmount();
                };

                panelGroup.Controls.Add(btnRadio);
            }
            flowOptions.Controls.Add(panelGroup);
        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 如果輸入不是數字也不是控制鍵>>刪除箭，那就直接沒收~不給填，
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 攔截特殊符號、英文字母、空格與中文
            }
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int val) && val > 0)
            {
                // 單筆上限 999 杯 (避免 Int溢位)
                quantity = Math.Min(val, 999);

                // 呼叫算錢,並傳入 false,避免游標跳位
                UpdateTotalAmount(false);
            }
            else if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                // 數字全部刪光想重新打字時，先算數量1的錢，但畫面留空讓他打
                quantity = 1;
                UpdateTotalAmount(false);
            }
        }
        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            // 如果空白或0，強制改1杯~
            if (!int.TryParse(txtQuantity.Text, out int val) || val < 1)
            {
                quantity = 1;
                UpdateTotalAmount(true); //傳入true，強制把1寫回
            }
            else
            {
                // 如果輸入的是 "007大戰金鎗課"，順便改成7
                quantity = Math.Min(val, 999);
                UpdateTotalAmount(true);
            }
        }

        private void UpdateTotalAmount(bool updateTextBox = true)
        {
            if (quantity < 1) quantity = 1;
            int currentUnitPrice = (int)currentProduct.Price;

            // 掃描 RadioButton，從 Tag 提取加價相加
            foreach (Control control in flowOptions.Controls)
            {
                if (control is FlowLayoutPanel panelGroup)
                {
                    foreach (Control btnControl in panelGroup.Controls)
                    {
                        if (btnControl is RadioButton rdo && rdo.Checked)
                        {
                            if (rdo.Tag is OptionItem item)
                            {
                                currentUnitPrice += item.ExtraPrice;
                            }
                        }
                    }
                }
            }

            totalAmount = currentUnitPrice * quantity;
            lblPrice.Text = $"單價 ${currentUnitPrice}";

            //只有在非打字狀態下，才把數字寫回 TextBox，避免跳掉
            if (updateTextBox && txtQuantity.Text != quantity.ToString())
            {
                txtQuantity.Text = quantity.ToString();
            }

            btnAdd.Text = $"➕ 加入購物車 (${totalAmount})";
        }


        // 按鈕事件

        private void btnPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            UpdateTotalAmount();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                UpdateTotalAmount();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> selectedOptions = new List<string>();

            // 收集選取品項的 Option 名稱
            foreach (Control control in flowOptions.Controls)
            {
                if (control is FlowLayoutPanel panelGroup)
                {
                    foreach (Control btnControl in panelGroup.Controls)
                    {
                        if (btnControl is RadioButton rdo && rdo.Checked)
                        {
                            if (rdo.Tag is OptionItem item)
                            {
                                selectedOptions.Add(item.Name);
                            }
                        }
                    }
                }
            }

            // 取得備註
            if (txtRemark != null && !string.IsNullOrWhiteSpace(txtRemark.Text))
            {
                string safeRemark = SanitizeRemark(txtRemark.Text);
                if (!string.IsNullOrEmpty(safeRemark))
                {
                    selectedOptions.Add($"\n備註: {safeRemark}");
                    RemarkString = safeRemark; // 順變存到公開屬性，方便未來獨立寫入資料庫Note欄位
                }
            }

            // 組出最後字串
            SelectedSpecString = string.Join(" / ", selectedOptions);
            FinalQuantity = quantity;
            FinalUnitPrice = totalAmount / quantity;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}