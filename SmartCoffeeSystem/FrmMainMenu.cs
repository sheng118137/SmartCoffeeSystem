using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Sunny.UI;

namespace SmartCoffeeSystem
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            AutoScaleToMonitor();

            SetupDynamicUI();

            // 綁定 Timer 事件
            timerClock.Tick += timerClock_Tick;
            timerClock.Interval = 1000;
            timerClock.Start();

            UpdateClock();

            //根據 UserSession 檢查權限，動態控制主選單按鈕的顯示/隱藏與提示
            ApplyMenuPermissions();

            showLoginButton();
        }

        private void showLoginButton()
        {
            if (UserSession.EmployeeName == "未知員工")
            {
                btnLogin.Text=("🔑登入帳號");
            }
            else
            {
                btnLogin.Text = ("🔑登出帳號");
            }
        }

        //根據權限動態控制按鈕顯示與歡迎詞
        private void ApplyMenuPermissions()
        {
            //檢查是否有前端 POS 系統權限
            bool canUsePOS = UserSession.HasPermission("POS_System");
            if (btnEnterPOS != null)
            {
                btnEnterPOS.Visible = canUsePOS;
            }

            //檢查是否有任何後台管理權限 (只要有以下其中一個即允許進入後台)
            bool canUseAdmin = UserSession.HasPermission("Dashboard_Manage") ||
                               UserSession.HasPermission("Product_CRUD") ||
                               UserSession.HasPermission("Revenue_View") ||
                               UserSession.HasPermission("Employee_CRUD") ||
                               UserSession.HasPermission("Permission_CRUD");

            if (btnEnterAdmin != null)
            {
                btnEnterAdmin.Visible = canUseAdmin;
            }
        }

        /// <summary>
        /// 更新系統時間
        /// </summary>
        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("yyyy/MM/dd  dddd  HH:mm:ss");
        }

        /// Timer 每秒更新一次
        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        // 導角函式
        private void ApplyRoundedCorners(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(control.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(control.Width - radius * 2, control.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, control.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }

        private void AutoScaleToMonitor()
        {
            Rectangle screen = Screen.PrimaryScreen.Bounds;

            float scaleX = (float)screen.Width / 1920f;
            float scaleY = (float)screen.Height / 1080f;

            if (scaleX == 1f && scaleY == 1f)
                return;

            this.Size = new Size(screen.Width, screen.Height);

            ScaleAllControls(this.Controls, scaleX, scaleY);
        }

        private void ScaleAllControls(Control.ControlCollection controls, float scaleX, float scaleY)
        {
            foreach (Control ctrl in controls)
            {
                ctrl.Left = (int)(ctrl.Left * scaleX);
                ctrl.Top = (int)(ctrl.Top * scaleY);
                ctrl.Width = (int)(ctrl.Width * scaleX);
                ctrl.Height = (int)(ctrl.Height * scaleY);

                if (ctrl.Font != null)
                {
                    float fontScale = Math.Min(scaleX, scaleY);

                    ctrl.Font = new Font(
                        ctrl.Font.FontFamily,
                        ctrl.Font.Size * fontScale,
                        ctrl.Font.Style);
                }

                if (ctrl.Controls.Count > 0)
                {
                    ScaleAllControls(ctrl.Controls, scaleX, scaleY);
                }
            }
        }


        private void SetupDynamicUI()
        {
            // 按鈕導角
            if (btnEnterPOS != null) ApplyRoundedCorners(btnEnterPOS, 20);
            if (btnEnterAdmin != null) ApplyRoundedCorners(btnEnterAdmin, 20);
            if (btnExit != null) ApplyRoundedCorners(btnExit, 15);
        }

        // 進入後台管理按鈕 (加上雙重權限攔截)
        private void btnEnterAdmin_Click_1(object sender, EventArgs e)
        {
            bool canUseAdmin = UserSession.HasPermission("Dashboard_Manage") ||
                               UserSession.HasPermission("Product_CRUD") ||
                               UserSession.HasPermission("Revenue_View") ||
                               UserSession.HasPermission("Employee_CRUD") ||
                               UserSession.HasPermission("Permission_CRUD");

            if (!canUseAdmin)
            {
                UIMessageBox.ShowWarning("權限不足！您的帳號無法進入後台管理系統。");
                return;
            }

            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.ShowDialog();
        }

        // 進入前台 POS 按鈕 (加上雙重權限攔截)
        private void btnEnterPOS_Click(object sender, EventArgs e)
        {
            if (!UserSession.HasPermission("POS_System"))
            {
                UIMessageBox.ShowWarning("權限不足！您的帳號沒有前端 POS 系統的授權。");
                return;
            }

            FrmPOS frmPOS = new FrmPOS();
            frmPOS.ShowDialog();
        }


        // 結束系統按鈕
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要結束整個系統？", "結束系統", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否確定要登出並切換帳號？", "登出系統", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close(); // 關閉主選單，FrmLogin 接收到控制權後會自動重新彈出
            }

        }
    }
}