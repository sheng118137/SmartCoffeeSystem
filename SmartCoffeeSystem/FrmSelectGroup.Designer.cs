namespace SmartCoffeeSystem
{
    partial class FrmSelectGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectGroup));
            this.cboExisting = new Sunny.UI.UIComboBox();
            this.txtNewGroup = new Sunny.UI.UITextBox();
            this.lblTitle1 = new Sunny.UI.UILabel();
            this.lblTitle2 = new Sunny.UI.UILabel();
            this.lblOr = new Sunny.UI.UILabel();
            this.btnOK = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // cboExisting
            // 
            this.cboExisting.DataSource = null;
            this.cboExisting.FillColor = System.Drawing.Color.White;
            this.cboExisting.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.cboExisting.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboExisting.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboExisting.Location = new System.Drawing.Point(40, 95);
            this.cboExisting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboExisting.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboExisting.Name = "cboExisting";
            this.cboExisting.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboExisting.Size = new System.Drawing.Size(420, 40);
            this.cboExisting.SymbolSize = 24;
            this.cboExisting.TabIndex = 1;
            this.cboExisting.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboExisting.Watermark = "請選擇...";
            // 
            // txtNewGroup
            // 
            this.txtNewGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewGroup.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtNewGroup.Location = new System.Drawing.Point(40, 220);
            this.txtNewGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewGroup.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNewGroup.Name = "txtNewGroup";
            this.txtNewGroup.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtNewGroup.ShowText = false;
            this.txtNewGroup.Size = new System.Drawing.Size(420, 40);
            this.txtNewGroup.TabIndex = 4;
            this.txtNewGroup.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNewGroup.Watermark = "若上方沒有可建立全新群組";
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle1.Location = new System.Drawing.Point(40, 60);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(200, 30);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "選擇資料庫現有群組：";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTitle2.Location = new System.Drawing.Point(40, 185);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(200, 30);
            this.lblTitle2.TabIndex = 3;
            this.lblTitle2.Text = "建立一個全新群組：";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOr
            // 
            this.lblOr.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.Color.Black;
            this.lblOr.Location = new System.Drawing.Point(-27, 140);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(560, 62);
            this.lblOr.TabIndex = 2;
            this.lblOr.Text = "或者 ";
            this.lblOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnOK.Location = new System.Drawing.Point(230, 290);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 40);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "確定綁定";
            this.btnOK.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnCancel.Location = new System.Drawing.Point(350, 290);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSelectGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 360);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNewGroup);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.cboExisting);
            this.Controls.Add(this.lblTitle1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectGroup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "綁定選項群組";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 500, 360);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox cboExisting;
        private Sunny.UI.UITextBox txtNewGroup;
        private Sunny.UI.UILabel lblTitle1;
        private Sunny.UI.UILabel lblTitle2;
        private Sunny.UI.UILabel lblOr;
        private Sunny.UI.UIButton btnOK;
        private Sunny.UI.UIButton btnCancel;
    }
}