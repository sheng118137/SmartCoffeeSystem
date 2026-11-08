namespace SmartCoffeeSystem
{
    partial class FrmCategoryEdit
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
            this.lblName = new Sunny.UI.UILabel();
            this.txtName = new Sunny.UI.UITextBox();
            this.lblIcon = new Sunny.UI.UILabel();
            this.flowLayoutPanelIcons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(30, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "分類名稱：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtName.Location = new System.Drawing.Point(120, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(340, 40);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "請輸入分類名稱";
            // 
            // lblIcon
            // 
            this.lblIcon.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblIcon.Location = new System.Drawing.Point(30, 105);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(100, 30);
            this.lblIcon.TabIndex = 2;
            this.lblIcon.Text = "專屬圖示：";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelIcons
            // 
            this.flowLayoutPanelIcons.AutoScroll = true;
            this.flowLayoutPanelIcons.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelIcons.Location = new System.Drawing.Point(34, 140);
            this.flowLayoutPanelIcons.Name = "flowLayoutPanelIcons";
            this.flowLayoutPanelIcons.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelIcons.Size = new System.Drawing.Size(426, 210);
            this.flowLayoutPanelIcons.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnOK.Location = new System.Drawing.Point(230, 370);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 5;
            this.btnOK.Size = new System.Drawing.Size(110, 40);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "確定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnCancel.Location = new System.Drawing.Point(350, 370);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 5;
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmCategoryEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.flowLayoutPanelIcons);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategoryEdit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "分類設定";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 500, 430);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel lblIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelIcons;
        private Sunny.UI.UIButton btnOK;
        private Sunny.UI.UIButton btnCancel;
    }
}