using Sunny.UI;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SmartCoffeeSystem
{
    public partial class ProductEditForm : UIForm
    {
        public Product ProductEntity { get; private set; }

        private string selectedSourceImagePath = string.Empty;

        public ProductEditForm()
        {
            InitializeComponent();
            // 在建構函式綁定 Load 事件
            this.Load += ProductEditForm_Load;
        }

        public ProductEditForm(Product p) : this()
        {
            ProductEntity = p;
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            using (var db = new POSContext())
            {
                var category = db.Categories.OrderBy(c => c.SortOrder).ToList();
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
                cmbCategory.DataSource = category;
            }

            if (ProductEntity != null)
            {
                // 如果是編輯，帶入原始資料
                txtSort.Text = Convert.ToString(ProductEntity.Sort);
                txtStock.Text = Convert.ToString(ProductEntity.Stock);
                txtName.Text = ProductEntity.ProductName;
                txtPrice.Text = ProductEntity.Price?.ToString() ?? "";
                txtImagePath.Text = ProductEntity.ImagePath;
                chkActive.Checked = ProductEntity.IsActive == true;
                cmbCategory.SelectedValue = ProductEntity.CategoryID;

                // 載入現有商品圖片
                if (!string.IsNullOrWhiteSpace(ProductEntity.ImagePath))
                {
                    string targetFolder = Path.Combine(Application.StartupPath, "ProductImages");
                    string fullPath = Path.Combine(targetFolder, ProductEntity.ImagePath);
                    LoadImageToPictureBox(fullPath);
                }
            }
            else
            {
                // 如果是新增商品，預設將狀態設為啟用
                chkActive.Checked = true;
                txtStock.Text = "0"; // 預設庫存為 0
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // 限定只能選取圖片檔案
                ofd.Filter = "圖片檔案 (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|所有檔案 (*.*)|*.*";
                ofd.Title = "請選擇商品圖片";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 暫存原始檔案路徑
                    selectedSourceImagePath = ofd.FileName;

                    // 把原始檔名提取出來丟到 TextBox，讓使用者可以自由改名
                    txtImagePath.Text = Path.GetFileName(ofd.FileName);

                    // 預覽使用者剛選擇的新圖片
                    LoadImageToPictureBox(selectedSourceImagePath);
                }
            }
        }

        // 獨立出一個安全載入圖片的方法
        private void LoadImageToPictureBox(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    // 釋放舊圖片資源，避免記憶體洩漏
                    if (picEdit.Image != null)
                    {
                        picEdit.Image.Dispose();
                        picEdit.Image = null;
                    }

                    // 避免 Image.FromFile 鎖死檔案，改用 FileStream 讀取進入記憶體
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        picEdit.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    // 找不到檔案時清空，或可以替換為預設的 Placeholder 圖片
                    picEdit.Image = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"圖片載入失敗: {ex.Message}");
                picEdit.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //基礎防呆檢查
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                UIMessageBox.ShowWarning("請輸入商品名稱！");
                return;
            }

            //獨立處理 Sort (排序) 欄位
            int? parsedSort = null;
            if (!string.IsNullOrWhiteSpace(txtSort.Text))
            {
                if (int.TryParse(txtSort.Text.Trim(), out int tempSort))
                {
                    parsedSort = tempSort;
                }
                else
                {
                    UIMessageBox.ShowWarning("「排序」欄位請輸入正確的數字格式！");
                    return;
                }
            }

            //獨立處理 Stock (庫存) 欄位
            int parsedStock = 0; // 庫存通常不能是 null，預設給 0
            if (!string.IsNullOrWhiteSpace(txtStock.Text))
            {
                if (int.TryParse(txtStock.Text.Trim(), out int tempStock))
                {
                    parsedStock = tempStock;
                }
                else
                {
                    UIMessageBox.ShowWarning("「庫存」欄位請輸入正確的數字格式！");
                    return;
                }
            }

            //處理圖片上傳邏輯
            string finalImageName = txtImagePath.Text.Trim();

            if (!string.IsNullOrEmpty(selectedSourceImagePath) && File.Exists(selectedSourceImagePath))
            {
                string targetFolder = Path.Combine(Application.StartupPath, "ProductImages");
                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                if (!string.IsNullOrEmpty(finalImageName) && !Path.HasExtension(finalImageName))
                {
                    finalImageName += Path.GetExtension(selectedSourceImagePath);
                }

                string targetPath = Path.Combine(targetFolder, finalImageName);

                try
                {
                    if (!selectedSourceImagePath.Equals(targetPath, StringComparison.OrdinalIgnoreCase))
                    {
                        File.Copy(selectedSourceImagePath, targetPath, true);
                    }
                }
                catch (Exception ex)
                {
                    UIMessageBox.Show($"圖片上傳失敗：{ex.Message}");
                    return;
                }
            }

            //幕後欄位與畫面欄位寫入 Entity
            if (ProductEntity == null)
            {
                ProductEntity = new Product();
                ProductEntity.CreateAt = DateTime.Now; // 預設當下時間
                ProductEntity.EmployeeId = 1;          // 預設員工編號
            }

            // 畫面欄位對應
            ProductEntity.ProductName = txtName.Text.Trim();
            ProductEntity.Price = string.IsNullOrWhiteSpace(txtPrice.Text) ? (int?)null : Convert.ToInt32(txtPrice.Text);

            // 把安全解析出來的排序跟庫存寫入實體
            if (parsedSort.HasValue)
            {
                ProductEntity.Sort = parsedSort.Value;
            }
            ProductEntity.Stock = parsedStock; // 寫入庫存

            ProductEntity.ImagePath = string.IsNullOrWhiteSpace(finalImageName) ? "default.png" : finalImageName;
            ProductEntity.IsActive = chkActive.Checked;

            if (cmbCategory.SelectedValue != null && int.TryParse(cmbCategory.SelectedValue.ToString(), out int cid))
            {
                ProductEntity.CategoryID = cid;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}