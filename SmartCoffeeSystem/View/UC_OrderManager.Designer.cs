namespace SmartCoffeeSystem.View
{
    partial class UC_OrderManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new Sunny.UI.UIPanel();
            this.btnRestoreOrder = new Sunny.UI.UIButton();
            this.btnCancelOrder = new Sunny.UI.UIButton();
            this.btnSearch = new Sunny.UI.UIButton();
            this.cboStatus = new Sunny.UI.UIComboBox();
            this.lblStatus = new Sunny.UI.UILabel();
            this.dpEnd = new Sunny.UI.UIDatePicker();
            this.lblTo = new Sunny.UI.UILabel();
            this.dpStart = new Sunny.UI.UIDatePicker();
            this.lblDate = new Sunny.UI.UILabel();
            this.panelLeft = new Sunny.UI.UIPanel();
            this.dgvOrders = new Sunny.UI.UIDataGridView();
            this.lblOrderTitle = new Sunny.UI.UILabel();
            this.panelRight = new Sunny.UI.UIPanel();
            this.dgvDetails = new Sunny.UI.UIDataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDetailTitle = new Sunny.UI.UILabel();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMemberType = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cboMemberType);
            this.panelTop.Controls.Add(this.btnRestoreOrder);
            this.panelTop.Controls.Add(this.btnCancelOrder);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.cboStatus);
            this.panelTop.Controls.Add(this.uiLabel1);
            this.panelTop.Controls.Add(this.lblStatus);
            this.panelTop.Controls.Add(this.dpEnd);
            this.panelTop.Controls.Add(this.lblTo);
            this.panelTop.Controls.Add(this.dpStart);
            this.panelTop.Controls.Add(this.lblDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.White;
            this.panelTop.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1670, 70);
            this.panelTop.TabIndex = 0;
            this.panelTop.Text = null;
            this.panelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestoreOrder
            // 
            this.btnRestoreOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestoreOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnRestoreOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnRestoreOrder.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnRestoreOrder.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnRestoreOrder.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnRestoreOrder.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestoreOrder.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.btnRestoreOrder.Location = new System.Drawing.Point(1434, 19);
            this.btnRestoreOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRestoreOrder.Name = "btnRestoreOrder";
            this.btnRestoreOrder.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnRestoreOrder.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnRestoreOrder.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnRestoreOrder.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnRestoreOrder.Size = new System.Drawing.Size(100, 35);
            this.btnRestoreOrder.Style = Sunny.UI.UIStyle.Custom;
            this.btnRestoreOrder.TabIndex = 8;
            this.btnRestoreOrder.Text = "恢復作廢";
            this.btnRestoreOrder.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreOrder.Click += new System.EventHandler(this.btnRestoreOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancelOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancelOrder.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnCancelOrder.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelOrder.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelOrder.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCancelOrder.Location = new System.Drawing.Point(1540, 18);
            this.btnCancelOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancelOrder.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnCancelOrder.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelOrder.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelOrder.Size = new System.Drawing.Size(100, 36);
            this.btnCancelOrder.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancelOrder.TabIndex = 7;
            this.btnCancelOrder.Text = "作廢訂單";
            this.btnCancelOrder.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1028, 18);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查詢";
            this.btnSearch.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DataSource = null;
            this.cboStatus.FillColor = System.Drawing.Color.White;
            this.cboStatus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cboStatus.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboStatus.Location = new System.Drawing.Point(570, 20);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboStatus.Size = new System.Drawing.Size(130, 32);
            this.cboStatus.SymbolSize = 24;
            this.cboStatus.TabIndex = 5;
            this.cboStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboStatus.Watermark = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblStatus.Location = new System.Drawing.Point(480, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(90, 21);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "訂單狀態：";
            // 
            // dpEnd
            // 
            this.dpEnd.DateCultureInfo = new System.Globalization.CultureInfo("");
            this.dpEnd.FillColor = System.Drawing.Color.White;
            this.dpEnd.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.dpEnd.Location = new System.Drawing.Point(300, 20);
            this.dpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEnd.MaxLength = 10;
            this.dpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEnd.Size = new System.Drawing.Size(150, 32);
            this.dpEnd.SymbolDropDown = 61555;
            this.dpEnd.SymbolNormal = 61555;
            this.dpEnd.SymbolSize = 24;
            this.dpEnd.TabIndex = 3;
            this.dpEnd.Text = "2026-07-30";
            this.dpEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEnd.Value = new System.DateTime(2026, 7, 30, 0, 0, 0, 0);
            this.dpEnd.Watermark = "";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTo.Location = new System.Drawing.Point(270, 25);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "~";
            // 
            // dpStart
            // 
            this.dpStart.DateCultureInfo = new System.Globalization.CultureInfo("");
            this.dpStart.FillColor = System.Drawing.Color.White;
            this.dpStart.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.dpStart.Location = new System.Drawing.Point(110, 20);
            this.dpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpStart.MaxLength = 10;
            this.dpStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpStart.Size = new System.Drawing.Size(150, 32);
            this.dpStart.SymbolDropDown = 61555;
            this.dpStart.SymbolNormal = 61555;
            this.dpStart.SymbolSize = 24;
            this.dpStart.TabIndex = 1;
            this.dpStart.Text = "2026-07-30";
            this.dpStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpStart.Value = new System.DateTime(2026, 7, 30, 0, 0, 0, 0);
            this.dpStart.Watermark = "";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDate.Location = new System.Drawing.Point(20, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 21);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "日期區間：";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dgvOrders);
            this.panelLeft.Controls.Add(this.lblOrderTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.FillColor = System.Drawing.Color.White;
            this.panelLeft.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(15);
            this.panelLeft.Size = new System.Drawing.Size(734, 950);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Text = null;
            this.panelLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrders
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvOrders.ColumnHeadersHeight = 32;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colMemberName,
            this.colOrderDate,
            this.colTotalAmount,
            this.colStatus});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvOrders.Location = new System.Drawing.Point(15, 55);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvOrders.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvOrders.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvOrders.RowTemplate.Height = 29;
            this.dgvOrders.SelectedIndex = -1;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(704, 880);
            this.dgvOrders.TabIndex = 1;
            // 
            // lblOrderTitle
            // 
            this.lblOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblOrderTitle.Location = new System.Drawing.Point(15, 15);
            this.lblOrderTitle.Name = "lblOrderTitle";
            this.lblOrderTitle.Size = new System.Drawing.Size(704, 40);
            this.lblOrderTitle.TabIndex = 0;
            this.lblOrderTitle.Text = "歷史訂單總表";
            this.lblOrderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.dgvDetails);
            this.panelRight.Controls.Add(this.lblDetailTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.FillColor = System.Drawing.Color.White;
            this.panelRight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelRight.Location = new System.Drawing.Point(734, 70);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(15);
            this.panelRight.Size = new System.Drawing.Size(936, 950);
            this.panelRight.TabIndex = 2;
            this.panelRight.Text = null;
            this.panelRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetails
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDetails.ColumnHeadersHeight = 32;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colOptions,
            this.colUnitPrice,
            this.colQty,
            this.colSubTotal});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.EnableHeadersVisualStyles = false;
            this.dgvDetails.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvDetails.Location = new System.Drawing.Point(15, 55);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微軟正黑體", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDetails.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvDetails.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDetails.RowTemplate.Height = 29;
            this.dgvDetails.SelectedIndex = -1;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(906, 880);
            this.dgvDetails.TabIndex = 2;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "商品名稱";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 300;
            // 
            // colOptions
            // 
            this.colOptions.HeaderText = "選項";
            this.colOptions.Name = "colOptions";
            this.colOptions.ReadOnly = true;
            this.colOptions.Width = 305;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "單價";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 160;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "數量";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 160;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "小計";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 160;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetailTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblDetailTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(906, 40);
            this.lblDetailTitle.TabIndex = 1;
            this.lblDetailTitle.Text = "訂單明細";
            this.lblDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colOrderID
            // 
            this.colOrderID.HeaderText = "單號";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            this.colOrderID.Width = 80;
            // 
            // colMemberName
            // 
            this.colMemberName.HeaderText = "購買人";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            this.colMemberName.Width = 200;
            // 
            // colOrderDate
            // 
            this.colOrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderDate.HeaderText = "下單時間";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.HeaderText = "總金額";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "狀態";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // cboMemberType
            // 
            this.cboMemberType.DataSource = null;
            this.cboMemberType.FillColor = System.Drawing.Color.White;
            this.cboMemberType.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.cboMemberType.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboMemberType.Location = new System.Drawing.Point(795, 18);
            this.cboMemberType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMemberType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboMemberType.Name = "cboMemberType";
            this.cboMemberType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboMemberType.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.cboMemberType.Size = new System.Drawing.Size(210, 32);
            this.cboMemberType.Style = Sunny.UI.UIStyle.Custom;
            this.cboMemberType.SymbolSize = 24;
            this.cboMemberType.TabIndex = 9;
            this.cboMemberType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboMemberType.Watermark = "請篩選會員及非會員...";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(707, 24);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(90, 21);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "會員篩選：";
            // 
            // UC_OrderManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_OrderManager";
            this.Size = new System.Drawing.Size(1670, 1020);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UIDatePicker dpStart;
        private Sunny.UI.UILabel lblDate;
        private Sunny.UI.UILabel lblTo;
        private Sunny.UI.UIDatePicker dpEnd;
        private Sunny.UI.UILabel lblStatus;
        private Sunny.UI.UIComboBox cboStatus;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UIButton btnCancelOrder;
        private Sunny.UI.UIPanel panelLeft;
        private Sunny.UI.UIDataGridView dgvOrders;
        private Sunny.UI.UILabel lblOrderTitle;
        private Sunny.UI.UIPanel panelRight;
        private Sunny.UI.UIDataGridView dgvDetails;
        private Sunny.UI.UILabel lblDetailTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private Sunny.UI.UIButton btnRestoreOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private Sunny.UI.UIComboBox cboMemberType;
        private Sunny.UI.UILabel uiLabel1;
    }
}