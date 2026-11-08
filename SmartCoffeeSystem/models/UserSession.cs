using System.Collections.Generic;

namespace SmartCoffeeSystem
{
    public static class UserSession
    {
        public static int EmployeeId { get; set; }
        public static string Username { get; set; }
        public static string EmployeeName { get; set; }
        public static string EmployeeTitle { get; set; }

        // 存放目前登入者擁有的所有權限 Key 清單 (例如: "POS_System", "Revenue_View")
        public static List<string> Permissions { get; set; } = new List<string>();

        // 快捷檢查方法傳入權限 Key，判斷目前登入者有沒有權限
        public static bool HasPermission(string permissionKey)
        {
            // 如果是特定最高權限可直接放行 (或完全依賴資料庫勾選)
            if (Permissions.Contains(permissionKey))
            {
                return true;
            }
            return false;
        }

        // 清除登入狀態 (登出時使用)
        public static void Clear()
        {
            EmployeeId = 0;
            Username = "";
            EmployeeName = "";
            EmployeeTitle = "";
            Permissions.Clear();
        }
    }
}