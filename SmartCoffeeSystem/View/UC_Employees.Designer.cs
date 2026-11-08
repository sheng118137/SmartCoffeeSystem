namespace SmartCoffeeSystem.View
{
    partial class UC_Employees
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.btnAdd = new Sunny.UI.UIButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnSave = new Sunny.UI.UIButton();
            this.btnDelete = new Sunny.UI.UIButton();
            this.txtAddress = new Sunny.UI.UITextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStatus = new Sunny.UI.UIComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTitle = new Sunny.UI.UIComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Sunny.UI.UITextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRightTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1655, 80);
            this.panelTop.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtSearch.Location = new System.Drawing.Point(210, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(250, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "搜尋員工姓名...";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.btnAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.btnAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(20)))));
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(480, 22);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RectColor = System.Drawing.Color.Transparent;
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "➕ 新增員工";
            this.btnAdd.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "員工資料管理";
            // 
            // panelMainContent
            // 
            this.panelMainContent.ColumnCount = 2;
            this.panelMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.67692F));
            this.panelMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.32308F));
            this.panelMainContent.Controls.Add(this.panelLeft, 0, 0);
            this.panelMainContent.Controls.Add(this.panelRight, 1, 0);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 80);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(15);
            this.panelMainContent.RowCount = 1;
            this.panelMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMainContent.Size = new System.Drawing.Size(1655, 925);
            this.panelMainContent.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.dgvEmployees);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(18, 18);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(582, 889);
            this.panelLeft.TabIndex = 0;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeName,
            this.colEmployeeTitle,
            this.colEmployeeStatus});
            this.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployees.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowTemplate.Height = 40;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(582, 889);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.HeaderText = "員工姓名";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.ReadOnly = true;
            // 
            // colEmployeeTitle
            // 
            this.colEmployeeTitle.HeaderText = "職稱角色";
            this.colEmployeeTitle.Name = "colEmployeeTitle";
            this.colEmployeeTitle.ReadOnly = true;
            // 
            // colEmployeeStatus
            // 
            this.colEmployeeStatus.HeaderText = "狀態";
            this.colEmployeeStatus.Name = "colEmployeeStatus";
            this.colEmployeeStatus.ReadOnly = true;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.btnSave);
            this.panelRight.Controls.Add(this.btnDelete);
            this.panelRight.Controls.Add(this.txtAddress);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.txtEmail);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.txtPhone);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.cbStatus);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.cbTitle);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.txtName);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.lblRightTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(613, 18);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(20);
            this.panelRight.Size = new System.Drawing.Size(1024, 889);
            this.panelRight.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.btnSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(70)))));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(220, 520);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "💾 儲存設定";
            this.btnSave.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(376, 520);
            this.btnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "🗝停用員工";
            this.btnDelete.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtAddress.Location = new System.Drawing.Point(120, 360);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(5);
            this.txtAddress.ShowText = false;
            this.txtAddress.Size = new System.Drawing.Size(500, 36);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAddress.Watermark = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "聯絡地址:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtEmail.Location = new System.Drawing.Point(120, 290);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(300, 36);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtPhone.Location = new System.Drawing.Point(120, 220);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(5);
            this.txtPhone.ShowText = false;
            this.txtPhone.Size = new System.Drawing.Size(300, 36);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPhone.Watermark = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "聯絡電話:";
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = null;
            this.cbStatus.FillColor = System.Drawing.Color.White;
            this.cbStatus.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cbStatus.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbStatus.Location = new System.Drawing.Point(520, 150);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStatus.Size = new System.Drawing.Size(150, 36);
            this.cbStatus.SymbolSize = 24;
            this.cbStatus.TabIndex = 6;
            this.cbStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatus.Watermark = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "在職狀態:";
            // 
            // cbTitle
            // 
            this.cbTitle.DataSource = null;
            this.cbTitle.FillColor = System.Drawing.Color.White;
            this.cbTitle.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.cbTitle.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbTitle.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbTitle.Location = new System.Drawing.Point(120, 150);
            this.cbTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTitle.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTitle.Size = new System.Drawing.Size(200, 36);
            this.cbTitle.SymbolSize = 24;
            this.cbTitle.TabIndex = 4;
            this.cbTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTitle.Watermark = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "職稱角色:";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtName.Location = new System.Drawing.Point(120, 80);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(200, 36);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "員工姓名:";
            // 
            // lblRightTitle
            // 
            this.lblRightTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblRightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.lblRightTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRightTitle.Name = "lblRightTitle";
            this.lblRightTitle.Size = new System.Drawing.Size(984, 30);
            this.lblRightTitle.TabIndex = 0;
            this.lblRightTitle.Text = "編輯員工資料";
            // 
            // UC_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_Employees";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.Size = new System.Drawing.Size(1670, 1020);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIButton btnAdd;
        private System.Windows.Forms.TableLayoutPanel panelMainContent;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeStatus;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblRightTitle;
        private Sunny.UI.UITextBox txtName;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIComboBox cbTitle;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private Sunny.UI.UITextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnDelete;
    }
}