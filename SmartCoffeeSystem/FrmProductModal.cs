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
using SmartCoffeeSystem.models; // keep OptionItem and other helper models
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

        public string SelectedSpecString { get; private set; } = "";
        public int FinalQuantity { get; private set; } = 1;
        public int FinalUnitPrice { get; private set; } = 0;
        public string RemarkString { get; private set; } = "";

        public FrmProductModal(Product prod)
        {
            InitializeComponent();
            currentProduct = prod;
            basePrice = (int)prod.Price;

            lblName.Text = prod.ProductName;
            lblPrice.Text = $"${basePrice}";

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
                txtQuantity.MaxLength = 3;
                txtQuantity.TextAlign = HorizontalAlignment.Center;
                txtQuantity.KeyPress += txtQuantity_KeyPress;
                txtQuantity.TextChanged += txtQuantity_TextChanged;
                txtQuantity.Leave += txtQuantity_Leave;
            }

            // 動態從資料庫讀取選項並計算初始價格
            GenerateCustomOptionsFromDatabase();
            UpdateTotalAmount();
        }

        // 
        void GenerateCustomOptionsFromDatabase()
        {
            flowOptions.Controls.Clear();

            try
            {
                using (var db = new POSContext())
                {
                    // 從Map對應表李找商品所對應群組的ID，然後再去抓查群組資料
                    var groupIds = db.ProductOptionMappings
                                     .Where(m => m.ProductID == currentProduct.ProductID)
                                     .Select(m => m.GroupID)
                                     .Distinct()
                                     .ToList();

                    // 撈所有群組資料
                    var groups = db.ProductOptionGroups
                                   .Where(g => groupIds.Contains(g.GroupID))
                                   .OrderBy(g => g.DisplayOrder)
                                   .ToList();

                    // 一次把這些群組所有的細項全撈到記憶體
                    var allItems = db.ProductOptionItems
                                     .Where(i => groupIds.Contains(i.GroupID))
                                     .OrderBy(i => i.DisplayOrder)
                                     .ToList();

                    if (groups.Count == 0)
                    {
                        Label lblNone = new Label();
                        lblNone.Text = "此商品無客製化選項，請選擇數量後加入購物車";
                        lblNone.Font = new Font("微軟正黑體", 14F);
                        lblNone.AutoSize = true;
                        flowOptions.Controls.Add(lblNone);
                    }
                    else
                    {
                        foreach (var group in groups)
                        {
                            var item = allItems.Where(i => i.GroupID == group.GroupID).ToList();

                            var optionItemsArray = item.Select(i => new OptionItem
                            {
                                Name = i.ItemName,
                                ExtraPrice = i.ExtraPrice ?? 0
                            }).ToArray();

                            AddOptionGroup(group.GroupName, optionItemsArray);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取選項失敗： {ex.Message}, 系統錯誤, {MessageBoxButtons.OK}, {MessageBoxIcon.Error}");
            }

            // 最後加上備註欄位
            AddRemarkGroup();
        }

        string SanitizeRemark(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";
            string clean = input.Trim();
            clean = System.Text.RegularExpressions.Regex.Replace(clean, @"[<'"">;]|(--)|(/\*)|(\*/)", "");
            clean = new string(clean.Where(c => !char.IsControl(c)).ToArray());
            if (clean.Length > 30) clean = clean.Substring(0, 30);
            return clean;
        }

        void AddRemarkGroup()
        {
            Label lblTitle = new Label();
            lblTitle.Text = "其他備註 (選填，限30字內)";
            lblTitle.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(60, 40, 30);
            lblTitle.Width = 300;
            lblTitle.Margin = new Padding(5, 15, 0, 5);
            flowOptions.Controls.Add(lblTitle);

            txtRemark = new TextBox();
            txtRemark.Font = new Font("微軟正黑體", 16F);
            txtRemark.Width = 300;
            txtRemark.MaxLength = 30;
            txtRemark.BorderStyle = BorderStyle.FixedSingle;
            txtRemark.Margin = new Padding(5, 0, 0, 20);

            flowOptions.Controls.Add(txtRemark);
        }

        void AddOptionGroup(string title, OptionItem[] options)
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
                btnRadio.Text = options[i].GetDisplayText();
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
                    btnRadio.BackColor = Color.FromArgb(230, 85, 30);
                    btnRadio.ForeColor = Color.White;
                }
                else
                {
                    btnRadio.BackColor = Color.White;
                    btnRadio.ForeColor = Color.FromArgb(60, 40, 30);
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

        void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int val) && val > 0)
            {
                quantity = Math.Min(val, 999);
                UpdateTotalAmount(false);
            }
            else if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                quantity = 1;
                UpdateTotalAmount(false);
            }
        }

        void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int val) || val < 1)
            {
                quantity = 1;
                UpdateTotalAmount(true);
            }
            else
            {
                quantity = Math.Min(val, 999);
                UpdateTotalAmount(true);
            }
        }

        void UpdateTotalAmount(bool updateTextBox = true)
        {
            //強制讓商品數量最低為1
            if (quantity < 1) quantity = 1;
            int currentUnitPrice = (int)currentProduct.Price;

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

            if (updateTextBox && txtQuantity.Text != quantity.ToString())
            {
                txtQuantity.Text = quantity.ToString();
            }

            btnAdd.Text = $"➕ 加入購物車 (${totalAmount})";
        }

        void btnPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            UpdateTotalAmount();
        }

        void btnMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                UpdateTotalAmount();
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> selectedOptions = new List<string>();

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

            if (txtRemark != null && !string.IsNullOrWhiteSpace(txtRemark.Text))
            {
                string safeRemark = SanitizeRemark(txtRemark.Text);
                if (!string.IsNullOrEmpty(safeRemark))
                {
                    selectedOptions.Add($"{safeRemark}");
                    RemarkString = safeRemark;
                }
            }

            SelectedSpecString = string.Join(" / ", selectedOptions);
            FinalQuantity = quantity;
            FinalUnitPrice = totalAmount / quantity;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}