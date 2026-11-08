namespace SmartCoffeeSystem.View
{
    partial class UC_Permission
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lstRoles = new System.Windows.Forms.ListBox();
            this.lblLeftTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnSavePermission = new Sunny.UI.UIButton();
            this.chkPermissions = new System.Windows.Forms.CheckedListBox();
            this.lblRightTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1655, 80);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "系統權限管理";
            // 
            // panelMainContent
            // 
            this.panelMainContent.ColumnCount = 2;
            this.panelMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.panelMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
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
            this.panelLeft.Controls.Add(this.lstRoles);
            this.panelLeft.Controls.Add(this.lblLeftTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(18, 18);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(20);
            this.panelLeft.Size = new System.Drawing.Size(555, 889);
            this.panelLeft.TabIndex = 0;
            // 
            // lstRoles
            // 
            this.lstRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRoles.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lstRoles.FormattingEnabled = true;
            this.lstRoles.ItemHeight = 24;
            this.lstRoles.Location = new System.Drawing.Point(20, 66);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(515, 803);
            this.lstRoles.TabIndex = 1;
            this.lstRoles.SelectedIndexChanged += new System.EventHandler(this.lstRoles_SelectedIndexChanged);
            // 
            // lblLeftTitle
            // 
            this.lblLeftTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLeftTitle.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblLeftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblLeftTitle.Location = new System.Drawing.Point(20, 20);
            this.lblLeftTitle.Name = "lblLeftTitle";
            this.lblLeftTitle.Size = new System.Drawing.Size(515, 46);
            this.lblLeftTitle.TabIndex = 0;
            this.lblLeftTitle.Text = "選擇職稱 / 角色";
            this.lblLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.btnSavePermission);
            this.panelRight.Controls.Add(this.chkPermissions);
            this.panelRight.Controls.Add(this.lblRightTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(586, 18);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(20);
            this.panelRight.Size = new System.Drawing.Size(1051, 889);
            this.panelRight.TabIndex = 1;
            // 
            // btnSavePermission
            // 
            this.btnSavePermission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePermission.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.btnSavePermission.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnSavePermission.Location = new System.Drawing.Point(20, 480);
            this.btnSavePermission.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSavePermission.Name = "btnSavePermission";
            this.btnSavePermission.Size = new System.Drawing.Size(180, 48);
            this.btnSavePermission.TabIndex = 2;
            this.btnSavePermission.Text = "💾 儲存權設定";
            this.btnSavePermission.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSavePermission.Click += new System.EventHandler(this.btnSavePermission_Click);
            // 
            // chkPermissions
            // 
            this.chkPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkPermissions.CheckOnClick = true;
            this.chkPermissions.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.chkPermissions.FormattingEnabled = true;
            this.chkPermissions.Location = new System.Drawing.Point(20, 78);
            this.chkPermissions.Name = "chkPermissions";
            this.chkPermissions.Size = new System.Drawing.Size(600, 351);
            this.chkPermissions.TabIndex = 1;
            // 
            // lblRightTitle
            // 
            this.lblRightTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRightTitle.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblRightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.lblRightTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRightTitle.Name = "lblRightTitle";
            this.lblRightTitle.Size = new System.Drawing.Size(1011, 46);
            this.lblRightTitle.TabIndex = 0;
            this.lblRightTitle.Text = "功能模組權限";
            this.lblRightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_Permission";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.Size = new System.Drawing.Size(1670, 1020);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel panelMainContent;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ListBox lstRoles;
        private System.Windows.Forms.Label lblLeftTitle;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblRightTitle;
        private System.Windows.Forms.CheckedListBox chkPermissions;
        private Sunny.UI.UIButton btnSavePermission;
    }
}