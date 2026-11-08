namespace SmartCoffeeSystem
{
    partial class UC_ProductManager
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

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new Sunny.UI.UITabControl();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProdBottom = new System.Windows.Forms.Panel();
            this.btnFirstPage = new Sunny.UI.UIButton();
            this.btnPrevPage = new Sunny.UI.UIButton();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNextPage = new Sunny.UI.UIButton();
            this.btnLastPage = new Sunny.UI.UIButton();
            this.pnlProdTop = new System.Windows.Forms.Panel();
            this.btnDelProduct = new Sunny.UI.UIButton();
            this.btnOptional = new Sunny.UI.UIButton();
            this.txtSearchProd = new Sunny.UI.UITextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddProd = new Sunny.UI.UIButton();
            this.btnEditProd = new Sunny.UI.UIButton();
            this.btnDelProd = new Sunny.UI.UIButton();
            this.cboFilterCategory = new Sunny.UI.UIComboBox();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.colCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCatTop = new System.Windows.Forms.Panel();
            this.btnAddCat = new Sunny.UI.UIButton();
            this.btnEditCat = new Sunny.UI.UIButton();
            this.btnDelCat = new Sunny.UI.UIButton();
            this.tabPageSorting = new System.Windows.Forms.TabPage();
            this.panelpriview = new System.Windows.Forms.Panel();
            this.btnPriview = new Sunny.UI.UIButton();
            this.listSortProducts = new System.Windows.Forms.ListBox();
            this.btnMoveUp = new Sunny.UI.UIButton();
            this.btnMoveDown = new Sunny.UI.UIButton();
            this.pnlSortTop = new System.Windows.Forms.Panel();
            this.lblSortHint = new System.Windows.Forms.Label();
            this.cboSortCategory = new Sunny.UI.UIComboBox();
            this.btnSaveOrder = new Sunny.UI.UIButton();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiMiniPagination1 = new Sunny.UI.UIMiniPagination();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiHeaderButton1 = new Sunny.UI.UIHeaderButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCatUp = new Sunny.UI.UIButton();
            this.btnCatDown = new Sunny.UI.UIButton();
            this.tabMain.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlProdBottom.SuspendLayout();
            this.pnlProdTop.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.pnlCatTop.SuspendLayout();
            this.tabPageSorting.SuspendLayout();
            this.pnlSortTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageProduct);
            this.tabMain.Controls.Add(this.tabPageCategory);
            this.tabMain.Controls.Add(this.tabPageSorting);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMain.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabMain.ItemSize = new System.Drawing.Size(150, 45);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.MainPage = "";
            this.tabMain.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1670, 1020);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 0;
            this.tabMain.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.tabMain.TabSelectedForeColor = System.Drawing.Color.White;
            this.tabMain.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tabPageProduct.Controls.Add(this.dgvProducts);
            this.tabPageProduct.Controls.Add(this.pnlProdBottom);
            this.tabPageProduct.Controls.Add(this.pnlProdTop);
            this.tabPageProduct.Location = new System.Drawing.Point(0, 45);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Size = new System.Drawing.Size(1670, 975);
            this.tabPageProduct.TabIndex = 0;
            this.tabPageProduct.Text = "商品資料維護";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdID,
            this.colProdName,
            this.colCategory,
            this.colPrice,
            this.colStock,
            this.colIsActive,
            this.colSort});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 80);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1670, 835);
            this.dgvProducts.TabIndex = 0;
            // 
            // colProdID
            // 
            this.colProdID.HeaderText = "ID";
            this.colProdID.Name = "colProdID";
            this.colProdID.ReadOnly = true;
            // 
            // colProdName
            // 
            this.colProdName.HeaderText = "商品名稱";
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "所屬分類";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "前台售價";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "庫存量";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "狀態 (上/下架)";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            // 
            // colSort
            // 
            this.colSort.HeaderText = "前台排序碼";
            this.colSort.Name = "colSort";
            this.colSort.ReadOnly = true;
            // 
            // pnlProdBottom
            // 
            this.pnlProdBottom.Controls.Add(this.btnFirstPage);
            this.pnlProdBottom.Controls.Add(this.btnPrevPage);
            this.pnlProdBottom.Controls.Add(this.lblPageInfo);
            this.pnlProdBottom.Controls.Add(this.btnNextPage);
            this.pnlProdBottom.Controls.Add(this.btnLastPage);
            this.pnlProdBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProdBottom.Location = new System.Drawing.Point(0, 915);
            this.pnlProdBottom.Name = "pnlProdBottom";
            this.pnlProdBottom.Size = new System.Drawing.Size(1670, 60);
            this.pnlProdBottom.TabIndex = 1;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFirstPage.Location = new System.Drawing.Point(281, 15);
            this.btnFirstPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(50, 30);
            this.btnFirstPage.TabIndex = 0;
            this.btnFirstPage.Text = "|<";
            this.btnFirstPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrevPage.Location = new System.Drawing.Point(341, 15);
            this.btnPrevPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(80, 30);
            this.btnPrevPage.TabIndex = 1;
            this.btnPrevPage.Text = "上一頁";
            this.btnPrevPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(441, 20);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(215, 21);
            this.lblPageInfo.TabIndex = 2;
            this.lblPageInfo.Text = "第 1 頁 / 共 1 頁 ( 總計 1 筆 )";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextPage.Location = new System.Drawing.Point(611, 15);
            this.btnNextPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(80, 30);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.Text = "下一頁";
            this.btnNextPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // btnLastPage
            // 
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLastPage.Location = new System.Drawing.Point(701, 15);
            this.btnLastPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(50, 30);
            this.btnLastPage.TabIndex = 4;
            this.btnLastPage.Text = ">|";
            this.btnLastPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // pnlProdTop
            // 
            this.pnlProdTop.Controls.Add(this.btnDelProduct);
            this.pnlProdTop.Controls.Add(this.btnOptional);
            this.pnlProdTop.Controls.Add(this.txtSearchProd);
            this.pnlProdTop.Controls.Add(this.lblTitle);
            this.pnlProdTop.Controls.Add(this.btnAddProd);
            this.pnlProdTop.Controls.Add(this.btnEditProd);
            this.pnlProdTop.Controls.Add(this.btnDelProd);
            this.pnlProdTop.Controls.Add(this.cboFilterCategory);
            this.pnlProdTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProdTop.Location = new System.Drawing.Point(0, 0);
            this.pnlProdTop.Name = "pnlProdTop";
            this.pnlProdTop.Size = new System.Drawing.Size(1670, 80);
            this.pnlProdTop.TabIndex = 2;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelProduct.FillColor = System.Drawing.Color.Red;
            this.btnDelProduct.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelProduct.Location = new System.Drawing.Point(587, 25);
            this.btnDelProduct.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(127, 35);
            this.btnDelProduct.TabIndex = 10;
            this.btnDelProduct.Text = "🧺刪除商品";
            this.btnDelProduct.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // btnOptional
            // 
            this.btnOptional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptional.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOptional.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOptional.Location = new System.Drawing.Point(432, 25);
            this.btnOptional.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOptional.Name = "btnOptional";
            this.btnOptional.Size = new System.Drawing.Size(149, 35);
            this.btnOptional.TabIndex = 10;
            this.btnOptional.Text = "⚙️商品選項自訂";
            this.btnOptional.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOptional.Click += new System.EventHandler(this.btnOptional_Click);
            // 
            // txtSearchProd
            // 
            this.txtSearchProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchProd.Location = new System.Drawing.Point(923, 25);
            this.txtSearchProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchProd.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearchProd.Name = "txtSearchProd";
            this.txtSearchProd.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearchProd.ShowText = false;
            this.txtSearchProd.Size = new System.Drawing.Size(150, 35);
            this.txtSearchProd.TabIndex = 9;
            this.txtSearchProd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearchProd.Watermark = "請輸入搜尋產品...";
            this.txtSearchProd.TextChanged += new System.EventHandler(this.txtSearchProd_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "商品資料庫管理";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddProd.Location = new System.Drawing.Point(140, 25);
            this.btnAddProd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(80, 35);
            this.btnAddProd.TabIndex = 1;
            this.btnAddProd.Text = "+ 新增商品";
            this.btnAddProd.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProd.FillColor = System.Drawing.Color.Gold;
            this.btnEditProd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditProd.Location = new System.Drawing.Point(226, 25);
            this.btnEditProd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(75, 35);
            this.btnEditProd.TabIndex = 2;
            this.btnEditProd.Text = "✎ 修改";
            this.btnEditProd.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnDelProd
            // 
            this.btnDelProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelProd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDelProd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelProd.Location = new System.Drawing.Point(307, 25);
            this.btnDelProd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(119, 35);
            this.btnDelProd.TabIndex = 3;
            this.btnDelProd.Text = "⚙️啟用/下架";
            this.btnDelProd.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // cboFilterCategory
            // 
            this.cboFilterCategory.DataSource = null;
            this.cboFilterCategory.FillColor = System.Drawing.Color.White;
            this.cboFilterCategory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterCategory.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboFilterCategory.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboFilterCategory.Location = new System.Drawing.Point(765, 26);
            this.cboFilterCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterCategory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterCategory.Name = "cboFilterCategory";
            this.cboFilterCategory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboFilterCategory.Size = new System.Drawing.Size(150, 34);
            this.cboFilterCategory.SymbolSize = 24;
            this.cboFilterCategory.TabIndex = 5;
            this.cboFilterCategory.Text = "全部分類";
            this.cboFilterCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterCategory.Watermark = "";
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tabPageCategory.Controls.Add(this.dgvCategories);
            this.tabPageCategory.Controls.Add(this.pnlCatTop);
            this.tabPageCategory.Location = new System.Drawing.Point(0, 45);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Size = new System.Drawing.Size(1670, 975);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "商品分類設定";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCatID,
            this.colCatSort,
            this.colCatName});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(0, 80);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowTemplate.Height = 40;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(1670, 895);
            this.dgvCategories.TabIndex = 0;
            // 
            // colCatID
            // 
            this.colCatID.HeaderText = "分類 ID";
            this.colCatID.Name = "colCatID";
            // 
            // colCatSort
            // 
            this.colCatSort.HeaderText = "排序";
            this.colCatSort.Name = "colCatSort";
            // 
            // colCatName
            // 
            this.colCatName.HeaderText = "分類名稱";
            this.colCatName.Name = "colCatName";
            // 
            // pnlCatTop
            // 
            this.pnlCatTop.Controls.Add(this.btnCatDown);
            this.pnlCatTop.Controls.Add(this.btnCatUp);
            this.pnlCatTop.Controls.Add(this.btnAddCat);
            this.pnlCatTop.Controls.Add(this.btnEditCat);
            this.pnlCatTop.Controls.Add(this.btnDelCat);
            this.pnlCatTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCatTop.Location = new System.Drawing.Point(0, 0);
            this.pnlCatTop.Name = "pnlCatTop";
            this.pnlCatTop.Size = new System.Drawing.Size(1670, 80);
            this.pnlCatTop.TabIndex = 1;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCat.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.Location = new System.Drawing.Point(20, 25);
            this.btnAddCat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(120, 35);
            this.btnAddCat.TabIndex = 0;
            this.btnAddCat.Text = "+ 新增分類";
            this.btnAddCat.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnEditCat
            // 
            this.btnEditCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCat.FillColor = System.Drawing.Color.Gold;
            this.btnEditCat.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditCat.Location = new System.Drawing.Point(150, 25);
            this.btnEditCat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Size = new System.Drawing.Size(100, 35);
            this.btnEditCat.TabIndex = 1;
            this.btnEditCat.Text = "✎ 修改";
            this.btnEditCat.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEditCat.Click += new System.EventHandler(this.btnEditCat_Click);
            // 
            // btnDelCat
            // 
            this.btnDelCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelCat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelCat.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCat.Location = new System.Drawing.Point(260, 25);
            this.btnDelCat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelCat.Name = "btnDelCat";
            this.btnDelCat.Size = new System.Drawing.Size(100, 35);
            this.btnDelCat.TabIndex = 2;
            this.btnDelCat.Text = "🗑 刪除";
            this.btnDelCat.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelCat.Click += new System.EventHandler(this.btnDelCat_Click);
            // 
            // tabPageSorting
            // 
            this.tabPageSorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tabPageSorting.Controls.Add(this.panelpriview);
            this.tabPageSorting.Controls.Add(this.btnPriview);
            this.tabPageSorting.Controls.Add(this.listSortProducts);
            this.tabPageSorting.Controls.Add(this.btnMoveUp);
            this.tabPageSorting.Controls.Add(this.btnMoveDown);
            this.tabPageSorting.Controls.Add(this.pnlSortTop);
            this.tabPageSorting.Location = new System.Drawing.Point(0, 45);
            this.tabPageSorting.Name = "tabPageSorting";
            this.tabPageSorting.Size = new System.Drawing.Size(1670, 975);
            this.tabPageSorting.TabIndex = 2;
            this.tabPageSorting.Text = "前台排序設定";
            // 
            // panelpriview
            // 
            this.panelpriview.Location = new System.Drawing.Point(635, 86);
            this.panelpriview.Name = "panelpriview";
            this.panelpriview.Size = new System.Drawing.Size(1032, 886);
            this.panelpriview.TabIndex = 4;
            // 
            // btnPriview
            // 
            this.btnPriview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriview.FillColor = System.Drawing.Color.Bisque;
            this.btnPriview.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriview.ForeColor = System.Drawing.Color.Coral;
            this.btnPriview.Location = new System.Drawing.Point(474, 100);
            this.btnPriview.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPriview.Name = "btnPriview";
            this.btnPriview.RectColor = System.Drawing.Color.Black;
            this.btnPriview.Size = new System.Drawing.Size(120, 35);
            this.btnPriview.TabIndex = 3;
            this.btnPriview.Text = "預覽畫面";
            this.btnPriview.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriview.Click += new System.EventHandler(this.btnPriview_Click);
            // 
            // listSortProducts
            // 
            this.listSortProducts.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.listSortProducts.ItemHeight = 27;
            this.listSortProducts.Location = new System.Drawing.Point(25, 100);
            this.listSortProducts.Name = "listSortProducts";
            this.listSortProducts.Size = new System.Drawing.Size(415, 787);
            this.listSortProducts.TabIndex = 0;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveUp.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Location = new System.Drawing.Point(485, 385);
            this.btnMoveUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(100, 60);
            this.btnMoveUp.TabIndex = 1;
            this.btnMoveUp.Text = "▲ 上移";
            this.btnMoveUp.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveDown.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Location = new System.Drawing.Point(485, 471);
            this.btnMoveDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(100, 60);
            this.btnMoveDown.TabIndex = 2;
            this.btnMoveDown.Text = "▼ 下移";
            this.btnMoveDown.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // pnlSortTop
            // 
            this.pnlSortTop.Controls.Add(this.lblSortHint);
            this.pnlSortTop.Controls.Add(this.cboSortCategory);
            this.pnlSortTop.Controls.Add(this.btnSaveOrder);
            this.pnlSortTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSortTop.Location = new System.Drawing.Point(0, 0);
            this.pnlSortTop.Name = "pnlSortTop";
            this.pnlSortTop.Size = new System.Drawing.Size(1670, 80);
            this.pnlSortTop.TabIndex = 3;
            // 
            // lblSortHint
            // 
            this.lblSortHint.AutoSize = true;
            this.lblSortHint.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortHint.Location = new System.Drawing.Point(20, 30);
            this.lblSortHint.Name = "lblSortHint";
            this.lblSortHint.Size = new System.Drawing.Size(240, 26);
            this.lblSortHint.TabIndex = 0;
            this.lblSortHint.Text = "請選擇要調整排序的分類：";
            // 
            // cboSortCategory
            // 
            this.cboSortCategory.DataSource = null;
            this.cboSortCategory.FillColor = System.Drawing.Color.White;
            this.cboSortCategory.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSortCategory.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboSortCategory.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboSortCategory.Location = new System.Drawing.Point(267, 25);
            this.cboSortCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSortCategory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboSortCategory.Name = "cboSortCategory";
            this.cboSortCategory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboSortCategory.Size = new System.Drawing.Size(200, 35);
            this.cboSortCategory.SymbolSize = 24;
            this.cboSortCategory.TabIndex = 1;
            this.cboSortCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboSortCategory.Watermark = "";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveOrder.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveOrder.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Location = new System.Drawing.Point(474, 25);
            this.btnSaveOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(120, 35);
            this.btnSaveOrder.TabIndex = 2;
            this.btnSaveOrder.Text = "儲存排序";
            this.btnSaveOrder.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(613, 347);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 2;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.uiTableLayoutPanel1.TabIndex = 3;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiMiniPagination1
            // 
            this.uiMiniPagination1.ButtonFillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.uiMiniPagination1.ButtonStyleInherited = false;
            this.uiMiniPagination1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiMiniPagination1.Location = new System.Drawing.Point(478, 80);
            this.uiMiniPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiMiniPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiMiniPagination1.Name = "uiMiniPagination1";
            this.uiMiniPagination1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiMiniPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiMiniPagination1.ShowText = false;
            this.uiMiniPagination1.Size = new System.Drawing.Size(433, 40);
            this.uiMiniPagination1.TabIndex = 2;
            this.uiMiniPagination1.Text = "uiMiniPagination1";
            this.uiMiniPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiMiniPagination1.TotalCount = 1000;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiButton1.Location = new System.Drawing.Point(442, 24);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "uiButton1";
            this.uiButton1.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // uiHeaderButton1
            // 
            this.uiHeaderButton1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiHeaderButton1.Location = new System.Drawing.Point(505, 14);
            this.uiHeaderButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton1.Name = "uiHeaderButton1";
            this.uiHeaderButton1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton1.Radius = 0;
            this.uiHeaderButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton1.Size = new System.Drawing.Size(100, 88);
            this.uiHeaderButton1.TabIndex = 3;
            this.uiHeaderButton1.Text = "uiHeaderButton1";
            this.uiHeaderButton1.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCatUp
            // 
            this.btnCatUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatUp.FillColor = System.Drawing.Color.Silver;
            this.btnCatUp.FillColor2 = System.Drawing.Color.Gray;
            this.btnCatUp.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCatUp.Location = new System.Drawing.Point(399, 39);
            this.btnCatUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCatUp.Name = "btnCatUp";
            this.btnCatUp.RectColor = System.Drawing.Color.Gray;
            this.btnCatUp.Size = new System.Drawing.Size(21, 21);
            this.btnCatUp.TabIndex = 3;
            this.btnCatUp.Text = "▲";
            this.btnCatUp.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCatUp.Click += new System.EventHandler(this.btnCatUp_Click);
            // 
            // btnCatDown
            // 
            this.btnCatDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatDown.FillColor = System.Drawing.Color.Silver;
            this.btnCatDown.FillColor2 = System.Drawing.Color.Gray;
            this.btnCatDown.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCatDown.Location = new System.Drawing.Point(426, 39);
            this.btnCatDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCatDown.Name = "btnCatDown";
            this.btnCatDown.RectColor = System.Drawing.Color.Gray;
            this.btnCatDown.Size = new System.Drawing.Size(21, 21);
            this.btnCatDown.TabIndex = 4;
            this.btnCatDown.Text = "▼";
            this.btnCatDown.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCatDown.Click += new System.EventHandler(this.btnCatDown_Click);
            // 
            // UC_ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Name = "UC_ProductManager";
            this.Size = new System.Drawing.Size(1670, 1020);
            this.tabMain.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlProdBottom.ResumeLayout(false);
            this.pnlProdBottom.PerformLayout();
            this.pnlProdTop.ResumeLayout(false);
            this.pnlProdTop.PerformLayout();
            this.tabPageCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.pnlCatTop.ResumeLayout(false);
            this.tabPageSorting.ResumeLayout(false);
            this.pnlSortTop.ResumeLayout(false);
            this.pnlSortTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl tabMain;

        // Tab 1 Components
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Panel pnlProdTop;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UIButton btnAddProd;
        private Sunny.UI.UIButton btnEditProd;
        private Sunny.UI.UIButton btnDelProd;
        private Sunny.UI.UIComboBox cboFilterCategory;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlProdBottom;
        private Sunny.UI.UIButton btnFirstPage;
        private Sunny.UI.UIButton btnPrevPage;
        private System.Windows.Forms.Label lblPageInfo;
        private Sunny.UI.UIButton btnNextPage;
        private Sunny.UI.UIButton btnLastPage;

        // Tab 2 Components
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.Panel pnlCatTop;
        private Sunny.UI.UIButton btnAddCat;
        private Sunny.UI.UIButton btnEditCat;
        private Sunny.UI.UIButton btnDelCat;
        private System.Windows.Forms.DataGridView dgvCategories;

        // Tab 3 Components
        private System.Windows.Forms.TabPage tabPageSorting;
        private System.Windows.Forms.Panel pnlSortTop;
        private System.Windows.Forms.Label lblSortHint;
        private Sunny.UI.UIComboBox cboSortCategory;
        private Sunny.UI.UIButton btnSaveOrder;
        private System.Windows.Forms.ListBox listSortProducts;
        private Sunny.UI.UIButton btnMoveUp;
        private Sunny.UI.UIButton btnMoveDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCatName;
        private Sunny.UI.UIButton btnPriview;
        private System.Windows.Forms.Panel panelpriview;
        private Sunny.UI.UITextBox txtSearchProd;
        private Sunny.UI.UIButton btnOptional;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIButton btnDelProduct;
        private Sunny.UI.UIMiniPagination uiMiniPagination1;
        private System.Windows.Forms.Button button1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIHeaderButton uiHeaderButton1;
        private Sunny.UI.UIButton btnCatDown;
        private Sunny.UI.UIButton btnCatUp;
    }
}