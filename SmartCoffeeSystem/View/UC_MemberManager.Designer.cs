namespace SmartCoffeeSystem.View
{
    partial class UC_MemberManager
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new Sunny.UI.UIPanel();
            this.dgvMembers = new Sunny.UI.UIDataGridView();
            this.panelTop = new Sunny.UI.UIPanel();
            this.cboFilterLevel = new Sunny.UI.UIComboBox();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.lblSearch = new Sunny.UI.UILabel();
            this.panelRight = new Sunny.UI.UIPanel();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.btnAddNew = new Sunny.UI.UIButton();
            this.txtTaxID = new Sunny.UI.UITextBox();
            this.lblTaxID = new Sunny.UI.UILabel();
            this.txtCarrier = new Sunny.UI.UITextBox();
            this.lblCarrier = new Sunny.UI.UILabel();
            this.txtPoints = new Sunny.UI.UITextBox();
            this.lblPoints = new Sunny.UI.UILabel();
            this.cboLevel = new Sunny.UI.UIComboBox();
            this.lblLevel = new Sunny.UI.UILabel();
            this.txtPhone = new Sunny.UI.UITextBox();
            this.lblPhone = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.lblName = new Sunny.UI.UILabel();
            this.lblEditTitle = new Sunny.UI.UILabel();
            this.colMemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dgvMembers);
            this.panelLeft.Controls.Add(this.panelTop);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.FillColor = System.Drawing.Color.White;
            this.panelLeft.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panelLeft.Size = new System.Drawing.Size(836, 1020);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Text = null;
            this.panelLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMembers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.ColumnHeadersHeight = 32;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberID,
            this.colPhone,
            this.colName,
            this.colLevel,
            this.colPoints});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.EnableHeadersVisualStyles = false;
            this.dgvMembers.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.dgvMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvMembers.Location = new System.Drawing.Point(15, 75);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMembers.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvMembers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMembers.RowTemplate.Height = 29;
            this.dgvMembers.SelectedIndex = -1;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(806, 930);
            this.dgvMembers.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cboFilterLevel);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.White;
            this.panelTop.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelTop.Location = new System.Drawing.Point(15, 15);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(806, 60);
            this.panelTop.TabIndex = 0;
            this.panelTop.Text = null;
            this.panelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboFilterLevel
            // 
            this.cboFilterLevel.DataSource = null;
            this.cboFilterLevel.FillColor = System.Drawing.Color.White;
            this.cboFilterLevel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.cboFilterLevel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboFilterLevel.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.cboFilterLevel.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.cboFilterLevel.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.cboFilterLevel.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.cboFilterLevel.Location = new System.Drawing.Point(349, 15);
            this.cboFilterLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboFilterLevel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboFilterLevel.Name = "cboFilterLevel";
            this.cboFilterLevel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboFilterLevel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.cboFilterLevel.Size = new System.Drawing.Size(170, 32);
            this.cboFilterLevel.Style = Sunny.UI.UIStyle.Custom;
            this.cboFilterLevel.SymbolSize = 24;
            this.cboFilterLevel.TabIndex = 2;
            this.cboFilterLevel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboFilterLevel.Watermark = "請篩選等級...";
            // 
            // txtSearch
            // 
            this.txtSearch.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtSearch.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.txtSearch.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.txtSearch.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtSearch.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.txtSearch.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.txtSearch.ButtonStyleInherited = false;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtSearch.Location = new System.Drawing.Point(130, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtSearch.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtSearch.ScrollBarStyleInherited = false;
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(200, 32);
            this.txtSearch.Style = Sunny.UI.UIStyle.Custom;
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "輸入手機號碼或姓名";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblSearch.Location = new System.Drawing.Point(37, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(86, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "快速尋找";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.btnDelete);
            this.panelRight.Controls.Add(this.btnSave);
            this.panelRight.Controls.Add(this.btnAddNew);
            this.panelRight.Controls.Add(this.txtTaxID);
            this.panelRight.Controls.Add(this.lblTaxID);
            this.panelRight.Controls.Add(this.txtCarrier);
            this.panelRight.Controls.Add(this.lblCarrier);
            this.panelRight.Controls.Add(this.txtPoints);
            this.panelRight.Controls.Add(this.lblPoints);
            this.panelRight.Controls.Add(this.cboLevel);
            this.panelRight.Controls.Add(this.lblLevel);
            this.panelRight.Controls.Add(this.txtPhone);
            this.panelRight.Controls.Add(this.lblPhone);
            this.panelRight.Controls.Add(this.txtName);
            this.panelRight.Controls.Add(this.lblName);
            this.panelRight.Controls.Add(this.lblEditTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelRight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelRight.Location = new System.Drawing.Point(836, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(20);
            this.panelRight.Size = new System.Drawing.Size(834, 1020);
            this.panelRight.TabIndex = 1;
            this.panelRight.Text = null;
            this.panelRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnDelete.Location = new System.Drawing.Point(495, 517);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelete.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Size = new System.Drawing.Size(110, 45);
            this.btnDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "刪除會員";
            this.btnDelete.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(292, 517);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "儲存設定";
            this.btnSave.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnAddNew.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(210)))), ((int)(((byte)(60)))));
            this.btnAddNew.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(120, 517);
            this.btnAddNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 45);
            this.btnAddNew.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "+ 新增";
            this.btnAddNew.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtTaxID
            // 
            this.txtTaxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaxID.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtTaxID.Location = new System.Drawing.Point(120, 450);
            this.txtTaxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaxID.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Padding = new System.Windows.Forms.Padding(5);
            this.txtTaxID.ShowText = false;
            this.txtTaxID.Size = new System.Drawing.Size(485, 35);
            this.txtTaxID.TabIndex = 12;
            this.txtTaxID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTaxID.Watermark = "選填";
            // 
            // lblTaxID
            // 
            this.lblTaxID.AutoSize = true;
            this.lblTaxID.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblTaxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTaxID.Location = new System.Drawing.Point(30, 457);
            this.lblTaxID.Name = "lblTaxID";
            this.lblTaxID.Size = new System.Drawing.Size(89, 20);
            this.lblTaxID.TabIndex = 11;
            this.lblTaxID.Text = "預設統編：";
            // 
            // txtCarrier
            // 
            this.txtCarrier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarrier.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtCarrier.Location = new System.Drawing.Point(120, 380);
            this.txtCarrier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarrier.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Padding = new System.Windows.Forms.Padding(5);
            this.txtCarrier.ShowText = false;
            this.txtCarrier.Size = new System.Drawing.Size(485, 35);
            this.txtCarrier.TabIndex = 10;
            this.txtCarrier.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCarrier.Watermark = "例如：/AB12345";
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblCarrier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblCarrier.Location = new System.Drawing.Point(30, 387);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(89, 20);
            this.lblCarrier.TabIndex = 9;
            this.lblCarrier.Text = "手機載具：";
            // 
            // txtPoints
            // 
            this.txtPoints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoints.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.txtPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtPoints.Location = new System.Drawing.Point(120, 310);
            this.txtPoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPoints.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Padding = new System.Windows.Forms.Padding(5);
            this.txtPoints.ShowText = false;
            this.txtPoints.Size = new System.Drawing.Size(485, 35);
            this.txtPoints.TabIndex = 8;
            this.txtPoints.Text = "0";
            this.txtPoints.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPoints.Watermark = "";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPoints.Location = new System.Drawing.Point(30, 317);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(89, 20);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "會員點數：";
            // 
            // cboLevel
            // 
            this.cboLevel.DataSource = null;
            this.cboLevel.FillColor = System.Drawing.Color.White;
            this.cboLevel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cboLevel.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboLevel.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboLevel.Location = new System.Drawing.Point(120, 240);
            this.cboLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLevel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboLevel.Size = new System.Drawing.Size(485, 35);
            this.cboLevel.SymbolSize = 24;
            this.cboLevel.TabIndex = 6;
            this.cboLevel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboLevel.Watermark = "";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLevel.Location = new System.Drawing.Point(30, 247);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(89, 20);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "會員等級：";
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtPhone.Location = new System.Drawing.Point(120, 170);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(5);
            this.txtPhone.ShowText = false;
            this.txtPhone.Size = new System.Drawing.Size(485, 35);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPhone.Watermark = "必填 (登入帳號)";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.Red;
            this.lblPhone.Location = new System.Drawing.Point(30, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(97, 21);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "手機號碼*：";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtName.Location = new System.Drawing.Point(120, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(485, 35);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "必填";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(30, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(97, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "會員姓名*：";
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.lblEditTitle.Location = new System.Drawing.Point(25, 30);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(580, 40);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "新增會員";
            this.lblEditTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colMemberID
            // 
            this.colMemberID.HeaderText = "ID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.ReadOnly = true;
            this.colMemberID.Visible = false;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "手機號碼";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 200;
            // 
            // colName
            // 
            this.colName.HeaderText = "會員姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colLevel
            // 
            this.colLevel.HeaderText = "目前等級";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            this.colLevel.Width = 200;
            // 
            // colPoints
            // 
            this.colPoints.HeaderText = "剩餘點數";
            this.colPoints.Name = "colPoints";
            this.colPoints.ReadOnly = true;
            this.colPoints.Width = 200;
            // 
            // UC_MemberManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "UC_MemberManager";
            this.Size = new System.Drawing.Size(1670, 1020);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelLeft;
        private Sunny.UI.UIDataGridView dgvMembers;
        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UILabel lblSearch;
        private Sunny.UI.UIPanel panelRight;
        private Sunny.UI.UILabel lblEditTitle;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UITextBox txtPhone;
        private Sunny.UI.UILabel lblPhone;
        private Sunny.UI.UIComboBox cboLevel;
        private Sunny.UI.UILabel lblLevel;
        private Sunny.UI.UITextBox txtPoints;
        private Sunny.UI.UILabel lblPoints;
        private Sunny.UI.UITextBox txtTaxID;
        private Sunny.UI.UILabel lblTaxID;
        private Sunny.UI.UITextBox txtCarrier;
        private Sunny.UI.UILabel lblCarrier;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnAddNew;
        private Sunny.UI.UIComboBox cboFilterLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;
    }
}