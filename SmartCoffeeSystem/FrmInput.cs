using Sunny.UI;
using System;
using System.Windows.Forms;

namespace SmartCoffeeSystem
{
    public partial class FrmInput : UIForm
    {
        //使用者輸入的結果
        public string InputText { get; private set; }

        public FrmInput(string title, string description, string defaultText = "")
        {
            InitializeComponent();

            this.Text = title;              // 設定視窗標題
            lblDesc.Text = description;     // 設定提示文字
            txtInput.Text = defaultText;    // 設定預設輸入的文字

            // 綁定按鈕事件
            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;

            //存檔快捷
            txtInput.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BtnOK_Click(null, null);
                }
            };
        }

        private void FrmInput_Load(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //不允許完全空白
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                UIMessageBox.ShowWarning("內容不能為空白！");
                return;
            }

            InputText = txtInput.Text.Trim(); // 存入公開屬性
            this.DialogResult = DialogResult.OK; // 回傳 OK 給呼叫的表單
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}