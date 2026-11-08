namespace SmartCoffeeSystem
{
    partial class FrmAccountEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountEdit));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cmbEmployee = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtAccount = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtPassword = new Sunny.UI.UITextBox();
            this.btnTogglePwd = new Sunny.UI.UISymbolButton();
            this.lblPwdStrength = new Sunny.UI.UILabel();
            this.btnSave = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(40, 80);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 35);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "綁定員工：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DataSource = null;
            this.cmbEmployee.FillColor = System.Drawing.Color.White;
            this.cmbEmployee.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbEmployee.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbEmployee.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbEmployee.Location = new System.Drawing.Point(145, 80);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEmployee.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbEmployee.Size = new System.Drawing.Size(260, 35);
            this.cmbEmployee.SymbolSize = 24;
            this.cmbEmployee.TabIndex = 1;
            this.cmbEmployee.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbEmployee.Watermark = "請選擇或搜尋員工...";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(40, 140);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 35);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "帳號設定：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAccount
            // 
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(145, 140);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccount.ShowText = false;
            this.txtAccount.Size = new System.Drawing.Size(260, 35);
            this.txtAccount.TabIndex = 3;
            this.txtAccount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAccount.Watermark = "請輸入英數字組合";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(40, 200);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 35);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "密碼設定：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(145, 200);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ShowText = false;
            this.txtPassword.Size = new System.Drawing.Size(260, 35);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassword.Watermark = "請輸入高強度密碼";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnTogglePwd
            // 
            this.btnTogglePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTogglePwd.FillColor = System.Drawing.Color.Transparent;
            this.btnTogglePwd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnTogglePwd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnTogglePwd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTogglePwd.ForeColor = System.Drawing.Color.Gray;
            this.btnTogglePwd.Location = new System.Drawing.Point(412, 200);
            this.btnTogglePwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTogglePwd.Name = "btnTogglePwd";
            this.btnTogglePwd.RectColor = System.Drawing.Color.Transparent;
            this.btnTogglePwd.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnTogglePwd.RectPressColor = System.Drawing.Color.Transparent;
            this.btnTogglePwd.Size = new System.Drawing.Size(35, 35);
            this.btnTogglePwd.Symbol = 61552;
            this.btnTogglePwd.SymbolColor = System.Drawing.Color.Gray;
            this.btnTogglePwd.TabIndex = 6;
            this.btnTogglePwd.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTogglePwd.Click += new System.EventHandler(this.btnTogglePwd_Click);
            // 
            // lblPwdStrength
            // 
            this.lblPwdStrength.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPwdStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPwdStrength.Location = new System.Drawing.Point(145, 240);
            this.lblPwdStrength.Name = "lblPwdStrength";
            this.lblPwdStrength.Size = new System.Drawing.Size(260, 25);
            this.lblPwdStrength.TabIndex = 7;
            this.lblPwdStrength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSave.FillColor2 = System.Drawing.Color.Cyan;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(44, 289);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 45);
            this.btnSave.Symbol = 61639;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "確認儲存";
            this.btnSave.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.LightColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(251, 289);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnCancel.Size = new System.Drawing.Size(184, 45);
            this.btnCancel.Symbol = 61453;
            this.btnCancel.SymbolHoverColor = System.Drawing.Color.IndianRed;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消關閉";
            this.btnCancel.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAccountEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(480, 382);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPwdStrength);
            this.Controls.Add(this.btnTogglePwd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAccountEdit";
            this.Text = "帳號設定";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 480, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cmbEmployee;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtAccount;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UISymbolButton btnTogglePwd;
        private Sunny.UI.UILabel lblPwdStrength;
        private Sunny.UI.UISymbolButton btnSave;
        private Sunny.UI.UISymbolButton btnCancel;
    }
}