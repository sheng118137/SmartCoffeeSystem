namespace SmartCoffeeSystem.View
{
    partial class UC_OrderCard
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
            this.panelMain = new Sunny.UI.UIPanel();
            this.flpDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.btnComplete = new Sunny.UI.UIButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flpDetails);
            this.panelMain.Controls.Add(this.btnComplete);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelMain.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelMain.Location = new System.Drawing.Point(5, 5);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Radius = 15;
            this.panelMain.RectColor = System.Drawing.Color.Silver;
            this.panelMain.Size = new System.Drawing.Size(260, 210);
            this.panelMain.TabIndex = 0;
            this.panelMain.Text = null;
            this.panelMain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpDetails
            // 
            this.flpDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.flpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDetails.Location = new System.Drawing.Point(0, 50);
            this.flpDetails.Name = "flpDetails";
            this.flpDetails.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.flpDetails.Size = new System.Drawing.Size(260, 110);
            this.flpDetails.TabIndex = 2;
            this.flpDetails.WrapContents = false;
            // 
            // btnComplete
            // 
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnComplete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnComplete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(210)))), ((int)(((byte)(60)))));
            this.btnComplete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(20)))));
            this.btnComplete.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.btnComplete.Location = new System.Drawing.Point(0, 160);
            this.btnComplete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Radius = 0;
            this.btnComplete.RectColor = System.Drawing.Color.Transparent;
            this.btnComplete.Size = new System.Drawing.Size(260, 50);
            this.btnComplete.Style = Sunny.UI.UIStyle.Custom;
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "✓ 完成製餐";
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelTop.Controls.Add(this.lblTime);
            this.panelTop.Controls.Add(this.lblOrderType);
            this.panelTop.Controls.Add(this.lblOrderID);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(260, 50);
            this.panelTop.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTime.Location = new System.Drawing.Point(198, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "14:30";
            // 
            // lblOrderType
            // 
            this.lblOrderType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblOrderType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderType.ForeColor = System.Drawing.Color.White;
            this.lblOrderType.Location = new System.Drawing.Point(111, 10);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(60, 30);
            this.lblOrderType.TabIndex = 1;
            this.lblOrderType.Text = "內用";
            this.lblOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(10, 10);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(76, 29);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "# 001";
            // 
            // UC_OrderCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Name = "UC_OrderCard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(270, 220);
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblOrderID;
        private Sunny.UI.UIButton btnComplete;
        private System.Windows.Forms.FlowLayoutPanel flpDetails;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblOrderType;
    }
}