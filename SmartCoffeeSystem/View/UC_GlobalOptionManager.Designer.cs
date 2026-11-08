namespace SmartCoffeeSystem.View
{
    partial class UC_GlobalOptionManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new Sunny.UI.UIPanel();
            this.dgvGroups = new Sunny.UI.UIDataGridView();
            this.colGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGroupTop = new Sunny.UI.UIPanel();
            this.btnGroupUp = new Sunny.UI.UIButton();
            this.btnGroupDown = new Sunny.UI.UIButton();
            this.btnEditGroup = new Sunny.UI.UIButton();
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
            this.btnItemUp = new Sunny.UI.UIButton();
            this.btnItemDown = new Sunny.UI.UIButton();
            this.btnEditItem = new Sunny.UI.UIButton();
            this.btnDelItem = new Sunny.UI.UIButton();
            this.btnAddItem = new Sunny.UI.UIButton();
            this.lblItemTitle = new Sunny.UI.UILabel();
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
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panelLeft.Size = new System.Drawing.Size(450, 650);
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
            this.colGroupName,
            this.colGroupSort});
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
            this.dgvGroups.Location = new System.Drawing.Point(15, 65);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.RowTemplate.Height = 29;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(420, 570);
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
            this.colGroupName.HeaderText = "群組名稱(全域)";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.ReadOnly = true;
            // 
            // colGroupSort
            // 
            this.colGroupSort.HeaderText = "排序";
            this.colGroupSort.Name = "colGroupSort";
            this.colGroupSort.ReadOnly = true;
            this.colGroupSort.Width = 80;
            // 
            // panelGroupTop
            // 
            this.panelGroupTop.Controls.Add(this.btnGroupUp);
            this.panelGroupTop.Controls.Add(this.btnGroupDown);
            this.panelGroupTop.Controls.Add(this.btnAddGroup);
            this.panelGroupTop.Controls.Add(this.btnEditGroup);
            this.panelGroupTop.Controls.Add(this.btnDelGroup);
            this.panelGroupTop.Controls.Add(this.lblGroupTitle);
            this.panelGroupTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGroupTop.FillColor = System.Drawing.Color.White;
            this.panelGroupTop.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelGroupTop.Location = new System.Drawing.Point(15, 15);
            this.panelGroupTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGroupTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelGroupTop.Name = "panelGroupTop";
            this.panelGroupTop.Size = new System.Drawing.Size(420, 50);
            this.panelGroupTop.TabIndex = 0;
            this.panelGroupTop.Text = null;
            this.panelGroupTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGroupUp
            // 
            this.btnGroupUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroupUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnGroupUp.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnGroupUp.Location = new System.Drawing.Point(145, 8);
            this.btnGroupUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGroupUp.Name = "btnGroupUp";
            this.btnGroupUp.Radius = 5;
            this.btnGroupUp.Size = new System.Drawing.Size(35, 32);
            this.btnGroupUp.Style = Sunny.UI.UIStyle.Custom;
            this.btnGroupUp.TabIndex = 5;
            this.btnGroupUp.Text = "▲";
            this.btnGroupUp.Click += new System.EventHandler(this.btnGroupUp_Click);
            // 
            // btnGroupDown
            // 
            this.btnGroupDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroupDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroupDown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnGroupDown.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnGroupDown.Location = new System.Drawing.Point(185, 8);
            this.btnGroupDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGroupDown.Name = "btnGroupDown";
            this.btnGroupDown.Radius = 5;
            this.btnGroupDown.Size = new System.Drawing.Size(35, 32);
            this.btnGroupDown.Style = Sunny.UI.UIStyle.Custom;
            this.btnGroupDown.TabIndex = 4;
            this.btnGroupDown.Text = "▼";
            this.btnGroupDown.Click += new System.EventHandler(this.btnGroupDown_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnAddGroup.Location = new System.Drawing.Point(230, 8);
            this.btnAddGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Radius = 5;
            this.btnAddGroup.Size = new System.Drawing.Size(55, 32);
            this.btnAddGroup.TabIndex = 1;
            this.btnAddGroup.Text = "新增";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnEditGroup.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnEditGroup.Location = new System.Drawing.Point(292, 8);
            this.btnEditGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Radius = 5;
            this.btnEditGroup.Size = new System.Drawing.Size(55, 32);
            this.btnEditGroup.Style = Sunny.UI.UIStyle.Custom;
            this.btnEditGroup.TabIndex = 3;
            this.btnEditGroup.Text = "修改";
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // btnDelGroup
            // 
            this.btnDelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelGroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelGroup.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDelGroup.Location = new System.Drawing.Point(354, 8);
            this.btnDelGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelGroup.Name = "btnDelGroup";
            this.btnDelGroup.Radius = 5;
            this.btnDelGroup.Size = new System.Drawing.Size(55, 32);
            this.btnDelGroup.Style = Sunny.UI.UIStyle.Red;
            this.btnDelGroup.TabIndex = 2;
            this.btnDelGroup.Text = "刪除";
            this.btnDelGroup.Click += new System.EventHandler(this.btnDelGroup_Click);
            // 
            // lblGroupTitle
            // 
            this.lblGroupTitle.AutoSize = true;
            this.lblGroupTitle.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.lblGroupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblGroupTitle.Location = new System.Drawing.Point(3, 12);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Size = new System.Drawing.Size(132, 25);
            this.lblGroupTitle.TabIndex = 0;
            this.lblGroupTitle.Text = "選項群組總庫";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgvItems);
            this.panelRight.Controls.Add(this.panelItemTop);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.FillColor = System.Drawing.Color.White;
            this.panelRight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelRight.Location = new System.Drawing.Point(450, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelRight.Size = new System.Drawing.Size(600, 650);
            this.panelRight.TabIndex = 1;
            this.panelRight.Text = null;
            this.panelRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvItems
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItems.ColumnHeadersHeight = 32;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemId,
            this.colItemName,
            this.colExtraPrice,
            this.colItemSort});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvItems.Location = new System.Drawing.Point(15, 65);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 29;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(570, 570);
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
            this.colItemName.HeaderText = "選項名稱";
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
            this.panelItemTop.Controls.Add(this.btnItemUp);
            this.panelItemTop.Controls.Add(this.btnItemDown);
            this.panelItemTop.Controls.Add(this.btnEditItem);
            this.panelItemTop.Controls.Add(this.btnDelItem);
            this.panelItemTop.Controls.Add(this.btnAddItem);
            this.panelItemTop.Controls.Add(this.lblItemTitle);
            this.panelItemTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemTop.FillColor = System.Drawing.Color.White;
            this.panelItemTop.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelItemTop.Location = new System.Drawing.Point(15, 15);
            this.panelItemTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelItemTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelItemTop.Name = "panelItemTop";
            this.panelItemTop.Size = new System.Drawing.Size(570, 50);
            this.panelItemTop.TabIndex = 1;
            this.panelItemTop.Text = null;
            this.panelItemTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnItemUp
            // 
            this.btnItemUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnItemUp.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnItemUp.Location = new System.Drawing.Point(286, 8);
            this.btnItemUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnItemUp.Name = "btnItemUp";
            this.btnItemUp.Radius = 5;
            this.btnItemUp.Size = new System.Drawing.Size(35, 32);
            this.btnItemUp.Style = Sunny.UI.UIStyle.Custom;
            this.btnItemUp.TabIndex = 6;
            this.btnItemUp.Text = "▲";
            this.btnItemUp.Click += new System.EventHandler(this.btnItemUp_Click);
            // 
            // btnItemDown
            // 
            this.btnItemDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemDown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnItemDown.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnItemDown.Location = new System.Drawing.Point(327, 8);
            this.btnItemDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnItemDown.Name = "btnItemDown";
            this.btnItemDown.Radius = 5;
            this.btnItemDown.Size = new System.Drawing.Size(35, 32);
            this.btnItemDown.Style = Sunny.UI.UIStyle.Custom;
            this.btnItemDown.TabIndex = 5;
            this.btnItemDown.Text = "▼";
            this.btnItemDown.Click += new System.EventHandler(this.btnItemDown_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.btnEditItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnEditItem.Location = new System.Drawing.Point(433, 8);
            this.btnEditItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Radius = 5;
            this.btnEditItem.Size = new System.Drawing.Size(55, 32);
            this.btnEditItem.Style = Sunny.UI.UIStyle.Custom;
            this.btnEditItem.TabIndex = 4;
            this.btnEditItem.Text = "修改";
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDelItem
            // 
            this.btnDelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnDelItem.Location = new System.Drawing.Point(495, 8);
            this.btnDelItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Radius = 5;
            this.btnDelItem.Size = new System.Drawing.Size(55, 32);
            this.btnDelItem.Style = Sunny.UI.UIStyle.Red;
            this.btnDelItem.TabIndex = 3;
            this.btnDelItem.Text = "刪除";
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnAddItem.Location = new System.Drawing.Point(371, 8);
            this.btnAddItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Radius = 5;
            this.btnAddItem.Size = new System.Drawing.Size(55, 32);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "新增";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblItemTitle
            // 
            this.lblItemTitle.AutoSize = true;
            this.lblItemTitle.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.lblItemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblItemTitle.Location = new System.Drawing.Point(3, 12);
            this.lblItemTitle.Name = "lblItemTitle";
            this.lblItemTitle.Size = new System.Drawing.Size(263, 25);
            this.lblItemTitle.TabIndex = 0;
            this.lblItemTitle.Text = "群細設定 (請先選擇左側群組)";
            // 
            // UC_GlobalOptionManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "UC_GlobalOptionManager";
            this.Size = new System.Drawing.Size(1050, 650);
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
        private Sunny.UI.UIDataGridView dgvGroups;
        private Sunny.UI.UIPanel panelGroupTop;
        private Sunny.UI.UIPanel panelRight;
        private Sunny.UI.UIPanel panelItemTop;
        private Sunny.UI.UILabel lblGroupTitle;
        private Sunny.UI.UIButton btnEditGroup;
        private Sunny.UI.UIButton btnDelGroup;
        private Sunny.UI.UIButton btnAddGroup;
        private Sunny.UI.UIButton btnGroupUp;
        private Sunny.UI.UIButton btnGroupDown;
        private Sunny.UI.UIDataGridView dgvItems;
        private Sunny.UI.UILabel lblItemTitle;
        private Sunny.UI.UIButton btnEditItem;
        private Sunny.UI.UIButton btnDelItem;
        private Sunny.UI.UIButton btnAddItem;
        private Sunny.UI.UIButton btnItemUp;
        private Sunny.UI.UIButton btnItemDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExtraPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemSort;
    }
}