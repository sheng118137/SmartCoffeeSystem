using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartCoffeeSystem
{
    partial class FrmPOS
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelToggleContainer = new System.Windows.Forms.Panel();
            this.panelToggleSlider = new System.Windows.Forms.Panel();
            this.lblToggleText = new System.Windows.Forms.Label();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLeftBase = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelCart = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.panelCheckout = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.FlowLayoutPanel();
            this.headerPanel.SuspendLayout();
            this.panelToggleContainer.SuspendLayout();
            this.panelToggleSlider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelLeftBase.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelCart.SuspendLayout();
            this.panelCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.lblSearch);
            this.headerPanel.Controls.Add(this.txtSearch);
            this.headerPanel.Controls.Add(this.panelToggleContainer);
            this.headerPanel.Controls.Add(this.btnReturnHome);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.Logo);
            this.headerPanel.Controls.Add(this.flowLayoutPanel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(2153, 125);
            this.headerPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.lblSearch.Location = new System.Drawing.Point(1734, 47);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(150, 35);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "關鍵字搜尋";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(1890, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 42);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "搜尋商品...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panelToggleContainer
            // 
            this.panelToggleContainer.BackColor = System.Drawing.Color.Sienna;
            this.panelToggleContainer.Controls.Add(this.panelToggleSlider);
            this.panelToggleContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelToggleContainer.Location = new System.Drawing.Point(517, 25);
            this.panelToggleContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelToggleContainer.Name = "panelToggleContainer";
            this.panelToggleContainer.Size = new System.Drawing.Size(240, 75);
            this.panelToggleContainer.TabIndex = 3;
            this.panelToggleContainer.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // panelToggleSlider
            // 
            this.panelToggleSlider.BackColor = System.Drawing.Color.White;
            this.panelToggleSlider.Controls.Add(this.lblToggleText);
            this.panelToggleSlider.Location = new System.Drawing.Point(7, 7);
            this.panelToggleSlider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelToggleSlider.Name = "panelToggleSlider";
            this.panelToggleSlider.Size = new System.Drawing.Size(114, 62);
            this.panelToggleSlider.TabIndex = 0;
            this.panelToggleSlider.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // lblToggleText
            // 
            this.lblToggleText.BackColor = System.Drawing.Color.Transparent;
            this.lblToggleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToggleText.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToggleText.ForeColor = System.Drawing.Color.Black;
            this.lblToggleText.Location = new System.Drawing.Point(0, 0);
            this.lblToggleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToggleText.Name = "lblToggleText";
            this.lblToggleText.Size = new System.Drawing.Size(114, 62);
            this.lblToggleText.TabIndex = 0;
            this.lblToggleText.Text = "內用";
            this.lblToggleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToggleText.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReturnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnHome.FlatAppearance.BorderSize = 0;
            this.btnReturnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnHome.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnHome.ForeColor = System.Drawing.Color.White;
            this.btnReturnHome.Location = new System.Drawing.Point(2279, 22);
            this.btnReturnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(248, 82);
            this.btnReturnHome.TabIndex = 0;
            this.btnReturnHome.Text = "❌取消 / 返回";
            this.btnReturnHome.UseVisualStyleBackColor = false;
            this.btnReturnHome.Click += new System.EventHandler(this.btnReturnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(1106, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "POS點餐系統";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::SmartCoffeeSystem.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(480, 157);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 125);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panelLeftBase
            // 
            this.panelLeftBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.panelLeftBase.Controls.Add(this.panelLeft);
            this.panelLeftBase.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftBase.Location = new System.Drawing.Point(0, 125);
            this.panelLeftBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLeftBase.Name = "panelLeftBase";
            this.panelLeftBase.Size = new System.Drawing.Size(480, 1018);
            this.panelLeftBase.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.OldLace;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(13, 18, 0, 18);
            this.panelLeft.Size = new System.Drawing.Size(480, 1018);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.WrapContents = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.panelRight.Controls.Add(this.panelCart);
            this.panelRight.Controls.Add(this.panelCheckout);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1513, 125);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(640, 1018);
            this.panelRight.TabIndex = 2;
            // 
            // panelCart
            // 
            this.panelCart.AutoScroll = true;
            this.panelCart.BackColor = System.Drawing.Color.Transparent;
            this.panelCart.Controls.Add(this.lblEmpty);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelCart.Location = new System.Drawing.Point(0, 0);
            this.panelCart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelCart.Name = "panelCart";
            this.panelCart.Padding = new System.Windows.Forms.Padding(20, 12, 7, 12);
            this.panelCart.Size = new System.Drawing.Size(640, 676);
            this.panelCart.TabIndex = 2;
            this.panelCart.WrapContents = false;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpty.Location = new System.Drawing.Point(24, 12);
            this.lblEmpty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Padding = new System.Windows.Forms.Padding(187, 442, 0, 0);
            this.lblEmpty.Size = new System.Drawing.Size(418, 478);
            this.lblEmpty.TabIndex = 5;
            this.lblEmpty.Text = "購物車目前是空的";
            // 
            // panelCheckout
            // 
            this.panelCheckout.BackColor = System.Drawing.SystemColors.Control;
            this.panelCheckout.Controls.Add(this.btnClear);
            this.panelCheckout.Controls.Add(this.lblGrandTotal);
            this.panelCheckout.Controls.Add(this.lblTotalCount);
            this.panelCheckout.Controls.Add(this.btnCheckout);
            this.panelCheckout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCheckout.Location = new System.Drawing.Point(0, 676);
            this.panelCheckout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelCheckout.Name = "panelCheckout";
            this.panelCheckout.Size = new System.Drawing.Size(640, 342);
            this.panelCheckout.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(18, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(589, 78);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清空購物車";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(11, 167);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(173, 36);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "應付總額: $0";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.Location = new System.Drawing.Point(11, 132);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(156, 36);
            this.lblTotalCount.TabIndex = 3;
            this.lblTotalCount.Text = "共 0 件商品";
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoSize = true;
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(18, 227);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(599, 82);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "前往結帳 ($0)";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.AutoScroll = true;
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(480, 125);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Padding = new System.Windows.Forms.Padding(53, 38, 13, 38);
            this.panelCenter.Size = new System.Drawing.Size(1033, 1018);
            this.panelCenter.TabIndex = 3;
            // 
            // FrmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2153, 1143);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeftBase);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panelToggleContainer.ResumeLayout(false);
            this.panelToggleSlider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelLeftBase.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelCart.ResumeLayout(false);
            this.panelCart.PerformLayout();
            this.panelCheckout.ResumeLayout(false);
            this.panelCheckout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelLeftBase;
        private System.Windows.Forms.FlowLayoutPanel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelCheckout;
        private System.Windows.Forms.FlowLayoutPanel panelCart;
        private System.Windows.Forms.FlowLayoutPanel panelCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnHome;
        private System.Windows.Forms.Panel panelToggleContainer;
        private System.Windows.Forms.Panel panelToggleSlider;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblToggleText;
        private Button btnCheckout;
        private Label lblGrandTotal;
        private Label lblTotalCount;
        private Button btnClear;
        private Label lblEmpty;
        private TextBox txtSearch;
        private Label lblSearch;
    }
}