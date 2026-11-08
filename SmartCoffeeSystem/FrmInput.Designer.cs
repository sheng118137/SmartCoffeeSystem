namespace SmartCoffeeSystem
{
    partial class FrmInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInput));
            this.txtInput = new Sunny.UI.UITextBox();
            this.lblDesc = new Sunny.UI.UILabel();
            this.btnOK = new Sunny.UI.UIButton();
            this.btnCancel = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.txtInput.Location = new System.Drawing.Point(40, 127);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtInput.ShowText = false;
            this.txtInput.Size = new System.Drawing.Size(420, 40);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInput.Watermark = "請輸入內容";
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblDesc.Location = new System.Drawing.Point(40, 48);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(420, 74);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "提示說明文字";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnOK.Location = new System.Drawing.Point(230, 175);
            this.btnOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 40);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "確定";
            this.btnOK.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnCancel.Location = new System.Drawing.Point(350, 175);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 40);
            this.btnCancel.Style = Sunny.UI.UIStyle.Custom;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // FrmInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 240);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInput";
            this.ShowInTaskbar = false;
            this.Text = "輸入對話框";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 500, 240);
            this.Load += new System.EventHandler(this.FrmInput_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox txtInput;
        private Sunny.UI.UILabel lblDesc;
        private Sunny.UI.UIButton btnOK;
        private Sunny.UI.UIButton btnCancel;
    }
}