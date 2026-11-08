namespace SmartCoffeeSystem.View
{
    partial class UC_MemberLevelManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new Sunny.UI.UIPanel();
            this.dgvLevels = new Sunny.UI.UIDataGridView();
            this.panelTop = new Sunny.UI.UIPanel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.panelRight = new Sunny.UI.UIPanel();
            this.lblNotice2 = new Sunny.UI.UILabel();
            this.lblNotice1 = new Sunny.UI.UILabel();
            this.btnDelete = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.btnAddNew = new Sunny.UI.UIButton();
            this.txtUpgradeCost = new Sunny.UI.UITextBox();
            this.lblUpgradeCost = new Sunny.UI.UILabel();
            this.txtMultiplier = new Sunny.UI.UITextBox();
            this.lblMultiplier = new Sunny.UI.UILabel();
            this.txtDiscount = new Sunny.UI.UITextBox();
            this.lblDiscount = new Sunny.UI.UILabel();
            this.txtLevelName = new Sunny.UI.UITextBox();
            this.lblLevelName = new Sunny.UI.UILabel();
            this.lblEditTitle = new Sunny.UI.UILabel();
            this.colLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpgradeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dgvLevels);
            this.panelLeft.Controls.Add(this.panelTop);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.FillColor = System.Drawing.Color.White;
            this.panelLeft.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panelLeft.Size = new System.Drawing.Size(910, 1020);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Text = null;
            this.panelLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLevels
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvLevels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLevels.BackgroundColor = System.Drawing.Color.White;
            this.dgvLevels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLevels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLevels.ColumnHeadersHeight = 32;
            this.dgvLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevelID,
            this.colLevelName,
            this.colDiscount,
            this.colMultiplier,
            this.colUpgradeCost});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLevels.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLevels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLevels.EnableHeadersVisualStyles = false;
            this.dgvLevels.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.dgvLevels.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvLevels.Location = new System.Drawing.Point(15, 75);
            this.dgvLevels.MultiSelect = false;
            this.dgvLevels.Name = "dgvLevels";
            this.dgvLevels.ReadOnly = true;
            this.dgvLevels.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLevels.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLevels.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvLevels.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLevels.RowTemplate.Height = 29;
            this.dgvLevels.SelectedIndex = -1;
            this.dgvLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLevels.Size = new System.Drawing.Size(880, 930);
            this.dgvLevels.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.White;
            this.panelTop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.Location = new System.Drawing.Point(15, 15);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(880, 60);
            this.panelTop.TabIndex = 0;
            this.panelTop.Text = null;
            this.panelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(10, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "系統等級規則表";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lblNotice2);
            this.panelRight.Controls.Add(this.lblNotice1);
            this.panelRight.Controls.Add(this.btnDelete);
            this.panelRight.Controls.Add(this.btnSave);
            this.panelRight.Controls.Add(this.btnAddNew);
            this.panelRight.Controls.Add(this.txtUpgradeCost);
            this.panelRight.Controls.Add(this.lblUpgradeCost);
            this.panelRight.Controls.Add(this.txtMultiplier);
            this.panelRight.Controls.Add(this.lblMultiplier);
            this.panelRight.Controls.Add(this.txtDiscount);
            this.panelRight.Controls.Add(this.lblDiscount);
            this.panelRight.Controls.Add(this.txtLevelName);
            this.panelRight.Controls.Add(this.lblLevelName);
            this.panelRight.Controls.Add(this.lblEditTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelRight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelRight.Location = new System.Drawing.Point(910, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(20);
            this.panelRight.Size = new System.Drawing.Size(760, 1020);
            this.panelRight.TabIndex = 1;
            this.panelRight.Text = null;
            this.panelRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotice2
            // 
            this.lblNotice2.AutoSize = true;
            this.lblNotice2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice2.ForeColor = System.Drawing.Color.Gray;
            this.lblNotice2.Location = new System.Drawing.Point(455, 247);
            this.lblNotice2.Name = "lblNotice2";
            this.lblNotice2.Size = new System.Drawing.Size(112, 22);
            this.lblNotice2.TabIndex = 17;
            this.lblNotice2.Text = "0=不累積點數";
            // 
            // lblNotice1
            // 
            this.lblNotice1.AutoSize = true;
            this.lblNotice1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice1.ForeColor = System.Drawing.Color.Gray;
            this.lblNotice1.Location = new System.Drawing.Point(455, 177);
            this.lblNotice1.Name = "lblNotice1";
            this.lblNotice1.Size = new System.Drawing.Size(176, 22);
            this.lblNotice1.TabIndex = 16;
            this.lblNotice1.Text = "( 1.00不折, 0.90九折 )";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnDelete.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnDelete.Location = new System.Drawing.Point(486, 417);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelete.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Size = new System.Drawing.Size(110, 45);
            this.btnDelete.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "刪除等級";
            this.btnDelete.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(291, 417);
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
            this.btnAddNew.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(130, 417);
            this.btnAddNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 45);
            this.btnAddNew.Style = Sunny.UI.UIStyle.Custom;
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.Text = "+ 新增";
            this.btnAddNew.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtUpgradeCost
            // 
            this.txtUpgradeCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpgradeCost.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtUpgradeCost.Location = new System.Drawing.Point(130, 310);
            this.txtUpgradeCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpgradeCost.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUpgradeCost.Name = "txtUpgradeCost";
            this.txtUpgradeCost.Padding = new System.Windows.Forms.Padding(5);
            this.txtUpgradeCost.ShowText = false;
            this.txtUpgradeCost.Size = new System.Drawing.Size(318, 35);
            this.txtUpgradeCost.TabIndex = 8;
            this.txtUpgradeCost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUpgradeCost.Watermark = "";
            // 
            // lblUpgradeCost
            // 
            this.lblUpgradeCost.AutoSize = true;
            this.lblUpgradeCost.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpgradeCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblUpgradeCost.Location = new System.Drawing.Point(25, 317);
            this.lblUpgradeCost.Name = "lblUpgradeCost";
            this.lblUpgradeCost.Size = new System.Drawing.Size(90, 22);
            this.lblUpgradeCost.TabIndex = 7;
            this.lblUpgradeCost.Text = "升級扣點：";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMultiplier.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtMultiplier.Location = new System.Drawing.Point(130, 240);
            this.txtMultiplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMultiplier.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Padding = new System.Windows.Forms.Padding(5);
            this.txtMultiplier.ShowText = false;
            this.txtMultiplier.Size = new System.Drawing.Size(318, 35);
            this.txtMultiplier.TabIndex = 6;
            this.txtMultiplier.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMultiplier.Watermark = "";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblMultiplier.Location = new System.Drawing.Point(25, 247);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(90, 22);
            this.lblMultiplier.TabIndex = 5;
            this.lblMultiplier.Text = "點數倍率：";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtDiscount.Location = new System.Drawing.Point(130, 170);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Padding = new System.Windows.Forms.Padding(5);
            this.txtDiscount.ShowText = false;
            this.txtDiscount.Size = new System.Drawing.Size(318, 35);
            this.txtDiscount.TabIndex = 4;
            this.txtDiscount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDiscount.Watermark = "";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDiscount.Location = new System.Drawing.Point(25, 177);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(90, 22);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "結帳折扣：";
            // 
            // txtLevelName
            // 
            this.txtLevelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLevelName.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtLevelName.Location = new System.Drawing.Point(130, 100);
            this.txtLevelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLevelName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.Padding = new System.Windows.Forms.Padding(5);
            this.txtLevelName.ShowText = false;
            this.txtLevelName.Size = new System.Drawing.Size(466, 35);
            this.txtLevelName.TabIndex = 2;
            this.txtLevelName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLevelName.Watermark = "";
            // 
            // lblLevelName
            // 
            this.lblLevelName.AutoSize = true;
            this.lblLevelName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelName.ForeColor = System.Drawing.Color.Red;
            this.lblLevelName.Location = new System.Drawing.Point(25, 107);
            this.lblLevelName.Name = "lblLevelName";
            this.lblLevelName.Size = new System.Drawing.Size(98, 22);
            this.lblLevelName.TabIndex = 1;
            this.lblLevelName.Text = "等級名稱*：";
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.lblEditTitle.Location = new System.Drawing.Point(25, 30);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(571, 40);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "新增會員等級";
            this.lblEditTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colLevelID
            // 
            this.colLevelID.HeaderText = "ID";
            this.colLevelID.Name = "colLevelID";
            this.colLevelID.ReadOnly = true;
            this.colLevelID.Visible = false;
            // 
            // colLevelName
            // 
            this.colLevelName.HeaderText = "等級名稱";
            this.colLevelName.Name = "colLevelName";
            this.colLevelName.ReadOnly = true;
            this.colLevelName.Width = 300;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "結帳折扣";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // 
            // colMultiplier
            // 
            this.colMultiplier.HeaderText = "點數倍率";
            this.colMultiplier.Name = "colMultiplier";
            this.colMultiplier.ReadOnly = true;
            // 
            // colUpgradeCost
            // 
            this.colUpgradeCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUpgradeCost.HeaderText = "升級扣點";
            this.colUpgradeCost.Name = "colUpgradeCost";
            this.colUpgradeCost.ReadOnly = true;
            // 
            // UC_MemberLevelManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "UC_MemberLevelManager";
            this.Size = new System.Drawing.Size(1670, 1020);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLevels)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelLeft;
        private Sunny.UI.UIDataGridView dgvLevels;
        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIPanel panelRight;
        private Sunny.UI.UILabel lblEditTitle;
        private Sunny.UI.UITextBox txtLevelName;
        private Sunny.UI.UILabel lblLevelName;
        private Sunny.UI.UITextBox txtDiscount;
        private Sunny.UI.UILabel lblDiscount;
        private Sunny.UI.UITextBox txtMultiplier;
        private Sunny.UI.UILabel lblMultiplier;
        private Sunny.UI.UITextBox txtUpgradeCost;
        private Sunny.UI.UILabel lblUpgradeCost;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnAddNew;
        private Sunny.UI.UILabel lblNotice1;
        private Sunny.UI.UILabel lblNotice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMultiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpgradeCost;
    }
}