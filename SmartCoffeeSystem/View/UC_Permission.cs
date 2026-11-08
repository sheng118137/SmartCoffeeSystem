using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_Permission : UserControl
    {
        //定義系統完整的 12 大權限清單 (Key = 權限代碼, Value = 顯示名稱)
        private readonly Dictionary<string, string> _systemPermissions = new Dictionary<string, string>
        {
            { "POS_System", "1. 前端 POS 系統" },
            { "Product_CRUD", "2. 商品 CRUD" },
            { "ProductOption_CRUD", "3. 商品選項 CRUD" },
            { "Member_CRUD", "4. 會員列表 CRUD" },
            { "MemberLevel_CRUD", "5. 會員等級 CRUD" },
            { "Revenue_View", "6. 營收總覽" },
            { "Dashboard_Manage", "7. 後台首頁 (狀態修改/數據檢視)" },
            { "Permission_CRUD", "8. 權限設定 CRUD" },
            { "Employee_CRUD", "9. 員工資料 CRUD" },
            { "Account_CRUD", "10. 帳號設定 CRUD" },
            { "LoginLog_View", "11. 登入日誌" },
            { "Database_Backup", "12. 資料庫備份" }
        };

        private string _selectedRole = ""; // 目前選中的職稱角色

        public UC_Permission()
        {
            InitializeComponent();
            this.Load += UC_Permission_Load;
        }

        private void UC_Permission_Load(object sender, EventArgs e)
        {
            // 初始化右側權限勾選清單
            InitPermissionCheckList();

            // 載入左側職稱清單
            LoadRoleList();
        }

        // 初始化右側 CheckedTestBox 項目
        private void InitPermissionCheckList()
        {
            if (chkPermissions != null)
            {
                chkPermissions.Items.Clear();
                foreach (var perm in _systemPermissions)
                {
                    chkPermissions.Items.Add(new KeyValuePair<string, string>(perm.Key, perm.Value));
                }
                chkPermissions.DisplayMember = "Value";
                chkPermissions.ValueMember = "Key";
            }
        }

        // 載入左側職稱列表 (從 Employees 表抓取所有不重複的 EmployeeTitle)
        private void LoadRoleList()
        {
            try
            {
                using (var db = new POSContext())
                {
                    var roles = db.Employees
                        .Where(e => !string.IsNullOrEmpty(e.EmployeeTitle))
                        .Select(e => e.EmployeeTitle)
                        .Distinct()
                        .ToList();

                    // 確保有基本預設職稱
                    var defaultRoles = new string[] { "店長", "正職人員", "計時人員", "工讀生" };
                    var allRoles = defaultRoles.Union(roles).ToList();

                    lstRoles.DataSource = allRoles;

                    if (lstRoles.Items.Count > 0)
                    {
                        lstRoles.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取職稱清單失敗：{ex.Message}");
            }
        }

        //點擊左側不同職稱時，讀取該職稱底下員工共同擁有的權限
        private void lstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRoles.SelectedItem == null) return;
            _selectedRole = lstRoles.SelectedItem.ToString();
            lblRightTitle.Text = $"🔒 目前設定角色：【 {_selectedRole} 】的系統權限";

            LoadRolePermissions(_selectedRole);
        }

        // 讀取特定職稱擁有的權限並勾選
        private void LoadRolePermissions(string roleTitle)
        {
            try
            {
                using (var db = new POSContext())
                {
                    // 找出屬於這個職稱的所有員工 ID
                    var empIds = db.Employees
                        .Where(e => e.EmployeeTitle == roleTitle)
                        .Select(e => e.EmployeeId)
                        .ToList();

                    if (!empIds.Any())
                    {
                        ClearAllCheckmarks();
                        return;
                    }

                    // 找出這些員工擁有的權限交集（或聯集，此處以聯集或取第一位代表為例，通常同職稱權限相同）
                    // 為了最精準，我們抓取該職稱下所有員工被賦予過的權限代碼
                    var permKeys = db.EmployeePermissions
                        .Where(p => empIds.Contains(p.EmployeeId))
                        .Select(p => p.PermissionKey)
                        .Distinct()
                        .ToList();

                    // 更新右側 CheckListBox 勾選狀態
                    for (int i = 0; i < chkPermissions.Items.Count; i++)
                    {
                        var kvp = (KeyValuePair<string, string>)chkPermissions.Items[i];
                        if (permKeys.Contains(kvp.Key))
                        {
                            chkPermissions.SetItemChecked(i, true);
                        }
                        else
                        {
                            chkPermissions.SetItemChecked(i, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"載入角色權限失敗：{ex.Message}");
            }
        }

        private void ClearAllCheckmarks()
        {
            for (int i = 0; i < chkPermissions.Items.Count; i++)
            {
                chkPermissions.SetItemChecked(i, false);
            }
        }

        //儲存該職稱所有員工的權限設定
        private void btnSavePermission_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedRole))
            {
                UIMessageBox.ShowWarning("請先選擇左側的職稱角色！");
                return;
            }

            try
            {
                using (var db = new POSContext())
                {
                    // 找出屬於這個職稱的所有員工 ID
                    var empIds = db.Employees
                        .Where(k => k.EmployeeTitle == _selectedRole)
                        .Select(k => k.EmployeeId)
                        .ToList();

                    if (!empIds.Any())
                    {
                        UIMessageBox.ShowWarning($"目前「{_selectedRole}」這個職稱底下沒有任何員工，無法套用權限！");
                        return;
                    }

                    //蒐集右側被勾選的權限 Key
                    var selectedKeys = new List<string>();
                    foreach (var checkedItem in chkPermissions.CheckedItems)
                    {
                        var kvp = (KeyValuePair<string, string>)checkedItem;
                        selectedKeys.Add(kvp.Key);
                    }

                    //批次更新針對該職稱底下的每一位員工，重新覆寫他們的權限
                    foreach (var empId in empIds)
                    {
                        // 移除該員工舊權限
                        var oldPerms = db.EmployeePermissions.Where(p => p.EmployeeId == empId);
                        db.EmployeePermissions.RemoveRange(oldPerms);

                        // 寫入新勾選的權限
                        foreach (var key in selectedKeys)
                        {
                            db.EmployeePermissions.Add(new EmployeePermission
                            {
                                EmployeeId = empId,
                                PermissionKey = key
                            });
                        }
                    }

                    db.SaveChanges();
                    UIMessageBox.ShowSuccess($"已成功將權限套用至【 {_selectedRole} 】職稱底下的所有員工！");
                }
            }
            catch (Exception ex)
            {
                string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                UIMessageBox.ShowError($"儲存權限失敗：{errorMsg}");
            }
        }
    }
}