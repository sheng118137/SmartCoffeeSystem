namespace SmartCoffeeSystem
{
    partial class ProductEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditForm));
            this.lblName = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.lblCategory = new Sunny.UI.UILabel();
            this.cmbCategory = new Sunny.UI.UIComboBox();
            this.lblPrice = new Sunny.UI.UILabel();
            this.txtPrice = new Sunny.UI.UITextBox();
            this.lblImagePath = new Sunny.UI.UILabel();
            this.txtImagePath = new Sunny.UI.UITextBox();
            this.btnBrowseImage = new Sunny.UI.UIButton();
            this.chkActive = new Sunny.UI.UICheckBox();
            this.btnSave = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtStock = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtSort = new Sunny.UI.UITextBox();
            this.picEdit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblName.Location = new System.Drawing.Point(40, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "商品名稱：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(140, 94);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 10;
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(280, 35);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "請輸入商品名稱";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblCategory.Location = new System.Drawing.Point(40, 139);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 35);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "商品分類：";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = null;
            this.cmbCategory.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cmbCategory.FillColor = System.Drawing.Color.White;
            this.cmbCategory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCategory.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbCategory.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbCategory.Location = new System.Drawing.Point(140, 139);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbCategory.Radius = 10;
            this.cmbCategory.Size = new System.Drawing.Size(280, 35);
            this.cmbCategory.SymbolSize = 24;
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbCategory.Watermark = "";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPrice.Location = new System.Drawing.Point(40, 184);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 35);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "商品售價：";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(140, 184);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(5);
            this.txtPrice.Radius = 10;
            this.txtPrice.ShowText = false;
            this.txtPrice.Size = new System.Drawing.Size(280, 35);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPrice.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtPrice.Watermark = "例如: 120";
            // 
            // lblImagePath
            // 
            this.lblImagePath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblImagePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblImagePath.Location = new System.Drawing.Point(40, 274);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(100, 35);
            this.lblImagePath.TabIndex = 6;
            this.lblImagePath.Text = "商品圖片：";
            this.lblImagePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImagePath.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtImagePath.Location = new System.Drawing.Point(140, 274);
            this.txtImagePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImagePath.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Padding = new System.Windows.Forms.Padding(5);
            this.txtImagePath.Radius = 10;
            this.txtImagePath.ShowText = false;
            this.txtImagePath.Size = new System.Drawing.Size(280, 35);
            this.txtImagePath.TabIndex = 7;
            this.txtImagePath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtImagePath.Watermark = "自訂檔名 (例如: coffee.jpg)";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnBrowseImage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowseImage.Location = new System.Drawing.Point(437, 274);
            this.btnBrowseImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Radius = 10;
            this.btnBrowseImage.Size = new System.Drawing.Size(80, 35);
            this.btnBrowseImage.TabIndex = 8;
            this.btnBrowseImage.Text = "選擇檔案";
            this.btnBrowseImage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // chkActive
            // 
            this.chkActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActive.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.chkActive.Location = new System.Drawing.Point(140, 324);
            this.chkActive.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(200, 30);
            this.chkActive.TabIndex = 9;
            this.chkActive.Text = "是否上架此上品";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(53)))));
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(70)))));
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(290, 378);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 10;
            this.btnSave.RectColor = System.Drawing.Color.Transparent;
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "儲存";
            this.btnSave.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(43, 378);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 10;
            this.btnCancel.RectColor = System.Drawing.Color.Silver;
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(40, 322);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 35);
            this.uiLabel1.TabIndex = 12;
            this.uiLabel1.Text = "上架狀態：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStock
            // 
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStock.Location = new System.Drawing.Point(140, 229);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStock.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtStock.Name = "txtStock";
            this.txtStock.Padding = new System.Windows.Forms.Padding(5);
            this.txtStock.Radius = 10;
            this.txtStock.ShowText = false;
            this.txtStock.Size = new System.Drawing.Size(280, 35);
            this.txtStock.TabIndex = 5;
            this.txtStock.Text = "0";
            this.txtStock.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtStock.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.txtStock.Watermark = "例如: 120";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(40, 229);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 35);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "商品庫存：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(40, 49);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 35);
            this.uiLabel4.TabIndex = 13;
            this.uiLabel4.Text = "商品排序：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSort
            // 
            this.txtSort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSort.Location = new System.Drawing.Point(140, 49);
            this.txtSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSort.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSort.Name = "txtSort";
            this.txtSort.Padding = new System.Windows.Forms.Padding(5);
            this.txtSort.Radius = 10;
            this.txtSort.ShowText = false;
            this.txtSort.Size = new System.Drawing.Size(141, 35);
            this.txtSort.TabIndex = 1;
            this.txtSort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSort.Watermark = "請輸入商品排序";
            // 
            // picEdit
            // 
            this.picEdit.Location = new System.Drawing.Point(504, 49);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(208, 200);
            this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEdit.TabIndex = 14;
            this.picEdit.TabStop = false;
            // 
            // ProductEditForm
            // 
            this.ClientSize = new System.Drawing.Size(731, 446);
            this.Controls.Add(this.picEdit);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "商品編輯";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 480, 450);
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel lblCategory;
        private Sunny.UI.UIComboBox cmbCategory;
        private Sunny.UI.UILabel lblPrice;
        private Sunny.UI.UITextBox txtPrice;
        private Sunny.UI.UILabel lblImagePath;
        private Sunny.UI.UITextBox txtImagePath;
        private Sunny.UI.UIButton btnBrowseImage;
        private Sunny.UI.UICheckBox chkActive;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtStock;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtSort;
        private System.Windows.Forms.PictureBox picEdit;
    }
}