using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Sunny.UI;
using System.Security.Cryptography.X509Certificates;
using SmartCoffeeSystem.View;

namespace SmartCoffeeSystem
{
    public partial class FrmAdmin : Form
    {
        private FontAwesome.Sharp.IconButton currentBtn;
        bool SideBarShow = true;

        // 用來記錄目前到哪個頁面避免記憶體洩漏
        private UserControl currentChildForm;

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // 時鐘設定
            timerClock.Tick += timerClock_Tick;
            timerClock.Interval = 1000;
            timerClock.Start();
            UpdateClock();
            lblUserName.Text =$"{UserSession.EmployeeName} {UserSession.EmployeeTitle}";
            // 隱藏細項按鈕
            CustomizeDesign();

            //根據目前登入者的權限，動態隱藏沒有權限的側邊欄按鈕
            ApplyPermissionUIVisibility();

            // 連線診斷
            var (ok, msg) = DBHelper.TestSqlConnection();
            if (!ok)
            {
                MessageBox.Show("資料庫連線失敗：\n" + msg, "資料庫錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 程式啟動載入首頁並產生首頁麵包屑
            GoHome();
        }

        //根據權限動態隱藏側邊欄按鈕與分類選單
        private void ApplyPermissionUIVisibility()
        {
            // 檢查各個功能按鈕的權限，沒有權限就直接設為 Visible = false

            // 2. 商品 CRUD
            bool canProduct = UserSession.HasPermission("Product_CRUD");
            if (btnAllProductsManager != null) btnAllProductsManager.Visible = canProduct;

            // 3. 商品選項 CRUD
            bool canOption = UserSession.HasPermission("ProductOption_CRUD");
            if (btnProductOptional != null) btnProductOptional.Visible = canOption;

            // 如果商品相關的子按鈕都沒權限，把整組商品分類主按鈕隱藏
            if (ibtnProduct != null) ibtnProduct.Visible = (canProduct || canOption);


            // 4. 會員列表 CRUD
            bool canMemberList = UserSession.HasPermission("Member_CRUD");
            if (ibtnMemberList != null) ibtnMemberList.Visible = canMemberList;

            // 5. 會員等級 CRUD
            bool canMemberLevel = UserSession.HasPermission("MemberLevel_CRUD");
            if (ibtnMemberLevel != null) ibtnMemberLevel.Visible = canMemberLevel;

            if (ibtnMember != null) ibtnMember.Visible = (canMemberList || canMemberLevel);


            // 6. 營收總覽
            bool canRevenue = UserSession.HasPermission("Revenue_View");
            if (ibtnrevenuetotal != null) ibtnrevenuetotal.Visible = canRevenue;
            if (ibtnrevenue != null) ibtnrevenue.Visible = canRevenue;


            // 7. 訂單管理 (對應 POS_System 與 Dashboard)
            bool canPOS = UserSession.HasPermission("POS_System");
            bool canDash = UserSession.HasPermission("Dashboard_Manage");
            if (ibtnOrderList != null) ibtnOrderList.Visible = canPOS;
            if (ibtnOrderDetail != null) ibtnOrderDetail.Visible = canDash;
            if (ibtnOrder != null) ibtnOrder.Visible = (canPOS || canDash);


            // 8. 權限設定 CRUD, 9. 員工資料 CRUD, 10. 帳號設定 CRUD
            bool canPermission = UserSession.HasPermission("Permission_CRUD");
            bool canEmployee = UserSession.HasPermission("Employee_CRUD");
            bool canAccount = UserSession.HasPermission("Account_CRUD");
            if (btnPermission != null) btnPermission.Visible = canPermission;
            if (btnEmployee != null) btnEmployee.Visible = canEmployee;
            if (btnAccountSet != null) btnAccountSet.Visible = canAccount;
            if (ibtnAuth != null) ibtnAuth.Visible = (canPermission || canEmployee || canAccount);


            // 11. 登入日誌, 12. 資料庫備份
            bool canLog = UserSession.HasPermission("LoginLog_View");
            bool canBackup = UserSession.HasPermission("Database_Backup");
            if (btnLogSet != null) btnLogSet.Visible = canLog;
            if (btnSQLBackup != null) btnSQLBackup.Visible = canBackup;
            if (ibtnSystem != null) ibtnSystem.Visible = (canLog || canBackup);
        }

        // 開啟頁面並支援權限檢查 (雙重防護：即使被呼叫也再次攔截)
        public void OpenPageWithPermission(UserControl targetUC, Dictionary<string, Action> breadcrumbs, string permissionKey)
        {
            if (!string.IsNullOrEmpty(permissionKey) && !UserSession.HasPermission(permissionKey))
            {
                UIMessageBox.ShowWarning("權限不足！您沒有存取此功能的權限。");
                return;
            }

            if (currentChildForm != null)
            {
                panelDesktop.Controls.Remove(currentChildForm);
                currentChildForm.Dispose();
            }

            currentChildForm = targetUC;

            targetUC.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(targetUC);
            targetUC.BringToFront();
            targetUC.Show();

            flowLayoutPanelBreadcrumb.Controls.Clear();
            flowLayoutPanelBreadcrumb.Padding = new Padding(10, 16, 0, 0);
            flowLayoutPanelBreadcrumb.WrapContents = false;

            int count = 0;
            int total = breadcrumbs.Count;

            foreach (var node in breadcrumbs)
            {
                count++;

                UILinkLabel link = new UILinkLabel();
                link.Text = node.Key;
                link.AutoSize = true;
                link.Margin = new Padding(0);

                if (count == total)
                {
                    link.Font = new Font("微軟正黑體", 14F, FontStyle.Bold);
                    link.LinkColor = Color.FromArgb(60, 60, 60);
                    link.ActiveLinkColor = Color.FromArgb(60, 60, 60);
                    link.LinkBehavior = LinkBehavior.NeverUnderline;
                    link.Cursor = Cursors.Default;
                }
                else
                {
                    link.Font = new Font("微軟正黑體", 13F, FontStyle.Regular);
                    link.LinkColor = Color.FromArgb(140, 140, 140);
                    link.ActiveLinkColor = Color.FromArgb(80, 160, 255);
                    link.LinkBehavior = LinkBehavior.HoverUnderline;
                    link.Cursor = Cursors.Hand;

                    if (node.Value != null)
                    {
                        link.Click += (s, e) => node.Value.Invoke();
                    }
                }

                flowLayoutPanelBreadcrumb.Controls.Add(link);

                if (count < total)
                {
                    UILabel lblSeparator = new UILabel();
                    lblSeparator.Text = " ❯ ";
                    lblSeparator.AutoSize = true;
                    lblSeparator.Font = new Font("微軟正黑體", 11F, FontStyle.Regular);
                    lblSeparator.ForeColor = Color.Silver;
                    lblSeparator.Margin = new Padding(8, 3, 8, 0);
                    flowLayoutPanelBreadcrumb.Controls.Add(lblSeparator);
                }
            }
        }

        private void GoHome()
        {
            var path = new Dictionary<string, Action> { { "首頁", null } };
            OpenPageWithPermission(new UC_Dashboard(), path, "Dashboard_Manage");
        }

        private void ibtnHome_Click(object sender, EventArgs e) { GoHome(); }

        private void btnAllProductsManager_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "商品管理", null },
                { "商品列表", null }
            };
            OpenPageWithPermission(new UC_ProductManager(), path, "Product_CRUD");
        }

        private void btnProductOptional_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "商品管理", null },
                { "商品選項自訂", null }
            };
            OpenPageWithPermission(new UC_GlobalOptionManager(), path, "ProductOption_CRUD");
        }

        private void btnAccountSet_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "權限管理", null },
                { "帳號設定", null }
            };
            OpenPageWithPermission(new UC_AccountManager(), path, "Account_CRUD");
        }

        private void ibtnOrderList_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "訂單管理", null },
                { "訂單列表", null }
            };
            OpenPageWithPermission(new UC_OrderManager(), path, "POS_System");
        }

        private void ibtnOrderDetail_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "訂單管理", null },
                { "訂單狀態管理", null }
            };
            OpenPageWithPermission(new UC_OrderCardView(), path, "Dashboard_Manage");
        }

        private void btnSQLBackup_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "系統設定", null },
                { "資料備份", null }
            };
            OpenPageWithPermission(new UC_BackupManager(), path, "Database_Backup");
        }

        private void btnLogSet_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "系統設定", null },
                { "系統登入日誌", null }
            };
            OpenPageWithPermission(new UC_LoginLogManager(), path, "LoginLog_View");
        }

        private void ibtnMemberList_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "會員管理", null },
                { "會員列表", null }
            };
            OpenPageWithPermission(new UC_MemberManager(), path, "Member_CRUD");
        }

        private void ibtnMemberLevel_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "會員管理", null },
                { "會員等級管理", null }
            };
            OpenPageWithPermission(new UC_MemberLevelManager(), path, "MemberLevel_CRUD");
        }

        private void ibtnrevenuetotal_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "營收管理", null },
                { "營收總覽", null }
            };
            OpenPageWithPermission(new UC_Revenue(), path, "Revenue_View");
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "權限管理", null },
                { "員工管理", null }
            };
            OpenPageWithPermission(new UC_Employees(), path, "Employee_CRUD");
        }

        private void btnPermission_Click(object sender, EventArgs e)
        {
            var path = new Dictionary<string, Action>
            {
                { "首頁", GoHome },
                { "權限管理", null },
                { "權限設定", null }
            };
            OpenPageWithPermission(new UC_Permission(), path, "Permission_CRUD");
        }

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("yyyy/MM/dd ddd  HH:mm:ss");
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否確定要關閉後台系統?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }

        void CustomizeDesign()
        {
            PanelProducts.Visible = false;
            PanelOrder.Visible = false;
            MemberPanel.Visible = false;
            AccountPanel.Visible = false;
            RevenuePanel.Visible = false;
            SystemPanel.Visible = false;
        }

        private void ShowSubMenu(object sender, UIPanel Menu)
        {
            FontAwesome.Sharp.IconButton clickedBtn = (FontAwesome.Sharp.IconButton)sender;

            //移除 ▼ 符號
            string cleanText = clickedBtn.Text.Replace("▼", "").Trim();

            if (currentBtn != null && currentBtn != clickedBtn)
            {
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.BackColor = Color.Transparent;

                // 將前一個按鈕的文字也清乾淨
                currentBtn.Text = currentBtn.Text.Replace("▼", "").Trim();
            }

            if (Menu.Visible == false)
            {
                Menu.Visible = true;
                clickedBtn.ForeColor = Color.Yellow;
                clickedBtn.IconColor = Color.Yellow;
                clickedBtn.BackColor = Color.FromArgb(74, 63, 53);

                clickedBtn.Text = cleanText + "            ▼";
                currentBtn = clickedBtn;
            }
            else
            {
                Menu.Visible = false;
                clickedBtn.ForeColor = Color.Gainsboro;
                clickedBtn.IconColor = Color.Gainsboro;
                clickedBtn.BackColor = Color.Transparent;
                clickedBtn.Text = cleanText;

                currentBtn = null;
            }
        }

        private void ibtnOrder_Click(object sender, EventArgs e) { ShowSubMenu(sender, PanelOrder); }
        private void ibtnMember_Click(object sender, EventArgs e) { ShowSubMenu(sender, MemberPanel); }
        private void ibtnrevenue_Click(object sender, EventArgs e) { ShowSubMenu(sender, RevenuePanel); }
        private void ibtnAuth_Click(object sender, EventArgs e) { ShowSubMenu(sender, AccountPanel); }
        private void ibtnSystem_Click(object sender, EventArgs e) { ShowSubMenu(sender, SystemPanel); }
        private void ibtnProduct_Click(object sender, EventArgs e) { ShowSubMenu(sender, PanelProducts); }

        private void SideBarControl_Click(object sender, EventArgs e)
        {
            if (SideBarShow)
            {
                panelSidebar.Width = 0;
                if (currentBtn != null)
                {
                    currentBtn.ForeColor = Color.Gainsboro;
                    currentBtn.IconColor = Color.Gainsboro;
                }
                SideBarShow = false;
            }
            else
            {
                panelSidebar.Width = 250;
                SideBarShow = true;
            }
        }
    }
}