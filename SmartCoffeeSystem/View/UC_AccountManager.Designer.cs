namespace SmartCoffeeSystem
{
    partial class UC_AccountManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanelTop = new Sunny.UI.UIPanel();
            this.txtSearching = new Sunny.UI.UITextBox();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.lblHint = new Sunny.UI.UILabel();
            this.btnCreateAccount = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dgvAccounts = new Sunny.UI.UIDataGridView();
            this.colEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFailedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsLocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanelTop
            // 
            this.uiPanelTop.Controls.Add(this.txtSearching);
            this.uiPanelTop.Controls.Add(this.btnEdit);
            this.uiPanelTop.Controls.Add(this.btnDelete);
            this.uiPanelTop.Controls.Add(this.lblHint);
            this.uiPanelTop.Controls.Add(this.btnCreateAccount);
            this.uiPanelTop.Controls.Add(this.uiLabel1);
            this.uiPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelTop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanelTop.Location = new System.Drawing.Point(0, 0);
            this.uiPanelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelTop.Name = "uiPanelTop";
            this.uiPanelTop.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiPanelTop.Size = new System.Drawing.Size(1670, 150);
            this.uiPanelTop.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanelTop.TabIndex = 0;
            this.uiPanelTop.Text = null;
            this.uiPanelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearching
            // 
            this.txtSearching.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearching.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearching.Location = new System.Drawing.Point(1456, 113);
            this.txtSearching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearching.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearching.Radius = 15;
            this.txtSearching.ShowText = false;
            this.txtSearching.Size = new System.Drawing.Size(209, 29);
            this.txtSearching.TabIndex = 13;
            this.txtSearching.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearching.Watermark = "🔍請輸入員工資訊.....";
            this.txtSearching.TextChanged += new System.EventHandler(this.txtSearching_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 24;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(169, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 40);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "修改資料";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 24;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(307, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "啟用/停用帳號";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblHint
            // 
            this.lblHint.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblHint.ForeColor = System.Drawing.Color.Gray;
            this.lblHint.Location = new System.Drawing.Point(20, 85);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(600, 55);
            this.lblHint.Style = Sunny.UI.UIStyle.Custom;
            this.lblHint.TabIndex = 10;
            this.lblHint.Text = "💡 操作提示1：雙擊下方表格資料可進入修改\r\n💡 操作提示2：選取資料後按下 [Delete] 鍵可 停用 / 啟用 帳號。";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnCreateAccount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(23, 32);
            this.btnCreateAccount.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(140, 40);
            this.btnCreateAccount.Symbol = 61543;
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "新增帳號";
            this.btnCreateAccount.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(1341, 116);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(244, 23);
            this.uiLabel1.TabIndex = 14;
            this.uiLabel1.Text = "關鍵字搜尋：";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccounts.ColumnHeadersHeight = 32;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpId,
            this.colEmpName,
            this.colAccount,
            this.colCreateTime,
            this.colFailedCount,
            this.colIsLocked});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccounts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccounts.EnableHeadersVisualStyles = false;
            this.dgvAccounts.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvAccounts.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dgvAccounts.Location = new System.Drawing.Point(0, 150);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RectColor = System.Drawing.Color.Black;
            this.dgvAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccounts.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvAccounts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccounts.RowTemplate.Height = 35;
            this.dgvAccounts.SelectedIndex = -1;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(1670, 870);
            this.dgvAccounts.TabIndex = 1;
            // 
            // colEmpId
            // 
            this.colEmpId.DataPropertyName = "EmployeeId";
            this.colEmpId.HeaderText = "員工編號";
            this.colEmpId.Name = "colEmpId";
            this.colEmpId.ReadOnly = true;
            // 
            // colEmpName
            // 
            this.colEmpName.DataPropertyName = "EmployeeName";
            this.colEmpName.HeaderText = "員工姓名";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.ReadOnly = true;
            // 
            // colAccount
            // 
            this.colAccount.DataPropertyName = "AccountName";
            this.colAccount.HeaderText = "登入帳號";
            this.colAccount.Name = "colAccount";
            this.colAccount.ReadOnly = true;
            // 
            // colCreateTime
            // 
            this.colCreateTime.DataPropertyName = "CreateTime";
            this.colCreateTime.HeaderText = "建立時間";
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.ReadOnly = true;
            // 
            // colFailedCount
            // 
            this.colFailedCount.DataPropertyName = "FailedLoginCount";
            this.colFailedCount.HeaderText = "登入失敗次數";
            this.colFailedCount.Name = "colFailedCount";
            this.colFailedCount.ReadOnly = true;
            // 
            // colIsLocked
            // 
            this.colIsLocked.DataPropertyName = "StatusText";
            this.colIsLocked.HeaderText = "帳號狀態";
            this.colIsLocked.Name = "colIsLocked";
            this.colIsLocked.ReadOnly = true;
            // 
            // UC_AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.uiPanelTop);
            this.Name = "UC_AccountManager";
            this.Size = new System.Drawing.Size(1670, 1020);
            this.Load += new System.EventHandler(this.UC_AccountManager_Load);
            this.uiPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanelTop;
        private Sunny.UI.UISymbolButton btnCreateAccount;
        private Sunny.UI.UIDataGridView dgvAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFailedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsLocked;
        private Sunny.UI.UILabel lblHint;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private Sunny.UI.UITextBox txtSearching;
        private Sunny.UI.UILabel uiLabel1;
    }
}