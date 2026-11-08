namespace SmartCoffeeSystem
{
    partial class FrmLogin
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.picCaptcha = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlUserLine = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtVerification = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelVerificationLine = new System.Windows.Forms.Panel();
            this.pnlPassLine = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.picCaptcha);
            this.loginPanel.Controls.Add(this.lblWelcome);
            this.loginPanel.Controls.Add(this.lblSubtitle);
            this.loginPanel.Controls.Add(this.picLogo);
            this.loginPanel.Controls.Add(this.lblUser);
            this.loginPanel.Controls.Add(this.pnlUserLine);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.lblPass);
            this.loginPanel.Controls.Add(this.txtUsername);
            this.loginPanel.Controls.Add(this.txtVerification);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.panelVerificationLine);
            this.loginPanel.Controls.Add(this.pnlPassLine);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.lblStatus);
            this.loginPanel.Location = new System.Drawing.Point(750, 80);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(430, 616);
            this.loginPanel.TabIndex = 0;
            // 
            // picCaptcha
            // 
            this.picCaptcha.Location = new System.Drawing.Point(48, 387);
            this.picCaptcha.Name = "picCaptcha";
            this.picCaptcha.Size = new System.Drawing.Size(330, 31);
            this.picCaptcha.TabIndex = 11;
            this.picCaptcha.TabStop = false;
            this.picCaptcha.Click += new System.EventHandler(this.picCaptcha_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.lblWelcome.Location = new System.Drawing.Point(150, 525);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(140, 25);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome Back";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(75, 95);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(273, 30);
            this.lblSubtitle.TabIndex = 10;
            this.lblSubtitle.Text = "AI Coffee Ordering System";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(140, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.ForeColor = System.Drawing.Color.Gray;
            this.lblUser.Location = new System.Drawing.Point(45, 145);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 15);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "員工帳號";
            // 
            // pnlUserLine
            // 
            this.pnlUserLine.BackColor = System.Drawing.Color.Silver;
            this.pnlUserLine.Location = new System.Drawing.Point(45, 202);
            this.pnlUserLine.Name = "pnlUserLine";
            this.pnlUserLine.Size = new System.Drawing.Size(330, 2);
            this.pnlUserLine.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(45, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "驗證碼(點圖片刷新)";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPass.ForeColor = System.Drawing.Color.Gray;
            this.lblPass.Location = new System.Drawing.Point(45, 235);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(59, 15);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "員工密碼";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(45, 179);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(330, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // txtVerification
            // 
            this.txtVerification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVerification.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtVerification.Location = new System.Drawing.Point(45, 340);
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.Size = new System.Drawing.Size(330, 22);
            this.txtVerification.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(45, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(330, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // panelVerificationLine
            // 
            this.panelVerificationLine.BackColor = System.Drawing.Color.Silver;
            this.panelVerificationLine.Location = new System.Drawing.Point(45, 372);
            this.panelVerificationLine.Name = "panelVerificationLine";
            this.panelVerificationLine.Size = new System.Drawing.Size(330, 2);
            this.panelVerificationLine.TabIndex = 2;
            // 
            // pnlPassLine
            // 
            this.pnlPassLine.BackColor = System.Drawing.Color.Silver;
            this.pnlPassLine.Location = new System.Drawing.Point(45, 292);
            this.pnlPassLine.Name = "pnlPassLine";
            this.pnlPassLine.Size = new System.Drawing.Size(330, 2);
            this.pnlPassLine.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(45, 463);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(330, 50);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "➔ 登入系統Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblStatus.Location = new System.Drawing.Point(45, 429);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(330, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1235, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "✕";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlUserLine;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPassLine;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerification;
        private System.Windows.Forms.Panel panelVerificationLine;
        private System.Windows.Forms.PictureBox picCaptcha;
    }
}