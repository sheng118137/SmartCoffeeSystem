namespace SmartCoffeeSystem
{
    partial class UC_LoginLogManager
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpStart = new Sunny.UI.UIDatePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEnd = new Sunny.UI.UIDatePicker();
            this.cboStatus = new Sunny.UI.UIComboBox();
            this.txtSearching = new System.Windows.Forms.TextBox();
            this.btnSearch = new Sunny.UI.UIButton();
            this.btnRefresh = new Sunny.UI.UIButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnFirstPage = new Sunny.UI.UIButton();
            this.btnPrevPage = new Sunny.UI.UIButton();
            this.lblPageInfo = new System.Windows.Forms.Label();
            this.btnNextPage = new Sunny.UI.UIButton();
            this.btnLastPage = new Sunny.UI.UIButton();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.cboPageSize = new Sunny.UI.UIComboBox();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.colLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttemptTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.dtpStart);
            this.panelTop.Controls.Add(this.lblTo);
            this.panelTop.Controls.Add(this.dtpEnd);
            this.panelTop.Controls.Add(this.cboStatus);
            this.panelTop.Controls.Add(this.txtSearching);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1670, 85);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "系統Log紀錄";
            // 
            // dtpStart
            // 
            this.dtpStart.DateCultureInfo = new System.Globalization.CultureInfo("");
            this.dtpStart.FillColor = System.Drawing.Color.White;
            this.dtpStart.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.dtpStart.Location = new System.Drawing.Point(400, 26);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpStart.MaxLength = 10;
            this.dtpStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpStart.Size = new System.Drawing.Size(150, 32);
            this.dtpStart.SymbolDropDown = 61555;
            this.dtpStart.SymbolNormal = 61555;
            this.dtpStart.SymbolSize = 24;
            this.dtpStart.TabIndex = 1;
            this.dtpStart.Text = "2026-07-30";
            this.dtpStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpStart.Value = new System.DateTime(2026, 7, 30, 5, 24, 6, 76);
            this.dtpStart.Watermark = "";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.lblTo.ForeColor = System.Drawing.Color.Gray;
            this.lblTo.Location = new System.Drawing.Point(558, 33);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 19);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "至";
            // 
            // dtpEnd
            // 
            this.dtpEnd.DateCultureInfo = new System.Globalization.CultureInfo("");
            this.dtpEnd.FillColor = System.Drawing.Color.White;
            this.dtpEnd.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.dtpEnd.Location = new System.Drawing.Point(590, 26);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEnd.MaxLength = 10;
            this.dtpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtpEnd.Size = new System.Drawing.Size(150, 32);
            this.dtpEnd.SymbolDropDown = 61555;
            this.dtpEnd.SymbolNormal = 61555;
            this.dtpEnd.SymbolSize = 24;
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.Text = "2026-07-30";
            this.dtpEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtpEnd.Value = new System.DateTime(2026, 7, 30, 5, 24, 6, 97);
            this.dtpEnd.Watermark = "";
            // 
            // cboStatus
            // 
            this.cboStatus.DataSource = null;
            this.cboStatus.FillColor = System.Drawing.Color.White;
            this.cboStatus.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.cboStatus.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboStatus.Location = new System.Drawing.Point(760, 26);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboStatus.Size = new System.Drawing.Size(120, 32);
            this.cboStatus.SymbolSize = 24;
            this.cboStatus.TabIndex = 4;
            this.cboStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboStatus.Watermark = "";
            // 
            // txtSearching
            // 
            this.txtSearching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearching.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.txtSearching.ForeColor = System.Drawing.Color.Gray;
            this.txtSearching.Location = new System.Drawing.Point(1090, 28);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.Size = new System.Drawing.Size(230, 27);
            this.txtSearching.TabIndex = 5;
            this.txtSearching.Text = "🔍 搜尋帳號或IP...";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.btnSearch.Location = new System.Drawing.Point(1335, 26);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查詢";
            this.btnSearch.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.btnRefresh.Location = new System.Drawing.Point(1445, 26);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 32);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "重置條件";
            this.btnRefresh.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnFirstPage);
            this.panelBottom.Controls.Add(this.btnPrevPage);
            this.panelBottom.Controls.Add(this.lblPageInfo);
            this.panelBottom.Controls.Add(this.btnNextPage);
            this.panelBottom.Controls.Add(this.btnLastPage);
            this.panelBottom.Controls.Add(this.lblPageSize);
            this.panelBottom.Controls.Add(this.cboPageSize);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 960);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1670, 60);
            this.panelBottom.TabIndex = 2;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnFirstPage.Location = new System.Drawing.Point(562, 15);
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
            this.btnPrevPage.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnPrevPage.Location = new System.Drawing.Point(628, 15);
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
            this.lblPageInfo.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblPageInfo.Location = new System.Drawing.Point(726, 20);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(219, 20);
            this.lblPageInfo.TabIndex = 2;
            this.lblPageInfo.Text = "第 1 頁 / 共 10 頁 ( 總計32筆 )";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnNextPage.Location = new System.Drawing.Point(949, 15);
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
            this.btnLastPage.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.btnLastPage.Location = new System.Drawing.Point(1052, 15);
            this.btnLastPage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(50, 30);
            this.btnLastPage.TabIndex = 4;
            this.btnLastPage.Text = ">|";
            this.btnLastPage.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.lblPageSize.ForeColor = System.Drawing.Color.Gray;
            this.lblPageSize.Location = new System.Drawing.Point(1480, 20);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(72, 19);
            this.lblPageSize.TabIndex = 5;
            this.lblPageSize.Text = "每頁筆數:";
            // 
            // cboPageSize
            // 
            this.cboPageSize.DataSource = null;
            this.cboPageSize.FillColor = System.Drawing.Color.White;
            this.cboPageSize.Font = new System.Drawing.Font("微軟正黑體", 10.5F);
            this.cboPageSize.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboPageSize.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboPageSize.Location = new System.Drawing.Point(1550, 15);
            this.cboPageSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPageSize.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboPageSize.Size = new System.Drawing.Size(80, 30);
            this.cboPageSize.SymbolSize = 24;
            this.cboPageSize.TabIndex = 6;
            this.cboPageSize.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboPageSize.Watermark = "";
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dgvLogs);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 85);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.panelGrid.Size = new System.Drawing.Size(1670, 875);
            this.panelGrid.TabIndex = 1;
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLogs.ColumnHeadersHeight = 40;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogID,
            this.colUsername,
            this.colAttemptTime,
            this.colIPAddress,
            this.colMachineName,
            this.colStatus});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微軟正黑體", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(30, 10);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.RowTemplate.Height = 35;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(1610, 855);
            this.dgvLogs.TabIndex = 0;
            // 
            // colLogID
            // 
            this.colLogID.DataPropertyName = "LogID";
            this.colLogID.HeaderText = "記錄編號";
            this.colLogID.Name = "colLogID";
            this.colLogID.ReadOnly = true;
            // 
            // colUsername
            // 
            this.colUsername.DataPropertyName = "Username";
            this.colUsername.HeaderText = "嘗試帳號";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colAttemptTime
            // 
            this.colAttemptTime.DataPropertyName = "AttemptTime";
            this.colAttemptTime.HeaderText = "嘗試時間";
            this.colAttemptTime.Name = "colAttemptTime";
            this.colAttemptTime.ReadOnly = true;
            // 
            // colIPAddress
            // 
            this.colIPAddress.DataPropertyName = "IPAddress";
            this.colIPAddress.HeaderText = "IP 位址";
            this.colIPAddress.Name = "colIPAddress";
            this.colIPAddress.ReadOnly = true;
            // 
            // colMachineName
            // 
            this.colMachineName.DataPropertyName = "MachineName";
            this.colMachineName.HeaderText = "電腦名稱";
            this.colMachineName.Name = "colMachineName";
            this.colMachineName.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "登入狀態";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // UC_LoginLogManager
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_LoginLogManager";
            this.Size = new System.Drawing.Size(1670, 1020);
            this.Load += new System.EventHandler(this.UC_LoginLogManager_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UIDatePicker dtpStart;
        private System.Windows.Forms.Label lblTo;
        private Sunny.UI.UIDatePicker dtpEnd;
        private Sunny.UI.UIComboBox cboStatus;
        private System.Windows.Forms.TextBox txtSearching;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UIButton btnRefresh;

        // 自訂分頁變數
        private System.Windows.Forms.Panel panelBottom;
        private Sunny.UI.UIButton btnFirstPage;
        private Sunny.UI.UIButton btnPrevPage;
        private System.Windows.Forms.Label lblPageInfo;
        private Sunny.UI.UIButton btnNextPage;
        private Sunny.UI.UIButton btnLastPage;
        private System.Windows.Forms.Label lblPageSize;
        private Sunny.UI.UIComboBox cboPageSize;
        //

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttemptTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
#endregion