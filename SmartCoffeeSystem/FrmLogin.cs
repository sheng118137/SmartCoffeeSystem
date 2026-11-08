using BCrypt.Net;
using Sunny.UI;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net; // 取IP用的
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem
{
    public partial class FrmLogin : Form
    {
        private string currentCaptchaCode = "";
        // Coffee Theme 顏色設定
        private readonly Color panelColor = Color.FromArgb(238, 255, 255, 255);
        private readonly Color primaryColor = Color.FromArgb(111, 78, 55);
        private readonly Color primaryHover = Color.FromArgb(141, 110, 99);
        private readonly Color textColor = Color.FromArgb(55, 55, 55);
        private readonly Color hintColor = Color.Gray;
        private readonly Color lineColor = Color.Silver;
        private readonly Color errorRed = Color.FromArgb(220, 53, 69);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmLogin()
        {
            InitializeComponent();

            this.Shown += (s, e) =>
            {
                txtUsername.Select();
            };

            SetupCustomDynamicUI();
            GenerateCaptcha();
            CleanOldLoginLogs();
        }

        private void SetupCustomDynamicUI()
        {
            this.DoubleBuffered = true;
            this.MouseDown += Form_MouseDown;
            this.Resize += FrmLogin_Resize;
            this.BackgroundImage = Properties.Resources.login_bg;
            this.BackgroundImageLayout = ImageLayout.Zoom;

            loginPanel.BackColor = panelColor;
            loginPanel.MouseDown += Form_MouseDown;
            RoundPanel(loginPanel);

            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point((loginPanel.Width - lblSubtitle.PreferredWidth) / 2, 100);

            int logoHeight = 100;
            int logoWidth = (int)(logoHeight * 500 / 117.8);
            picLogo.Image = Properties.Resources.Logo;
            picLogo.Size = new Size(logoWidth, logoHeight);
            picLogo.Location = new Point((loginPanel.Width - picLogo.Width) / 3, 20);

            lblWelcome.ForeColor = primaryColor;
            lblUser.ForeColor = hintColor;
            txtUsername.Location = new Point(45, 170);
            txtUsername.Size = new Size(330, 32);
            txtUsername.ForeColor = textColor;

            pnlUserLine.Location = new Point(45, 202);
            pnlUserLine.Size = new Size(330, 2);
            pnlUserLine.BackColor = Color.Black;

            lblPass.ForeColor = hintColor;
            txtPassword.Size = new Size(330, 32);
            txtPassword.ForeColor = textColor;

            pnlPassLine.Size = new Size(330, 2);
            pnlPassLine.BackColor = lineColor;

            btnLogin.Size = new Size(330, 50);
            btnLogin.BackColor = primaryColor;
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;

            lblStatus.Size = new Size(330, 25);
            lblStatus.ForeColor = errorRed;

            btnExit.Size = new Size(35, 35);
            btnExit.BackColor = Color.Transparent;
            btnExit.ForeColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;

            txtUsername.Enter += (s, e) => pnlUserLine.BackColor = primaryColor;
            txtUsername.Leave += (s, e) => pnlUserLine.BackColor = lineColor;

            txtPassword.Enter += (s, e) => pnlPassLine.BackColor = primaryColor;
            txtPassword.Leave += (s, e) => pnlPassLine.BackColor = lineColor;

            txtVerification.Enter += (s, e) => panelVerificationLine.BackColor = primaryColor;
            txtVerification.Leave += (s, e) => panelVerificationLine.BackColor = lineColor;

            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = primaryHover;
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = primaryColor;
            btnLogin.Click += BtnLogin_Click;

            btnExit.MouseEnter += (s, e) => btnExit.ForeColor = Color.Red;
            btnExit.MouseLeave += (s, e) => btnExit.ForeColor = Color.White;
            btnExit.Click += (s, e) => Close();

            FrmLogin_Resize(null, null);
        }

        private void CleanOldLoginLogs()
        {
            try
            {
                using (var db = new POSContext())
                {
                    DateTime expireDate = DateTime.Now.AddDays(-30);
                    var oldLogs = db.LoginLogs.Where(l => l.AttemptTime < expireDate);
                    if (oldLogs.Any())
                    {
                        db.LoginLogs.RemoveRange(oldLogs);
                        db.SaveChanges();
                    }
                }
            }
            catch { }
        }

        private void GenerateCaptcha()
        {
            string chars = "23456789ABCDEFGHJKLMNPQRSTUVWXYZ";
            Random rand = new Random();
            currentCaptchaCode = "";

            for (int i = 0; i < 4; i++)
            {
                currentCaptchaCode += chars[rand.Next(chars.Length)];
            }

            Bitmap bmp = new Bitmap(327, 31);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                for (int i = 0; i < 30; i++)
                {
                    int x = rand.Next(bmp.Width);
                    int y = rand.Next(bmp.Height);
                    bmp.SetPixel(x, y, Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)));
                }

                for (int i = 0; i < 3; i++)
                {
                    Point p1 = new Point(rand.Next(bmp.Width), rand.Next(bmp.Height));
                    Point p2 = new Point(rand.Next(bmp.Width), rand.Next(bmp.Height));
                    g.DrawLine(Pens.Gray, p1, p2);
                }

                using (Font font = new Font("微軟正黑體", 24, FontStyle.Bold))
                {
                    float totalWidth = 0;
                    float[] charWidths = new float[currentCaptchaCode.Length];

                    for (int i = 0; i < currentCaptchaCode.Length; i++)
                    {
                        SizeF size = g.MeasureString(currentCaptchaCode[i].ToString(), font);
                        charWidths[i] = size.Width - 8;
                        totalWidth += charWidths[i];
                    }

                    float startX = (bmp.Width - totalWidth) / 2f;
                    float currentX = startX;

                    for (int i = 0; i < currentCaptchaCode.Length; i++)
                    {
                        Brush brush = new SolidBrush(Color.FromArgb(rand.Next(50, 150), rand.Next(50, 150), rand.Next(50, 150)));
                        float stringHeight = g.MeasureString(currentCaptchaCode[i].ToString(), font).Height;
                        float startY = (bmp.Height - stringHeight) / 2f + rand.Next(-2, 3);

                        g.DrawString(currentCaptchaCode[i].ToString(), font, brush, new PointF(currentX, startY));
                        currentX += charWidths[i];
                    }
                }
            }
            picCaptcha.Image = bmp;
        }

        private void picCaptcha_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            if (loginPanel != null)
                loginPanel.Location = new Point(this.ClientSize.Width - loginPanel.Width - 100, (this.ClientSize.Height - loginPanel.Height) / 2);

            if (btnExit != null)
                btnExit.Location = new Point(this.ClientSize.Width - 45, 15);
        }

        private void RoundPanel(Panel panel)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 60;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        private string GetClientIP()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
                foreach (var ip in ipEntry.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return ip.ToString();
                    }
                }
                return "127.0.0.1";
            }
            catch
            {
                return "127.0.0.1";
            }
        }

        private void WriteLoginLog(POSContext db, string username, string ip, string machineName, string status)
        {
            try
            {
                var log = new LoginLog
                {
                    Username = string.IsNullOrEmpty(username) ? "Unknown" : username,
                    AttemptTime = DateTime.Now,
                    IPAddress = ip,
                    MachineName = machineName,
                    Status = status
                };
                db.LoginLogs.Add(log);
                db.SaveChanges();
            }
            catch { }
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string clientIP = GetClientIP();
            string machineName = Environment.MachineName;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                lblStatus.Text = "ACCESS Failed: 請輸入完整憑證。";
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "驗證中...";
            lblStatus.Text = "";

            try
            {
                using (var db = new POSContext())
                {
                    DateTime tenMinutesAgo = DateTime.Now.AddMinutes(-10);
                    int recentFailCount = db.LoginLogs
                        .Count(l => l.IPAddress == clientIP && l.Status == "Failed" && l.AttemptTime >= tenMinutesAgo);

                    if (recentFailCount >= 10)
                    {
                        lblStatus.Text = "此IP嘗試失敗次數過多，已鎖定 10 分鐘。";
                        btnLogin.Text = "➔ 登入系統Login";
                        btnLogin.Enabled = true;
                        GenerateCaptcha();
                        return;
                    }

                    if (!txtVerification.Text.Trim().Equals(currentCaptchaCode, StringComparison.OrdinalIgnoreCase))
                    {
                        lblStatus.Text = "驗證碼錯誤";
                        WriteLoginLog(db, user, clientIP, machineName, "Failed");

                        btnLogin.Text = "➔ 登入系統Login";
                        btnLogin.Enabled = true;
                        txtVerification.Clear();
                        txtVerification.Focus();
                        GenerateCaptcha();
                        return;
                    }

                    var account = db.Accounts.ToList().FirstOrDefault(a => a.Accounts == user);

                    if (account == null || !BCrypt.Net.BCrypt.Verify(pass, account.PasswordHash))
                    {
                        lblStatus.Text = "認證失敗：未知的員工憑證或密碼錯誤。";
                        WriteLoginLog(db, user, clientIP, machineName, "Failed");

                        btnLogin.Text = "➔ 登入系統Login";
                        btnLogin.Enabled = true;
                        GenerateCaptcha();
                        return;
                    }

                    if (account.IsLocked)
                    {
                        lblStatus.Text = "登入失敗：此帳號已被停用或封鎖。";
                        WriteLoginLog(db, user, clientIP, machineName, "Failed");

                        btnLogin.Text = "➔ 登入系統Login";
                        btnLogin.Enabled = true;
                        return;
                    }

                    // 載入員工基本資料與 12 大權限
                    var employee = db.Employees.FirstOrDefault(s => s.EmployeeId == account.EmployeeId);
                    var permissionKeys = db.EmployeePermissions
                        .Where(p => p.EmployeeId == account.EmployeeId)
                        .Select(p => p.PermissionKey)
                        .ToList();

                    // 檢查權限：如果該員工只有前端 POS 系統權限（或者根本沒有任何後台管理權限），拒絕登入後台！

                    //後台必須至少擁有 Dashboard_Manage 或其他管理權限之一
                    bool hasAdminPermission = permissionKeys.Contains("Dashboard_Manage") ||
                                              permissionKeys.Contains("Product_CRUD") ||
                                              permissionKeys.Contains("Revenue_View") ||
                                              permissionKeys.Contains("Employee_CRUD") ||
                                              permissionKeys.Contains("Permission_CRUD");

                    if (!hasAdminPermission)
                    {
                        lblStatus.Text = "權限不足：此帳號僅限使用前端 POS 系統，無法登入後台。";
                        WriteLoginLog(db, user, clientIP, machineName, "Failed");
                        btnLogin.Text = "➔ 登入系統Login";
                        btnLogin.Enabled = true;
                        GenerateCaptcha();
                        return;
                    }

                    //寫入 Session 紀錄名字與權限
                    UserSession.EmployeeId = account.EmployeeId;
                    UserSession.Username = account.Accounts;
                    UserSession.EmployeeName = employee != null ? employee.EmployeeName : "未知員工";
                    UserSession.EmployeeTitle = employee != null ? employee.EmployeeTitle : "一般員工";
                    UserSession.Permissions = permissionKeys;

                    //寫成功 log
                    WriteLoginLog(db, user, clientIP, machineName, "Success");

                    await Task.Delay(100);
                    btnLogin.BackColor = Color.MediumSpringGreen;
                    btnLogin.Text = "授權成功";
                    await Task.Delay(100);

                    MessageBox.Show($"歡迎回來，{UserSession.EmployeeName} ({UserSession.EmployeeTitle})", "認證成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLogin.Text = "等待載入主選單...";

                    //隱藏登入視窗並開啟主選單
                    this.Hide();
                    using (FrmMainMenu mainMenu = new FrmMainMenu())
                    {
                        mainMenu.ShowDialog();
                    }

                    //當主選單關閉（代表使用者點擊登出）時，清空 Session 並重新顯示登入視窗
                    UserSession.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtVerification.Clear();
                    lblStatus.Text = "";
                    btnLogin.BackColor = primaryColor;
                    btnLogin.Text = "➔ 登入系統Login";
                    btnLogin.Enabled = true;
                    GenerateCaptcha();
                    this.Show();
                    txtUsername.Select();
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"系統發生錯誤：{ex.Message}";
                btnLogin.Text = "➔ ➔ 登入系統Login";
                btnLogin.Enabled = true;
            }
        }
    }
}