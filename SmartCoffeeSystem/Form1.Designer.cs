namespace SmartCoffeeSystem
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAIResponse = new System.Windows.Forms.TextBox();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSendToAI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAIResponse
            // 
            this.txtAIResponse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAIResponse.Location = new System.Drawing.Point(6, 52);
            this.txtAIResponse.Multiline = true;
            this.txtAIResponse.Name = "txtAIResponse";
            this.txtAIResponse.ReadOnly = true;
            this.txtAIResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAIResponse.Size = new System.Drawing.Size(382, 295);
            this.txtAIResponse.TabIndex = 0;
            // 
            // txtUserInput
            // 
            this.txtUserInput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtUserInput.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserInput.Location = new System.Drawing.Point(6, 381);
            this.txtUserInput.Multiline = true;
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserInput.Size = new System.Drawing.Size(382, 43);
            this.txtUserInput.TabIndex = 1;
            // 
            // btnSendToAI
            // 
            this.btnSendToAI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendToAI.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendToAI.Location = new System.Drawing.Point(81, 454);
            this.btnSendToAI.Name = "btnSendToAI";
            this.btnSendToAI.Size = new System.Drawing.Size(241, 37);
            this.btnSendToAI.TabIndex = 2;
            this.btnSendToAI.Text = "✨ 送出給 AI 解析";
            this.btnSendToAI.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAIResponse);
            this.groupBox1.Controls.Add(this.btnSendToAI);
            this.groupBox1.Controls.Add(this.txtUserInput);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 520);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AI智能助理";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAIResponse;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSendToAI;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

