using Sunny.UI.Win32;

namespace SmartCoffeeSystem
{
    partial class FrmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.SystemPanel = new Sunny.UI.UIPanel();
            this.AccountPanel = new Sunny.UI.UIPanel();
            this.RevenuePanel = new Sunny.UI.UIPanel();
            this.MemberPanel = new Sunny.UI.UIPanel();
            this.PanelOrder = new Sunny.UI.UIPanel();
            this.PanelProducts = new Sunny.UI.UIPanel();
            this.panelLogo = new Sunny.UI.UIPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelHeader = new Sunny.UI.UIPanel();
            this.flowLayoutPanelBreadcrumb = new System.Windows.Forms.FlowLayoutPanel();
            this.lblClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.uiScrollBar1 = new Sunny.UI.UIScrollBar();
            this.panelDesktop = new Sunny.UI.UIPanel();
            this.SideBarControl = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.btnSQLBackup = new FontAwesome.Sharp.IconButton();
            this.btnLogSet = new FontAwesome.Sharp.IconButton();
            this.ibtnSystem = new FontAwesome.Sharp.IconButton();
            this.btnEmployee = new FontAwesome.Sharp.IconButton();
            this.btnAccountSet = new FontAwesome.Sharp.IconButton();
            this.btnPermission = new FontAwesome.Sharp.IconButton();
            this.ibtnAuth = new FontAwesome.Sharp.IconButton();
            this.ibtnrevenuetotal = new FontAwesome.Sharp.IconButton();
            this.ibtnrevenue = new FontAwesome.Sharp.IconButton();
            this.ibtnMemberLevel = new FontAwesome.Sharp.IconButton();
            this.ibtnMemberList = new FontAwesome.Sharp.IconButton();
            this.ibtnMember = new FontAwesome.Sharp.IconButton();
            this.ibtnOrderDetail = new FontAwesome.Sharp.IconButton();
            this.ibtnOrderList = new FontAwesome.Sharp.IconButton();
            this.ibtnOrder = new FontAwesome.Sharp.IconButton();
            this.btnProductOptional = new FontAwesome.Sharp.IconButton();
            this.btnAllProductsManager = new FontAwesome.Sharp.IconButton();
            this.ibtnProduct = new FontAwesome.Sharp.IconButton();
            this.ibtnHome = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelSidebar.SuspendLayout();
            this.SystemPanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            this.RevenuePanel.SuspendLayout();
            this.MemberPanel.SuspendLayout();
            this.PanelOrder.SuspendLayout();
            this.PanelProducts.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.AutoScrollMargin = new System.Drawing.Size(300, 0);
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.panelSidebar.Controls.Add(this.SystemPanel);
            this.panelSidebar.Controls.Add(this.ibtnSystem);
            this.panelSidebar.Controls.Add(this.AccountPanel);
            this.panelSidebar.Controls.Add(this.ibtnAuth);
            this.panelSidebar.Controls.Add(this.RevenuePanel);
            this.panelSidebar.Controls.Add(this.ibtnrevenue);
            this.panelSidebar.Controls.Add(this.MemberPanel);
            this.panelSidebar.Controls.Add(this.ibtnMember);
            this.panelSidebar.Controls.Add(this.PanelOrder);
            this.panelSidebar.Controls.Add(this.ibtnOrder);
            this.panelSidebar.Controls.Add(this.PanelProducts);
            this.panelSidebar.Controls.Add(this.ibtnProduct);
            this.panelSidebar.Controls.Add(this.ibtnHome);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSidebar.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 1080);
            this.panelSidebar.TabIndex = 0;
            // 
            // SystemPanel
            // 
            this.SystemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.SystemPanel.Controls.Add(this.btnSQLBackup);
            this.SystemPanel.Controls.Add(this.btnLogSet);
            this.SystemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SystemPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.SystemPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.SystemPanel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SystemPanel.Location = new System.Drawing.Point(0, 1029);
            this.SystemPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SystemPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.SystemPanel.Name = "SystemPanel";
            this.SystemPanel.Radius = 1;
            this.SystemPanel.RectColor = System.Drawing.Color.Transparent;
            this.SystemPanel.Size = new System.Drawing.Size(233, 100);
            this.SystemPanel.TabIndex = 24;
            this.SystemPanel.Text = null;
            this.SystemPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountPanel
            // 
            this.AccountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.AccountPanel.Controls.Add(this.btnEmployee);
            this.AccountPanel.Controls.Add(this.btnAccountSet);
            this.AccountPanel.Controls.Add(this.btnPermission);
            this.AccountPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.AccountPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.AccountPanel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AccountPanel.Location = new System.Drawing.Point(0, 829);
            this.AccountPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Radius = 1;
            this.AccountPanel.RectColor = System.Drawing.Color.Transparent;
            this.AccountPanel.Size = new System.Drawing.Size(233, 150);
            this.AccountPanel.TabIndex = 21;
            this.AccountPanel.Text = null;
            this.AccountPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RevenuePanel
            // 
            this.RevenuePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.RevenuePanel.Controls.Add(this.ibtnrevenuetotal);
            this.RevenuePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RevenuePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.RevenuePanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.RevenuePanel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RevenuePanel.Location = new System.Drawing.Point(0, 729);
            this.RevenuePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RevenuePanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.RevenuePanel.Name = "RevenuePanel";
            this.RevenuePanel.Radius = 1;
            this.RevenuePanel.RectColor = System.Drawing.Color.Transparent;
            this.RevenuePanel.Size = new System.Drawing.Size(233, 50);
            this.RevenuePanel.TabIndex = 20;
            this.RevenuePanel.Text = null;
            this.RevenuePanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemberPanel
            // 
            this.MemberPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.MemberPanel.Controls.Add(this.ibtnMemberLevel);
            this.MemberPanel.Controls.Add(this.ibtnMemberList);
            this.MemberPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.MemberPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.MemberPanel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MemberPanel.Location = new System.Drawing.Point(0, 579);
            this.MemberPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.MemberPanel.Name = "MemberPanel";
            this.MemberPanel.Radius = 1;
            this.MemberPanel.RectColor = System.Drawing.Color.Transparent;
            this.MemberPanel.Size = new System.Drawing.Size(233, 100);
            this.MemberPanel.TabIndex = 17;
            this.MemberPanel.Text = null;
            this.MemberPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelOrder
            // 
            this.PanelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.PanelOrder.Controls.Add(this.ibtnOrderDetail);
            this.PanelOrder.Controls.Add(this.ibtnOrderList);
            this.PanelOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.PanelOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.PanelOrder.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PanelOrder.Location = new System.Drawing.Point(0, 429);
            this.PanelOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelOrder.Name = "PanelOrder";
            this.PanelOrder.Radius = 1;
            this.PanelOrder.RectColor = System.Drawing.Color.Transparent;
            this.PanelOrder.Size = new System.Drawing.Size(233, 100);
            this.PanelOrder.TabIndex = 16;
            this.PanelOrder.Text = null;
            this.PanelOrder.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelProducts
            // 
            this.PanelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.PanelProducts.Controls.Add(this.btnProductOptional);
            this.PanelProducts.Controls.Add(this.btnAllProductsManager);
            this.PanelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.PanelProducts.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.PanelProducts.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PanelProducts.Location = new System.Drawing.Point(0, 279);
            this.PanelProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelProducts.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Radius = 1;
            this.PanelProducts.RectColor = System.Drawing.Color.Transparent;
            this.PanelProducts.Size = new System.Drawing.Size(233, 100);
            this.PanelProducts.TabIndex = 27;
            this.PanelProducts.Text = null;
            this.PanelProducts.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(33)))), ((int)(((byte)(21)))));
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.lblUserName);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.iconPictureBox1);
            this.panelLogo.Controls.Add(this.label4);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.FillColor = System.Drawing.Color.Transparent;
            this.panelLogo.FillColor2 = System.Drawing.Color.Transparent;
            this.panelLogo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Radius = 0;
            this.panelLogo.RectColor = System.Drawing.Color.Transparent;
            this.panelLogo.Size = new System.Drawing.Size(233, 179);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Text = null;
            this.panelLogo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(106, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "線上";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.LightGray;
            this.lblUserName.Location = new System.Drawing.Point(44, 120);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(154, 22);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Admin\r\n";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "咖啡廳管理系統";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(79, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 42);
            this.label4.TabIndex = 2;
            this.label4.Text = "●";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.flowLayoutPanelBreadcrumb);
            this.panelHeader.Controls.Add(this.SideBarControl);
            this.panelHeader.Controls.Add(this.lblClock);
            this.panelHeader.Controls.Add(this.iconPictureBox2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.White;
            this.panelHeader.FillColor2 = System.Drawing.Color.White;
            this.panelHeader.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelHeader.Location = new System.Drawing.Point(250, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.RectColor = System.Drawing.Color.Transparent;
            this.panelHeader.Size = new System.Drawing.Size(1670, 60);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Text = null;
            this.panelHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelBreadcrumb
            // 
            this.flowLayoutPanelBreadcrumb.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelBreadcrumb.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelBreadcrumb.Location = new System.Drawing.Point(50, 0);
            this.flowLayoutPanelBreadcrumb.Name = "flowLayoutPanelBreadcrumb";
            this.flowLayoutPanelBreadcrumb.Size = new System.Drawing.Size(576, 60);
            this.flowLayoutPanelBreadcrumb.TabIndex = 4;
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClock.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(1305, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(300, 60);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "2026/07/16 星期四 14:30:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiScrollBar1
            // 
            this.uiScrollBar1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiScrollBar1.Location = new System.Drawing.Point(262, 610);
            this.uiScrollBar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiScrollBar1.Name = "uiScrollBar1";
            this.uiScrollBar1.Size = new System.Drawing.Size(19, 300);
            this.uiScrollBar1.TabIndex = 0;
            this.uiScrollBar1.Text = "uiScrollBar1";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelDesktop.Location = new System.Drawing.Point(250, 60);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDesktop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Radius = 10;
            this.panelDesktop.RectColor = System.Drawing.Color.Transparent;
            this.panelDesktop.Size = new System.Drawing.Size(1670, 1020);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Text = null;
            this.panelDesktop.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SideBarControl
            // 
            this.SideBarControl.BackColor = System.Drawing.Color.Transparent;
            this.SideBarControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SideBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarControl.FlatAppearance.BorderSize = 0;
            this.SideBarControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SideBarControl.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.SideBarControl.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(38)))), ((int)(((byte)(32)))));
            this.SideBarControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SideBarControl.IconSize = 50;
            this.SideBarControl.Location = new System.Drawing.Point(0, 0);
            this.SideBarControl.Name = "SideBarControl";
            this.SideBarControl.Size = new System.Drawing.Size(50, 60);
            this.SideBarControl.TabIndex = 0;
            this.SideBarControl.UseVisualStyleBackColor = false;
            this.SideBarControl.Click += new System.EventHandler(this.SideBarControl_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 60;
            this.iconPictureBox2.Location = new System.Drawing.Point(1605, 0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(65, 60);
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // btnSQLBackup
            // 
            this.btnSQLBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnSQLBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSQLBackup.FlatAppearance.BorderSize = 0;
            this.btnSQLBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSQLBackup.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.btnSQLBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.btnSQLBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnSQLBackup.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSQLBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSQLBackup.IconSize = 32;
            this.btnSQLBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSQLBackup.Location = new System.Drawing.Point(0, 50);
            this.btnSQLBackup.Name = "btnSQLBackup";
            this.btnSQLBackup.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSQLBackup.Size = new System.Drawing.Size(233, 50);
            this.btnSQLBackup.TabIndex = 4;
            this.btnSQLBackup.Text = "        資料備份";
            this.btnSQLBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSQLBackup.UseVisualStyleBackColor = false;
            this.btnSQLBackup.Click += new System.EventHandler(this.btnSQLBackup_Click);
            // 
            // btnLogSet
            // 
            this.btnLogSet.BackColor = System.Drawing.Color.Transparent;
            this.btnLogSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogSet.FlatAppearance.BorderSize = 0;
            this.btnLogSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogSet.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.btnLogSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.btnLogSet.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btnLogSet.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogSet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogSet.IconSize = 32;
            this.btnLogSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogSet.Location = new System.Drawing.Point(0, 0);
            this.btnLogSet.Name = "btnLogSet";
            this.btnLogSet.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnLogSet.Size = new System.Drawing.Size(233, 50);
            this.btnLogSet.TabIndex = 5;
            this.btnLogSet.Text = "        登入日誌";
            this.btnLogSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogSet.UseVisualStyleBackColor = false;
            this.btnLogSet.Click += new System.EventHandler(this.btnLogSet_Click);
            // 
            // ibtnSystem
            // 
            this.ibtnSystem.BackColor = System.Drawing.Color.Transparent;
            this.ibtnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnSystem.FlatAppearance.BorderSize = 0;
            this.ibtnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSystem.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnSystem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnSystem.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnSystem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSystem.IconSize = 32;
            this.ibtnSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSystem.Location = new System.Drawing.Point(0, 979);
            this.ibtnSystem.Name = "ibtnSystem";
            this.ibtnSystem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnSystem.Size = new System.Drawing.Size(233, 50);
            this.ibtnSystem.TabIndex = 23;
            this.ibtnSystem.Text = "系統設定";
            this.ibtnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSystem.UseVisualStyleBackColor = false;
            this.ibtnSystem.Click += new System.EventHandler(this.ibtnSystem_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.btnEmployee.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnEmployee.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployee.IconSize = 32;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 100);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEmployee.Size = new System.Drawing.Size(233, 50);
            this.btnEmployee.TabIndex = 5;
            this.btnEmployee.Text = "        員工資料";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnAccountSet
            // 
            this.btnAccountSet.BackColor = System.Drawing.Color.Transparent;
            this.btnAccountSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountSet.FlatAppearance.BorderSize = 0;
            this.btnAccountSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSet.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.btnAccountSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.btnAccountSet.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnAccountSet.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAccountSet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccountSet.IconSize = 32;
            this.btnAccountSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSet.Location = new System.Drawing.Point(0, 50);
            this.btnAccountSet.Name = "btnAccountSet";
            this.btnAccountSet.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAccountSet.Size = new System.Drawing.Size(233, 50);
            this.btnAccountSet.TabIndex = 4;
            this.btnAccountSet.Text = "        帳號設定";
            this.btnAccountSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSet.UseVisualStyleBackColor = false;
            this.btnAccountSet.Click += new System.EventHandler(this.btnAccountSet_Click);
            // 
            // btnPermission
            // 
            this.btnPermission.BackColor = System.Drawing.Color.Transparent;
            this.btnPermission.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPermission.FlatAppearance.BorderSize = 0;
            this.btnPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermission.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.btnPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.btnPermission.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnPermission.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPermission.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPermission.IconSize = 32;
            this.btnPermission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermission.Location = new System.Drawing.Point(0, 0);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnPermission.Size = new System.Drawing.Size(233, 50);
            this.btnPermission.TabIndex = 3;
            this.btnPermission.Text = "        權限設定";
            this.btnPermission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermission.UseVisualStyleBackColor = false;
            this.btnPermission.Click += new System.EventHandler(this.btnPermission_Click);
            // 
            // ibtnAuth
            // 
            this.ibtnAuth.BackColor = System.Drawing.Color.Transparent;
            this.ibtnAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnAuth.FlatAppearance.BorderSize = 0;
            this.ibtnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAuth.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnAuth.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnAuth.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnAuth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAuth.IconSize = 32;
            this.ibtnAuth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAuth.Location = new System.Drawing.Point(0, 779);
            this.ibtnAuth.Name = "ibtnAuth";
            this.ibtnAuth.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnAuth.Size = new System.Drawing.Size(233, 50);
            this.ibtnAuth.TabIndex = 22;
            this.ibtnAuth.Text = "權限管理";
            this.ibtnAuth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAuth.UseVisualStyleBackColor = false;
            this.ibtnAuth.Click += new System.EventHandler(this.ibtnAuth_Click);
            // 
            // ibtnrevenuetotal
            // 
            this.ibtnrevenuetotal.BackColor = System.Drawing.Color.Transparent;
            this.ibtnrevenuetotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnrevenuetotal.FlatAppearance.BorderSize = 0;
            this.ibtnrevenuetotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnrevenuetotal.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.ibtnrevenuetotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnrevenuetotal.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.ibtnrevenuetotal.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnrevenuetotal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnrevenuetotal.IconSize = 32;
            this.ibtnrevenuetotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnrevenuetotal.Location = new System.Drawing.Point(0, 0);
            this.ibtnrevenuetotal.Name = "ibtnrevenuetotal";
            this.ibtnrevenuetotal.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ibtnrevenuetotal.Size = new System.Drawing.Size(233, 50);
            this.ibtnrevenuetotal.TabIndex = 3;
            this.ibtnrevenuetotal.Text = "        營收總覽";
            this.ibtnrevenuetotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnrevenuetotal.UseVisualStyleBackColor = false;
            this.ibtnrevenuetotal.Click += new System.EventHandler(this.ibtnrevenuetotal_Click);
            // 
            // ibtnrevenue
            // 
            this.ibtnrevenue.BackColor = System.Drawing.Color.Transparent;
            this.ibtnrevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnrevenue.FlatAppearance.BorderSize = 0;
            this.ibtnrevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnrevenue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnrevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnrevenue.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnrevenue.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnrevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnrevenue.IconSize = 32;
            this.ibtnrevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnrevenue.Location = new System.Drawing.Point(0, 679);
            this.ibtnrevenue.Name = "ibtnrevenue";
            this.ibtnrevenue.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnrevenue.Size = new System.Drawing.Size(233, 50);
            this.ibtnrevenue.TabIndex = 21;
            this.ibtnrevenue.Text = "營收管理";
            this.ibtnrevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnrevenue.UseVisualStyleBackColor = false;
            this.ibtnrevenue.Click += new System.EventHandler(this.ibtnrevenue_Click);
            // 
            // ibtnMemberLevel
            // 
            this.ibtnMemberLevel.BackColor = System.Drawing.Color.Transparent;
            this.ibtnMemberLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnMemberLevel.FlatAppearance.BorderSize = 0;
            this.ibtnMemberLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMemberLevel.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.ibtnMemberLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnMemberLevel.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibtnMemberLevel.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMemberLevel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMemberLevel.IconSize = 32;
            this.ibtnMemberLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMemberLevel.Location = new System.Drawing.Point(0, 50);
            this.ibtnMemberLevel.Name = "ibtnMemberLevel";
            this.ibtnMemberLevel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ibtnMemberLevel.Size = new System.Drawing.Size(233, 50);
            this.ibtnMemberLevel.TabIndex = 4;
            this.ibtnMemberLevel.Text = "        會員等級管理";
            this.ibtnMemberLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMemberLevel.UseVisualStyleBackColor = false;
            this.ibtnMemberLevel.Click += new System.EventHandler(this.ibtnMemberLevel_Click);
            // 
            // ibtnMemberList
            // 
            this.ibtnMemberList.BackColor = System.Drawing.Color.Transparent;
            this.ibtnMemberList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnMemberList.FlatAppearance.BorderSize = 0;
            this.ibtnMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMemberList.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.ibtnMemberList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnMemberList.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.ibtnMemberList.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMemberList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMemberList.IconSize = 32;
            this.ibtnMemberList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMemberList.Location = new System.Drawing.Point(0, 0);
            this.ibtnMemberList.Name = "ibtnMemberList";
            this.ibtnMemberList.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ibtnMemberList.Size = new System.Drawing.Size(233, 50);
            this.ibtnMemberList.TabIndex = 3;
            this.ibtnMemberList.Text = "        會員列表";
            this.ibtnMemberList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMemberList.UseVisualStyleBackColor = false;
            this.ibtnMemberList.Click += new System.EventHandler(this.ibtnMemberList_Click);
            // 
            // ibtnMember
            // 
            this.ibtnMember.BackColor = System.Drawing.Color.Transparent;
            this.ibtnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnMember.FlatAppearance.BorderSize = 0;
            this.ibtnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMember.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnMember.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnMember.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMember.IconSize = 32;
            this.ibtnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMember.Location = new System.Drawing.Point(0, 529);
            this.ibtnMember.Name = "ibtnMember";
            this.ibtnMember.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnMember.Size = new System.Drawing.Size(233, 50);
            this.ibtnMember.TabIndex = 19;
            this.ibtnMember.Text = "會員管理";
            this.ibtnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMember.UseVisualStyleBackColor = false;
            this.ibtnMember.Click += new System.EventHandler(this.ibtnMember_Click);
            // 
            // ibtnOrderDetail
            // 
            this.ibtnOrderDetail.BackColor = System.Drawing.Color.Transparent;
            this.ibtnOrderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnOrderDetail.FlatAppearance.BorderSize = 0;
            this.ibtnOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOrderDetail.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.ibtnOrderDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnOrderDetail.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.ibtnOrderDetail.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnOrderDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOrderDetail.IconSize = 32;
            this.ibtnOrderDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrderDetail.Location = new System.Drawing.Point(0, 50);
            this.ibtnOrderDetail.Name = "ibtnOrderDetail";
            this.ibtnOrderDetail.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ibtnOrderDetail.Size = new System.Drawing.Size(233, 50);
            this.ibtnOrderDetail.TabIndex = 4;
            this.ibtnOrderDetail.Text = "        訂單狀態管理";
            this.ibtnOrderDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrderDetail.UseVisualStyleBackColor = false;
            this.ibtnOrderDetail.Click += new System.EventHandler(this.ibtnOrderDetail_Click);
            // 
            // ibtnOrderList
            // 
            this.ibtnOrderList.BackColor = System.Drawing.Color.Transparent;
            this.ibtnOrderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnOrderList.FlatAppearance.BorderSize = 0;
            this.ibtnOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOrderList.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.ibtnOrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnOrderList.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ibtnOrderList.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnOrderList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOrderList.IconSize = 32;
            this.ibtnOrderList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrderList.Location = new System.Drawing.Point(0, 0);
            this.ibtnOrderList.Name = "ibtnOrderList";
            this.ibtnOrderList.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ibtnOrderList.Size = new System.Drawing.Size(233, 50);
            this.ibtnOrderList.TabIndex = 3;
            this.ibtnOrderList.Text = "        訂單列表";
            this.ibtnOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrderList.UseVisualStyleBackColor = false;
            this.ibtnOrderList.Click += new System.EventHandler(this.ibtnOrderList_Click);
            // 
            // ibtnOrder
            // 
            this.ibtnOrder.BackColor = System.Drawing.Color.Transparent;
            this.ibtnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnOrder.FlatAppearance.BorderSize = 0;
            this.ibtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOrder.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnOrder.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOrder.IconSize = 32;
            this.ibtnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrder.Location = new System.Drawing.Point(0, 379);
            this.ibtnOrder.Name = "ibtnOrder";
            this.ibtnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnOrder.Size = new System.Drawing.Size(233, 50);
            this.ibtnOrder.TabIndex = 14;
            this.ibtnOrder.Text = "訂單管理";
            this.ibtnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrder.UseVisualStyleBackColor = false;
            this.ibtnOrder.Click += new System.EventHandler(this.ibtnOrder_Click);
            // 
            // btnProductOptional
            // 
            this.btnProductOptional.BackColor = System.Drawing.Color.Transparent;
            this.btnProductOptional.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductOptional.FlatAppearance.BorderSize = 0;
            this.btnProductOptional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductOptional.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.btnProductOptional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.btnProductOptional.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnProductOptional.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProductOptional.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductOptional.IconSize = 32;
            this.btnProductOptional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductOptional.Location = new System.Drawing.Point(0, 50);
            this.btnProductOptional.Name = "btnProductOptional";
            this.btnProductOptional.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnProductOptional.Size = new System.Drawing.Size(233, 50);
            this.btnProductOptional.TabIndex = 4;
            this.btnProductOptional.Text = "        商品選項自訂";
            this.btnProductOptional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductOptional.UseVisualStyleBackColor = false;
            this.btnProductOptional.Click += new System.EventHandler(this.btnProductOptional_Click);
            // 
            // btnAllProductsManager
            // 
            this.btnAllProductsManager.BackColor = System.Drawing.Color.Transparent;
            this.btnAllProductsManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllProductsManager.FlatAppearance.BorderSize = 0;
            this.btnAllProductsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProductsManager.Font = new System.Drawing.Font("微软雅黑", 13.25F, System.Drawing.FontStyle.Bold);
            this.btnAllProductsManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.btnAllProductsManager.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnAllProductsManager.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAllProductsManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllProductsManager.IconSize = 32;
            this.btnAllProductsManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllProductsManager.Location = new System.Drawing.Point(0, 0);
            this.btnAllProductsManager.Name = "btnAllProductsManager";
            this.btnAllProductsManager.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAllProductsManager.Size = new System.Drawing.Size(233, 50);
            this.btnAllProductsManager.TabIndex = 3;
            this.btnAllProductsManager.Text = "        商品列表";
            this.btnAllProductsManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllProductsManager.UseVisualStyleBackColor = false;
            this.btnAllProductsManager.Click += new System.EventHandler(this.btnAllProductsManager_Click);
            // 
            // ibtnProduct
            // 
            this.ibtnProduct.BackColor = System.Drawing.Color.Transparent;
            this.ibtnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnProduct.FlatAppearance.BorderSize = 0;
            this.ibtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProduct.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProduct.IconSize = 32;
            this.ibtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProduct.Location = new System.Drawing.Point(0, 229);
            this.ibtnProduct.Name = "ibtnProduct";
            this.ibtnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnProduct.Size = new System.Drawing.Size(233, 50);
            this.ibtnProduct.TabIndex = 2;
            this.ibtnProduct.Text = "商品管理";
            this.ibtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProduct.UseVisualStyleBackColor = false;
            this.ibtnProduct.Click += new System.EventHandler(this.ibtnProduct_Click);
            // 
            // ibtnHome
            // 
            this.ibtnHome.BackColor = System.Drawing.Color.Transparent;
            this.ibtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnHome.FlatAppearance.BorderSize = 0;
            this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHome.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(200)))), ((int)(((byte)(196)))));
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHome.IconSize = 32;
            this.ibtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.Location = new System.Drawing.Point(0, 179);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnHome.Size = new System.Drawing.Size(233, 50);
            this.ibtnHome.TabIndex = 15;
            this.ibtnHome.Text = "首頁";
            this.ibtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.UseVisualStyleBackColor = false;
            this.ibtnHome.Click += new System.EventHandler(this.ibtnHome_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MugHot;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 80;
            this.iconPictureBox1.Location = new System.Drawing.Point(77, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(81, 80);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panelSidebar.ResumeLayout(false);
            this.SystemPanel.ResumeLayout(false);
            this.AccountPanel.ResumeLayout(false);
            this.RevenuePanel.ResumeLayout(false);
            this.MemberPanel.ResumeLayout(false);
            this.PanelOrder.ResumeLayout(false);
            this.PanelProducts.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private Sunny.UI.UIPanel panelHeader;
        private Sunny.UI.UIPanel panelLogo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerClock;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton ibtnOrder;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private Sunny.UI.UIPanel PanelOrder;
        private FontAwesome.Sharp.IconButton ibtnOrderList;
        private FontAwesome.Sharp.IconButton ibtnOrderDetail;
        private FontAwesome.Sharp.IconButton ibtnMember;
        private Sunny.UI.UIPanel MemberPanel;
        private FontAwesome.Sharp.IconButton ibtnMemberLevel;
        private FontAwesome.Sharp.IconButton ibtnMemberList;
        private Sunny.UI.UIPanel RevenuePanel;
        private FontAwesome.Sharp.IconButton ibtnrevenuetotal;
        private FontAwesome.Sharp.IconButton ibtnrevenue;
        private Sunny.UI.UIPanel AccountPanel;
        private FontAwesome.Sharp.IconButton btnAccountSet;
        private FontAwesome.Sharp.IconButton btnPermission;
        private FontAwesome.Sharp.IconButton ibtnAuth;
        private FontAwesome.Sharp.IconButton ibtnSystem;
        private Sunny.UI.UIPanel SystemPanel;
        private FontAwesome.Sharp.IconButton btnSQLBackup;
        private FontAwesome.Sharp.IconButton btnEmployee;
        private Sunny.UI.UIScrollBar uiScrollBar1;
        private FontAwesome.Sharp.IconButton SideBarControl;
        private Sunny.UI.UIPanel panelDesktop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBreadcrumb;
        private Sunny.UI.UIPanel PanelProducts;
        private FontAwesome.Sharp.IconButton btnProductOptional;
        private FontAwesome.Sharp.IconButton btnAllProductsManager;
        private FontAwesome.Sharp.IconButton ibtnProduct;
        private FontAwesome.Sharp.IconButton btnLogSet;
    }
}