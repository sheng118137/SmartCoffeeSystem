namespace SmartCoffeeSystem.View
{
    partial class UC_OrderCardView
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
            this.btnRefresh = new Sunny.UI.UIButton();
            this.lblTitle = new Sunny.UI.UILabel();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.flowLayoutPanelCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1050, 70);
            this.panelTop.Style = Sunny.UI.UIStyle.Custom;
            this.panelTop.TabIndex = 0;
            this.panelTop.Text = null;
            this.panelTop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(890, 15);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Radius = 10;
            this.btnRefresh.Size = new System.Drawing.Size(130, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "⟳ 手動更新";
            this.btnRefresh.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.SeaShell;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 35);
            this.lblTitle.Style = Sunny.UI.UIStyle.Custom;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "後廚製餐看板";
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.flowLayoutPanelCards.Controls.Add(this.lblEmpty);
            this.flowLayoutPanelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(1050, 580);
            this.flowLayoutPanelCards.TabIndex = 1;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold);
            this.lblEmpty.ForeColor = System.Drawing.Color.Silver;
            this.lblEmpty.Location = new System.Drawing.Point(23, 20);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(376, 40);
            this.lblEmpty.TabIndex = 0;
            this.lblEmpty.Text = "目前沒有等待中的訂單☕";
            // 
            // UC_OrderCardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.flowLayoutPanelCards);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_OrderCardView";
            this.Size = new System.Drawing.Size(1050, 650);
            this.Load += new System.EventHandler(this.UC_OrderCardView_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.flowLayoutPanelCards.ResumeLayout(false);
            this.flowLayoutPanelCards.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelTop;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIButton btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Label lblEmpty;
    }
}