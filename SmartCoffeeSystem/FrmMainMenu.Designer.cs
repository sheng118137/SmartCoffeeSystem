using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SmartCoffeeSystem
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理任何使用中的資源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnterAdmin = new System.Windows.Forms.Button();
            this.btnEnterPOS = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.highQualityPictureBox1 = new SmartCoffeeSystem.HighQualityPictureBox();
            this.highQualityPictureBox2 = new SmartCoffeeSystem.HighQualityPictureBox();
            this.btnLogin = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highQualityPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highQualityPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClock.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(35, 20);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(300, 50);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "2026/07/16 星期四 14:30:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(45)))), ((int)(((byte)(25)))));
            this.btnExit.Location = new System.Drawing.Point(1748, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "❌ 結束系統";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnterAdmin
            // 
            this.btnEnterAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(48)))), ((int)(((byte)(35)))));
            this.btnEnterAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterAdmin.FlatAppearance.BorderSize = 0;
            this.btnEnterAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterAdmin.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnEnterAdmin.Location = new System.Drawing.Point(1124, 883);
            this.btnEnterAdmin.Name = "btnEnterAdmin";
            this.btnEnterAdmin.Size = new System.Drawing.Size(338, 71);
            this.btnEnterAdmin.TabIndex = 2;
            this.btnEnterAdmin.Text = "進入 ADMIN 系統   ➔";
            this.btnEnterAdmin.UseVisualStyleBackColor = false;
            this.btnEnterAdmin.Click += new System.EventHandler(this.btnEnterAdmin_Click_1);
            // 
            // btnEnterPOS
            // 
            this.btnEnterPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(213)))), ((int)(((byte)(180)))));
            this.btnEnterPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterPOS.FlatAppearance.BorderSize = 0;
            this.btnEnterPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterPOS.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnEnterPOS.Location = new System.Drawing.Point(475, 883);
            this.btnEnterPOS.Name = "btnEnterPOS";
            this.btnEnterPOS.Size = new System.Drawing.Size(338, 71);
            this.btnEnterPOS.TabIndex = 3;
            this.btnEnterPOS.Text = "進入 POS 系統   ➔";
            this.btnEnterPOS.UseVisualStyleBackColor = false;
            this.btnEnterPOS.Click += new System.EventHandler(this.btnEnterPOS_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SmartCoffeeSystem.Properties.Resources.ADMINLOGO;
            this.pictureBox2.Location = new System.Drawing.Point(1218, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(860, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "智能‧高效‧咖啡點餐";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(463, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 72);
            this.label3.TabIndex = 12;
            this.label3.Text = "POS客戶系統";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(1074, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 72);
            this.label4.TabIndex = 13;
            this.label4.Text = "Admin後台系統";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(556, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "🛒  快速點餐";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(556, 660);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "📋   會員訂單";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.SeaShell;
            this.label7.Location = new System.Drawing.Point(556, 730);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "📜  結帳收據";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.SeaShell;
            this.label8.Location = new System.Drawing.Point(557, 800);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "🙆‍  會員查詢";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(1191, 644);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 36);
            this.label9.TabIndex = 21;
            this.label9.Text = "📋   產品管理";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(1191, 696);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 36);
            this.label10.TabIndex = 20;
            this.label10.Text = "🔐  權限管理";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(1192, 748);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 36);
            this.label11.TabIndex = 19;
            this.label11.Text = "🧧   營收統計";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Sienna;
            this.label12.Location = new System.Drawing.Point(1192, 590);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 36);
            this.label12.TabIndex = 18;
            this.label12.Text = "🆔  會員管理";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Sienna;
            this.label13.Location = new System.Drawing.Point(1191, 800);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 36);
            this.label13.TabIndex = 22;
            this.label13.Text = "☝    員工出勤";
            // 
            // highQualityPictureBox1
            // 
            this.highQualityPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.highQualityPictureBox1.Image = global::SmartCoffeeSystem.Properties.Resources.POSLOGO;
            this.highQualityPictureBox1.Location = new System.Drawing.Point(589, 358);
            this.highQualityPictureBox1.Name = "highQualityPictureBox1";
            this.highQualityPictureBox1.Size = new System.Drawing.Size(132, 121);
            this.highQualityPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.highQualityPictureBox1.TabIndex = 8;
            this.highQualityPictureBox1.TabStop = false;
            // 
            // highQualityPictureBox2
            // 
            this.highQualityPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.highQualityPictureBox2.Image = global::SmartCoffeeSystem.Properties.Resources.Logo;
            this.highQualityPictureBox2.Location = new System.Drawing.Point(641, -33);
            this.highQualityPictureBox2.Name = "highQualityPictureBox2";
            this.highQualityPictureBox2.Size = new System.Drawing.Size(674, 385);
            this.highQualityPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.highQualityPictureBox2.TabIndex = 9;
            this.highQualityPictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnLogin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnLogin.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnLogin.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.btnLogin.Location = new System.Drawing.Point(1595, 18);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 15;
            this.btnLogin.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnLogin.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnLogin.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnLogin.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnLogin.Size = new System.Drawing.Size(147, 40);
            this.btnLogin.Style = Sunny.UI.UIStyle.Custom;
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "🔑 登入帳號";
            this.btnLogin.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SmartCoffeeSystem.Properties.Resources.Mainbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highQualityPictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEnterPOS);
            this.Controls.Add(this.btnEnterAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.highQualityPictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highQualityPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highQualityPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblClock;
        private Button btnExit;
        private Button btnEnterAdmin;
        private Button btnEnterPOS;
        private Timer timerClock;
        private PictureBox pictureBox2;
        private HighQualityPictureBox highQualityPictureBox1;
        private HighQualityPictureBox highQualityPictureBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Sunny.UI.UIButton btnLogin;
    }
}