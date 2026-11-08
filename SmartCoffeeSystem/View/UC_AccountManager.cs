using Sunny.UI;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem
{
    public partial class UC_AccountManager : UserControl
    {
        public UC_AccountManager()
        {
            InitializeComponent();

            // 綁定事件
            dgvAccounts.CellDoubleClick += DgvAccounts_CellDoubleClick;
            dgvAccounts.KeyDown += DgvAccounts_KeyDown;
        }

        private void UC_AccountManager_Load(object sender, EventArgs e)
        {
            dgvAccounts.AutoGenerateColumns = false;
            LoadAccountData();
        }

        public void LoadAccountData()
        {
            try
            {
                using (var db = new POSContext())
                {
                    var accountList = db.Accounts
                        .Join(db.Employees,
                              a => a.EmployeeId,
                              e => e.EmployeeId,
                              (a, e) => new { a, e })
                        .OrderBy(x => x.a.EmployeeId)
                        .Select(x => new
                        {
                            EmployeeId = x.a.EmployeeId,
                            EmployeeName = x.e.EmployeeName ?? "未知姓名",
                            AccountName = x.a.Accounts,
                            CreateTime = x.a.CreateTime,
                            FailedLoginCount = x.a.FailedLoginCount,
                            StatusText = x.a.IsLocked ? "鎖定中" : "正常"
                        })
                        .ToList();

                    dgvAccounts.DataSource = accountList;
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"載入資料失敗：{ex.Message}");
            }

        }

        // 彈出專屬表單
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var frm = new FrmAccountEdit(); // 呼叫新表單
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"已儲存資料", "員工資料新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccountData(); // 儲存成功後刷新列表
            }
        }

        // 雙擊修改將 EmployeeId 傳給專屬表單
        private void DgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int empId = Convert.ToInt32(dgvAccounts.Rows[e.RowIndex].Cells["colEmpId"].Value);

            var frm = new FrmAccountEdit(empId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"已更新員工編號:{empId}資料", "員工資料更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccountData(); // 儲存成功後刷新列表
            }
        }

        //啟用
        private void DgvAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count == 0) return;

            int empId = Convert.ToInt32(dgvAccounts.SelectedRows[0].Cells["colEmpId"].Value);
            string account = dgvAccounts.SelectedRows[0].Cells["colAccount"].Value.ToString();

            using (var db = new POSContext())
            {
                var acc = db.Accounts.FirstOrDefault(a => a.EmployeeId == empId);
                if (acc == null) return;

                if (acc.IsLocked)
                {
                    var confirm = MessageBox.Show($"確定要解鎖並恢復此帳號嗎？", "解鎖確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirm == DialogResult.Yes)
                    {
                        acc.IsLocked = false;
                        acc.FailedLoginCount = 0;
                        acc.LockedUntil = null;
                        acc.UpdateTime = DateTime.Now;
                        db.SaveChanges();
                        LoadAccountData();
                    }
                }
                else
                {
                    var confirm = MessageBox.Show($"確定要停用此帳號嗎？", "停用確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        acc.IsLocked = true;
                        acc.UpdateTime = DateTime.Now;
                        db.SaveChanges();
                        LoadAccountData();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void txtSearching_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var db = new POSContext();
                var AccountList = db.Accounts
                        .Join(db.Employees,
                              a => a.EmployeeId,
                              c => c.EmployeeId,
                              (a, c) => new { a, c })
                        .OrderBy(x => x.a.EmployeeId)
                        .Select(x => new
                        {
                            EmployeeId = x.a.EmployeeId,
                            EmployeeName = x.c.EmployeeName ?? "未知姓名",
                            AccountName = x.a.Accounts,
                            CreateTime = x.a.CreateTime,
                            FailedLoginCount = x.a.FailedLoginCount,
                            StatusText = x.a.IsLocked ? "鎖定中" : "正常"
                        })
                        .ToList();
                string keyword = txtSearching?.Text?.Trim()?.ToLower() ?? "";
                if (string.IsNullOrWhiteSpace(keyword) || keyword == "🔍搜尋員工...")
                {
                    dgvAccounts.DataSource = AccountList;
                    return;
                }
                var SearchAccount = AccountList.Where(p =>
                    (p.EmployeeName != null && p.EmployeeName.ToLower().Contains(keyword)) ||
                    (p.AccountName != null && p.AccountName.ToLower().Contains(keyword)) ||
                    (p.StatusText != null && p.StatusText.Contains(keyword))
                ).ToList();

                dgvAccounts.DataSource = SearchAccount;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"連線錯誤:{ex.Message}");
            }
        }

    }
}
