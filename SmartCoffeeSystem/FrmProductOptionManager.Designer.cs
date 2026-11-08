namespace SmartCoffeeSystem
{
    partial class FrmProductOptionManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductOptionManager));
            this.panelLeft = new Sunny.UI.UIPanel();
            this.dgvGroups = new Sunny.UI.UIDataGridView();
            this.colGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGroupTop = new Sunny.UI.UIPanel();
            this.btnDelGroup = new Sunny.UI.UIButton();
            this.btnAddGroup = new Sunny.UI.UIButton();
            this.lblGroupTitle = new Sunny.UI.UILabel();
            this.panelRight = new Sunny.UI.UIPanel();
            this.dgvItems = new Sunny.UI.UIDataGridView();
            this.colItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExtraPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelItemTop = new Sunny.UI.UIPanel();
            this.btnDelItem = new Sunny.UI.UIButton();
            this.btnAddItem = new Sunny.UI.UIButton();
            this.lblItemTitle = new Sunny.UI.UILabel();
            this.lblProductName = new Sunny.UI.UILabel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.panelGroupTop.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panelItemTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dgvGroups);
            this.panelLeft.Controls.Add(this.panelGroupTop);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.FillColor = System.Drawing.Color.White;
            this.panelLeft.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Size = new System.Drawing.Size(400, 530);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Text = null;
            this.panelLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvGroups
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvGroups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroups.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroups.ColumnHeadersHeight = 32;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroupId,
            this.colGroupName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGroups.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.EnableHeadersVisualStyles = false;
            this.dgvGroups.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvGroups.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvGroups.Location = new System.Drawing.Point(10, 60);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroups.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvGroups.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGroups.RowTemplate.Height = 29;
            this.dgvGroups.SelectedIndex = -1;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(380, 460);
            this.dgvGroups.TabIndex = 1;
            // 
            // colGroupId
            // 
            this.colGroupId.HeaderText = "ID";
            this.colGroupId.Name = "colGroupId";
            this.colGroupId.ReadOnly = true;
            this.colGroupId.Visible = false;
            // 
            // colGroupName
            // 
            this.colGroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroupName.HeaderText = "群組名稱(如:冰塊)";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.ReadOnly = true;
            // 
            // panelGroupTop
            // 
            this.panelGroupTop.Controls.Add(this.btnDelGroup);
            this.panelGroupTop.Controls.Add(this.btnAddGroup);
            this.panelGroupTop.Controls.Add(this.lblGroupTitle);
            this.panelGroupTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGroupTop.FillColor = System.Drawing.Color.White;
            this.panelGroupTop.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelGroupTop.Location = new System.Drawing.Point(10, 10);
            this.panelGroupTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGroupTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelGroupTop.Name = "panelGroupTop";
            this.panelGroupTop.Size = new System.Drawing.Size(380, 50);
            this.panelGroupTop.TabIndex = 0;
            this.panelGroupTop.Text = null;
            this.panelGroupTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelGroup
            // 
            this.btnDelGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelGroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelGroup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelGroup.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelGroup.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelGroup.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelGroup.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDelGroup.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnDelGroup.Location = new System.Drawing.Point(296, 8);
            this.btnDelGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelGroup.Name = "btnDelGroup";
            this.btnDelGroup.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelGroup.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelGroup.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelGroup.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelGroup.Size = new System.Drawing.Size(80, 32);
            this.btnDelGroup.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelGroup.TabIndex = 2;
            this.btnDelGroup.Text = "刪除";
            this.btnDelGroup.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDelGroup.Click += new System.EventHandler(this.btnDelGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnAddGroup.Location = new System.Drawing.Point(210, 8);
            this.btnAddGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(80, 32);
            this.btnAddGroup.TabIndex = 1;
            this.btnAddGroup.Text = "新增";
            this.btnAddGroup.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // lblGroupTitle
            // 
            this.lblGroupTitle.AutoSize = true;
            this.lblGroupTitle.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGroupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGroupTitle.Location = new System.Drawing.Point(3, 12);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Size = new System.Drawing.Size(86, 24);
            this.lblGroupTitle.TabIndex = 0;
            this.lblGroupTitle.Text = "選項群組";
            this.lblGroupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgvItems);
            this.panelRight.Controls.Add(this.panelItemTop);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.FillColor = System.Drawing.Color.White;
            this.panelRight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelRight.Location = new System.Drawing.Point(400, 70);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(500, 530);
            this.panelRight.TabIndex = 1;
            this.panelRight.Text = null;
            this.panelRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvItems
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItems.ColumnHeadersHeight = 32;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemId,
            this.colItemName,
            this.colExtraPrice,
            this.colItemSort});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvItems.Location = new System.Drawing.Point(10, 60);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItems.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvItems.RowTemplate.Height = 29;
            this.dgvItems.SelectedIndex = -1;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(480, 460);
            this.dgvItems.TabIndex = 2;
            // 
            // colItemId
            // 
            this.colItemId.HeaderText = "ID";
            this.colItemId.Name = "colItemId";
            this.colItemId.ReadOnly = true;
            this.colItemId.Visible = false;
            // 
            // colItemName
            // 
            this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemName.HeaderText = "明細項目(如:少冰)";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colExtraPrice
            // 
            this.colExtraPrice.HeaderText = "加價金額";
            this.colExtraPrice.Name = "colExtraPrice";
            this.colExtraPrice.ReadOnly = true;
            this.colExtraPrice.Width = 120;
            // 
            // colItemSort
            // 
            this.colItemSort.HeaderText = "排序";
            this.colItemSort.Name = "colItemSort";
            this.colItemSort.ReadOnly = true;
            this.colItemSort.Width = 80;
            // 
            // panelItemTop
            // 
            this.panelItemTop.Controls.Add(this.btnDelItem);
            this.panelItemTop.Controls.Add(this.btnAddItem);
            this.panelItemTop.Controls.Add(this.lblItemTitle);
            this.panelItemTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemTop.FillColor = System.Drawing.Color.White;
            this.panelItemTop.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelItemTop.Location = new System.Drawing.Point(10, 10);
            this.panelItemTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelItemTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelItemTop.Name = "panelItemTop";
            this.panelItemTop.Size = new System.Drawing.Size(480, 50);
            this.panelItemTop.TabIndex = 1;
            this.panelItemTop.Text = null;
            this.panelItemTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelItem
            // 
            this.btnDelItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelItem.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelItem.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelItem.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelItem.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDelItem.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnDelItem.Location = new System.Drawing.Point(394, 8);
            this.btnDelItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelItem.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnDelItem.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelItem.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelItem.Size = new System.Drawing.Size(80, 32);
            this.btnDelItem.Style = Sunny.UI.UIStyle.Custom;
            this.btnDelItem.TabIndex = 3;
            this.btnDelItem.Text = "刪除";
            this.btnDelItem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnAddItem.Location = new System.Drawing.Point(308, 8);
            this.btnAddItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 32);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "新增";
            this.btnAddItem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblItemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblItemTitle.Location = new System.Drawing.Point(3, 12);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(257, 24);
            this.lblItemTitle.TabIndex = 0;
            this.lblItemTitle.Text = "明細設定 (請先選擇左側群組)";
            this.lblItemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.lblProductName.Location = new System.Drawing.Point(0, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(900, 35);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "  目前設定商品：載入中...";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmProductOptionManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.lblProductName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductOptionManager";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "商品選項設定管理";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 900, 600);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.panelGroupTop.ResumeLayout(false);
            this.panelGroupTop.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panelItemTop.ResumeLayout(false);
            this.panelItemTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelLeft;
        private Sunny.UI.UIPanel panelGroupTop;
        private Sunny.UI.UIDataGridView dgvGroups;
        private Sunny.UI.UILabel lblGroupTitle;
        private Sunny.UI.UIButton btnAddGroup;
        private Sunny.UI.UIButton btnDelGroup;
        private Sunny.UI.UIPanel panelRight;
        private Sunny.UI.UIDataGridView dgvItems;
        private Sunny.UI.UIPanel panelItemTop;
        private Sunny.UI.UIButton btnDelItem;
        private Sunny.UI.UIButton btnAddItem;
        private Sunny.UI.UILabel lblItemTitle;
        private Sunny.UI.UILabel lblProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
    }
}