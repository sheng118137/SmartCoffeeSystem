namespace SmartCoffeeSystem
{
    partial class FrmCheckout
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnCheckMember = new System.Windows.Forms.Button();
            this.lblMemberStatus = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnLinePay = new System.Windows.Forms.Button();
            this.btnEasyCard = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnMobile = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.txtCarrier = new System.Windows.Forms.TextBox();
            this.lblFinalAmount = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSection1 = new System.Windows.Forms.Label();
            this.lblSection2 = new System.Windows.Forms.Label();
            this.lblSection3 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtUsePoints = new Sunny.UI.UITextBox();
            this.btnPoints = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(779, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txtPhone.Location = new System.Drawing.Point(30, 130);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 36);
            this.txtPhone.TabIndex = 1;
            // 
            // btnCheckMember
            // 
            this.btnCheckMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnCheckMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckMember.FlatAppearance.BorderSize = 0;
            this.btnCheckMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckMember.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnCheckMember.ForeColor = System.Drawing.Color.White;
            this.btnCheckMember.Location = new System.Drawing.Point(295, 128);
            this.btnCheckMember.Name = "btnCheckMember";
            this.btnCheckMember.Size = new System.Drawing.Size(120, 38);
            this.btnCheckMember.TabIndex = 2;
            this.btnCheckMember.Text = "查詢會員";
            this.btnCheckMember.UseVisualStyleBackColor = false;
            // 
            // lblMemberStatus
            // 
            this.lblMemberStatus.AutoSize = true;
            this.lblMemberStatus.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblMemberStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblMemberStatus.Location = new System.Drawing.Point(256, 90);
            this.lblMemberStatus.Name = "lblMemberStatus";
            this.lblMemberStatus.Size = new System.Drawing.Size(105, 24);
            this.lblMemberStatus.TabIndex = 3;
            this.lblMemberStatus.Text = "非會員結帳";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.White;
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnCash.Location = new System.Drawing.Point(30, 250);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(135, 50);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = false;
            // 
            // btnLinePay
            // 
            this.btnLinePay.BackColor = System.Drawing.Color.White;
            this.btnLinePay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinePay.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnLinePay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnLinePay.Location = new System.Drawing.Point(340, 250);
            this.btnLinePay.Name = "btnLinePay";
            this.btnLinePay.Size = new System.Drawing.Size(135, 50);
            this.btnLinePay.TabIndex = 4;
            this.btnLinePay.Text = "LINE Pay";
            this.btnLinePay.UseVisualStyleBackColor = false;
            // 
            // btnEasyCard
            // 
            this.btnEasyCard.BackColor = System.Drawing.Color.White;
            this.btnEasyCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEasyCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasyCard.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnEasyCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnEasyCard.Location = new System.Drawing.Point(495, 250);
            this.btnEasyCard.Name = "btnEasyCard";
            this.btnEasyCard.Size = new System.Drawing.Size(135, 50);
            this.btnEasyCard.TabIndex = 5;
            this.btnEasyCard.Text = "悠遊卡";
            this.btnEasyCard.UseVisualStyleBackColor = false;
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.White;
            this.btnCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnCard.Location = new System.Drawing.Point(185, 250);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(135, 50);
            this.btnCard.TabIndex = 6;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = false;
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.White;
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaper.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnPaper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnPaper.Location = new System.Drawing.Point(31, 437);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(135, 50);
            this.btnPaper.TabIndex = 7;
            this.btnPaper.Text = "紙本發票";
            this.btnPaper.UseVisualStyleBackColor = false;
            // 
            // btnMobile
            // 
            this.btnMobile.BackColor = System.Drawing.Color.White;
            this.btnMobile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobile.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnMobile.Location = new System.Drawing.Point(186, 437);
            this.btnMobile.Name = "btnMobile";
            this.btnMobile.Size = new System.Drawing.Size(135, 50);
            this.btnMobile.TabIndex = 8;
            this.btnMobile.Text = "手機條碼";
            this.btnMobile.UseVisualStyleBackColor = false;
            // 
            // btnTax
            // 
            this.btnTax.BackColor = System.Drawing.Color.White;
            this.btnTax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTax.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnTax.Location = new System.Drawing.Point(341, 437);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(135, 50);
            this.btnTax.TabIndex = 9;
            this.btnTax.Text = "公司統編";
            this.btnTax.UseVisualStyleBackColor = false;
            // 
            // txtCarrier
            // 
            this.txtCarrier.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txtCarrier.Location = new System.Drawing.Point(31, 507);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(445, 36);
            this.txtCarrier.TabIndex = 10;
            this.txtCarrier.Visible = false;
            // 
            // lblFinalAmount
            // 
            this.lblFinalAmount.AutoSize = true;
            this.lblFinalAmount.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.lblFinalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.lblFinalAmount.Location = new System.Drawing.Point(22, 40);
            this.lblFinalAmount.Name = "lblFinalAmount";
            this.lblFinalAmount.Size = new System.Drawing.Size(203, 38);
            this.lblFinalAmount.TabIndex = 11;
            this.lblFinalAmount.Text = "應付總額：$0";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(655, 30);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(190, 60);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "確認結帳";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(857, 60);
            this.pnlTop.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "結帳與付款資訊";
            // 
            // lblSection1
            // 
            this.lblSection1.AutoSize = true;
            this.lblSection1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblSection1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.lblSection1.Location = new System.Drawing.Point(25, 90);
            this.lblSection1.Name = "lblSection1";
            this.lblSection1.Size = new System.Drawing.Size(225, 24);
            this.lblSection1.TabIndex = 14;
            this.lblSection1.Text = "會員享9折優惠(手機號碼)";
            // 
            // lblSection2
            // 
            this.lblSection2.AutoSize = true;
            this.lblSection2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblSection2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.lblSection2.Location = new System.Drawing.Point(25, 210);
            this.lblSection2.Name = "lblSection2";
            this.lblSection2.Size = new System.Drawing.Size(124, 24);
            this.lblSection2.TabIndex = 15;
            this.lblSection2.Text = "選擇付款方式";
            // 
            // lblSection3
            // 
            this.lblSection3.AutoSize = true;
            this.lblSection3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblSection3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.lblSection3.Location = new System.Drawing.Point(26, 403);
            this.lblSection3.Name = "lblSection3";
            this.lblSection3.Size = new System.Drawing.Size(105, 24);
            this.lblSection3.TabIndex = 16;
            this.lblSection3.Text = "發票與載具";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlBottom.Controls.Add(this.lblFinalAmount);
            this.pnlBottom.Controls.Add(this.btnConfirm);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 560);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(857, 120);
            this.pnlBottom.TabIndex = 17;
            // 
            // txtUsePoints
            // 
            this.txtUsePoints.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtUsePoints.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.txtUsePoints.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.txtUsePoints.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtUsePoints.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(203)))), ((int)(((byte)(189)))));
            this.txtUsePoints.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(138)))));
            this.txtUsePoints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsePoints.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.txtUsePoints.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsePoints.Location = new System.Drawing.Point(186, 321);
            this.txtUsePoints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsePoints.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtUsePoints.Name = "txtUsePoints";
            this.txtUsePoints.Padding = new System.Windows.Forms.Padding(5);
            this.txtUsePoints.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtUsePoints.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtUsePoints.ShowText = false;
            this.txtUsePoints.Size = new System.Drawing.Size(138, 50);
            this.txtUsePoints.Style = Sunny.UI.UIStyle.Custom;
            this.txtUsePoints.TabIndex = 18;
            this.txtUsePoints.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUsePoints.Visible = false;
            this.txtUsePoints.Watermark = "請輸入點數";
            // 
            // btnPoints
            // 
            this.btnPoints.BackColor = System.Drawing.Color.White;
            this.btnPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoints.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnPoints.Location = new System.Drawing.Point(31, 321);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(135, 50);
            this.btnPoints.TabIndex = 19;
            this.btnPoints.Text = "點數付款";
            this.btnPoints.UseVisualStyleBackColor = false;
            this.btnPoints.Visible = false;
            // 
            // FrmCheckout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(857, 680);
            this.Controls.Add(this.btnPoints);
            this.Controls.Add(this.txtUsePoints);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.txtCarrier);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.btnMobile);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.lblSection3);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnEasyCard);
            this.Controls.Add(this.btnLinePay);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.lblSection2);
            this.Controls.Add(this.lblMemberStatus);
            this.Controls.Add(this.btnCheckMember);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblSection1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "結帳";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnCheckMember;
        private System.Windows.Forms.Label lblMemberStatus;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnLinePay;
        private System.Windows.Forms.Button btnEasyCard;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnMobile;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.TextBox txtCarrier;
        private System.Windows.Forms.Label lblFinalAmount;
        private System.Windows.Forms.Button btnConfirm;

        // 新增的輔助版面控制項
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSection1;
        private System.Windows.Forms.Label lblSection2;
        private System.Windows.Forms.Label lblSection3;
        private System.Windows.Forms.Panel pnlBottom;
        private Sunny.UI.UITextBox txtUsePoints;
        private System.Windows.Forms.Button btnPoints;
    }
}