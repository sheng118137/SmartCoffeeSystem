namespace SmartCoffeeSystem.View
{
    partial class UC_BackupManager
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
            this.panelTop = new Sunny.UI.UIPanel();
            this.lblTitle = new Sunny.UI.UILabel();
            this.panelLeft = new Sunny.UI.UIPanel();
            this.lblBackupDesc = new Sunny.UI.UILabel();
            this.btnBackup = new Sunny.UI.UIButton();
            this.lblBackupTitle = new Sunny.UI.UILabel();
            this.panelRight = new Sunny.UI.UIPanel();
            this.lblRestoreDesc = new Sunny.UI.UILabel();
            this.btnRestore = new Sunny.UI.UIButton();
            this.lblRestoreTitle = new Sunny.UI.UILabel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "系統資料庫備份管理";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lblBackupDesc);
            this.panelLeft.Controls.Add(this.btnBackup);
            this.panelLeft.Controls.Add(this.lblBackupTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.FillColor = System.Drawing.Color.White;
            this.panelLeft.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLeft.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(30);
            this.panelLeft.Size = new System.Drawing.Size(798, 950);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Text = null;
            this.panelLeft.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBackupDesc
            // 
            this.lblBackupDesc.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblBackupDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblBackupDesc.Location = new System.Drawing.Point(161, 150);
            this.lblBackupDesc.Name = "lblBackupDesc";
            this.lblBackupDesc.Size = new System.Drawing.Size(460, 100);
            this.lblBackupDesc.TabIndex = 1;
            this.lblBackupDesc.Text = "將目前的商品、訂單、分類等所有營業資料，打包成 .bak 檔案並儲存至您的電腦中\r\n\r\n建議每周可以手動執行一次備份，以確保資料安全";
            // 
            // btnBackup
            // 
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnBackup.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(210)))), ((int)(((byte)(60)))));
            this.btnBackup.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.btnBackup.Location = new System.Drawing.Point(279, 306);
            this.btnBackup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Radius = 10;
            this.btnBackup.Size = new System.Drawing.Size(200, 50);
            this.btnBackup.Style = Sunny.UI.UIStyle.Custom;
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "開始備份資料庫";
            this.btnBackup.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblBackupTitle
            // 
            this.lblBackupTitle.AutoSize = true;
            this.lblBackupTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblBackupTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblBackupTitle.Location = new System.Drawing.Point(313, 78);
            this.lblBackupTitle.Name = "lblBackupTitle";
            this.lblBackupTitle.Size = new System.Drawing.Size(122, 28);
            this.lblBackupTitle.TabIndex = 0;
            this.lblBackupTitle.Text = "資料庫備份";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.lblRestoreDesc);
            this.panelRight.Controls.Add(this.btnRestore);
            this.panelRight.Controls.Add(this.lblRestoreTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.FillColor = System.Drawing.Color.White;
            this.panelRight.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelRight.Location = new System.Drawing.Point(798, 70);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRight.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(30);
            this.panelRight.Size = new System.Drawing.Size(872, 950);
            this.panelRight.TabIndex = 2;
            this.panelRight.Text = null;
            this.panelRight.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestoreDesc
            // 
            this.lblRestoreDesc.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lblRestoreDesc.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRestoreDesc.Location = new System.Drawing.Point(229, 150);
            this.lblRestoreDesc.Name = "lblRestoreDesc";
            this.lblRestoreDesc.Size = new System.Drawing.Size(460, 100);
            this.lblRestoreDesc.TabIndex = 1;
            this.lblRestoreDesc.Text = "從您的電腦中選取 .bak 備份檔案，並覆蓋目前系統\r\n\r\n執行還原後，系統內未備份的新資料會被清除且無法復原";
            // 
            // btnRestore
            // 
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRestore.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRestore.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnRestore.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestore.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestore.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.btnRestore.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnRestore.Location = new System.Drawing.Point(362, 306);
            this.btnRestore.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Radius = 10;
            this.btnRestore.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRestore.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnRestore.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestore.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestore.Size = new System.Drawing.Size(200, 50);
            this.btnRestore.Style = Sunny.UI.UIStyle.Custom;
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "選擇檔案並還原";
            this.btnRestore.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblRestoreTitle
            // 
            this.lblRestoreTitle.AutoSize = true;
            this.lblRestoreTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblRestoreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblRestoreTitle.Location = new System.Drawing.Point(394, 78);
            this.lblRestoreTitle.Name = "lblRestoreTitle";
            this.lblRestoreTitle.Size = new System.Drawing.Size(122, 28);
            this.lblRestoreTitle.TabIndex = 0;
            this.lblRestoreTitle.Text = "資料庫還原";
            // 
            // UC_BackupManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_BackupManager";
            this.Size = new System.Drawing.Size(1670, 1020);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIPanel panelLeft;
        private Sunny.UI.UILabel lblBackupTitle;
        private Sunny.UI.UILabel lblBackupDesc;
        private Sunny.UI.UIButton btnBackup;
        private Sunny.UI.UIPanel panelRight;
        private Sunny.UI.UILabel lblRestoreTitle;
        private Sunny.UI.UILabel lblRestoreDesc;
        private Sunny.UI.UIButton btnRestore;
    }
}