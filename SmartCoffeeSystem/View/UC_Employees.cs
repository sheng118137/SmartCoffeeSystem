using Sunny.UI;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_Employees : UserControl
    {
        // 紀錄目前正在編輯的員工 ID，如果為 0 代表目前是「新增模式」
        private int _currentEditingId = 0;

        public UC_Employees()
        {
            InitializeComponent();
            this.Load += UC_Employees_Load;
        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {
            // 初始化 DataGridView 欄位綁定
            dgvEmployees.AutoGenerateColumns = false;
            colEmployeeName.DataPropertyName = "EmployeeName";
            colEmployeeTitle.DataPropertyName = "EmployeeTitle";
            colEmployeeStatus.DataPropertyName = "StatusText"; // 對應轉換後的顯示文字

            //讓職稱下拉選單可以支援手動輸入新職稱 (DropDownStyle 設為 DropDown)
            cbTitle.DropDownStyle = UIDropDownStyle.DropDown;

            // 載入資料庫現有的職稱選項
            LoadTitleOptions();

            // 初始化狀態選項
            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new object[] { "在職", "離職", "停用" });

            // 綁定搜尋框變更事件 (即時搜尋)
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // 初始狀態為新增模式
            ClearRightPanel();
            LoadEmployeeList();
        }

        //從資料庫動態載入現有的不重複職稱，並加上預設常用的職稱
        private void LoadTitleOptions()
        {
            try
            {
                using (var db = new POSContext())
                {
                    // 抓出資料庫裡所有的職稱，過濾掉空白，並轉為 Distinct 集合
                    var dbTitles = db.Employees
                        .Where(emp => !string.IsNullOrEmpty(emp.EmployeeTitle))
                        .Select(emp => emp.EmployeeTitle)
                        .Distinct()
                        .ToList();

                    // 定義一些系統常用的預設職稱
                    var defaultTitles = new string[] { "店長", "正職人員", "計時人員", "工讀生" };

                    // 合併預設職稱與資料庫現有職稱，確保不重複
                    var allTitles = defaultTitles.Union(dbTitles).ToArray();

                    cbTitle.Items.Clear();
                    cbTitle.Items.AddRange(allTitles);
                }
            }
            catch (Exception ex)
            {
                // 若撈取失敗，至少保證有預設選項
                cbTitle.Items.Clear();
                cbTitle.Items.AddRange(new object[] { "店長", "正職人員", "計時人員", "工讀生" });
            }
        }

        // 載入員工清單
        private void LoadEmployeeList(string keyword = "")
        {
            try
            {
                using (var db = new POSContext())
                {
                    var query = db.Employees.AsQueryable();

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        query = query.Where(emp => emp.EmployeeName.Contains(keyword)||emp.EmployeeTitle.Contains(keyword));

                    }

                    // 撈出資料並轉為適合介面顯示的匿名物件
                    var list = query
                        .OrderByDescending(emp => emp.CreateTime)
                        .Select(emp => new
                        {
                            emp.EmployeeId,
                            emp.EmployeeName,
                            emp.EmployeeTitle,
                            StatusText = emp.EmployeeStatus == 1 ? "在職" : (emp.EmployeeStatus == 2 ? "離職" : "停用")
                        })
                        .ToList();

                    dgvEmployees.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取員工清單失敗：{ex.Message}");
            }
        }

        // 搜尋框即時過濾
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadEmployeeList(txtSearch.Text.Trim());
        }

        // 點擊左側清單，右側帶入詳細資料
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // 取得隱藏的 EmployeeId
            dynamic selectedRow = dgvEmployees.Rows[e.RowIndex].DataBoundItem;
            int empId = selectedRow.EmployeeId;

            LoadEmployeeDetail(empId);
        }

        // 載入單一員工詳細資料到右側面板
        private void LoadEmployeeDetail(int empId)
        {
            try
            {
                using (var db = new POSContext())
                {
                    var emp = db.Employees.FirstOrDefault(x => x.EmployeeId == empId);
                    if (emp != null)
                    {
                        _currentEditingId = emp.EmployeeId;
                        lblRightTitle.Text = $"編輯員工資料：{emp.EmployeeName}";

                        txtName.Text = emp.EmployeeName;
                        txtPhone.Text = emp.EmployeePhone ?? "";
                        txtEmail.Text = emp.Email ?? "";
                        txtAddress.Text = emp.EmployeeAddress ?? "";

                        //直接將職稱文字塞入 Text（支援資料庫中原本沒有、但自訂的新職稱）
                        cbTitle.Text = emp.EmployeeTitle;

                        // 轉換狀態 (1=在職, 2=離職, 3=停用)
                        if (emp.EmployeeStatus == 1) cbStatus.SelectedIndex = 0;
                        else if (emp.EmployeeStatus == 2) cbStatus.SelectedIndex = 1;
                        else cbStatus.SelectedIndex = 2;

                        btnDelete.Visible = true; // 顯示停用按鈕
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取詳細資料失敗：{ex.Message}");
            }
        }

        //點擊新增按鈕，清空右側進入新增模式
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearRightPanel();
        }

        // 清空右側面板
        private void ClearRightPanel()
        {
            _currentEditingId = 0; // 0 代表新增模式
            lblRightTitle.Text = "新增員工";

            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

            // 重新整理下拉選單
            LoadTitleOptions();
            if (cbTitle.Items.Count > 0) cbTitle.SelectedIndex = 0;

            cbStatus.SelectedIndex = 0; // 預設在職

            btnDelete.Visible = false; // 新增模式不顯示停用按鈕
            txtName.Focus();
        }

        // 儲存
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 防呆
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                UIMessageBox.ShowWarning("「員工姓名」為必填欄位！");
                return;
            }

            try
            {
                using (var db = new POSContext())
                {
                    Employee emp;

                    if (_currentEditingId == 0) // 新增模式
                    {
                        emp = new Employee();
                        emp.CreateTime = DateTime.Now;
                        db.Employees.Add(emp);
                    }
                    else // 編輯模式
                    {
                        emp = db.Employees.FirstOrDefault(x => x.EmployeeId == _currentEditingId);
                        if (emp == null) return;
                    }

                    // 寫入資料
                    emp.EmployeeName = txtName.Text.Trim();
                    emp.EmployeeTitle = cbTitle.Text.Trim() != "" ? cbTitle.Text.Trim() : "正職人員";
                    emp.EmployeePhone = txtPhone.Text.Trim();
                    emp.Email = txtEmail.Text.Trim();
                    emp.EmployeeAddress = txtAddress.Text.Trim();

                    // 寫入狀態 (在職=1, 離職=2, 停用=3)
                    byte newStatus = (byte)(cbStatus.SelectedIndex == 0 ? 1 : (cbStatus.SelectedIndex == 1 ? 2 : 3));
                    emp.EmployeeStatus = newStatus;

                    db.SaveChanges();

                    //聯動更新 Account 帳號狀態：若員工被改為離職(2)或停用(3)，自動鎖定帳號；若改回在職(1)，則解鎖帳號
                    if (_currentEditingId != 0)
                    {
                        var account = db.Accounts.FirstOrDefault(a => a.EmployeeId == _currentEditingId);
                        if (account != null)
                        {
                            if (newStatus == 2 || newStatus == 3)
                            {
                                account.IsLocked = true; // 離職或停用 ➔ 鎖定帳號
                            }
                            else if (newStatus == 1)
                            {
                                account.IsLocked = false; // 恢復在職 ➔ 解鎖帳號
                            }
                            account.UpdateTime = DateTime.Now;
                            db.SaveChanges();
                        }
                    }

                    UIMessageBox.ShowSuccess(_currentEditingId == 0 ? "新增成功！" : "更新成功！");

                    // 重新載入職稱清單與員工列表
                    LoadTitleOptions();
                    LoadEmployeeList(txtSearch.Text);
                    ClearRightPanel();
                }
            }
            catch (Exception ex)
            {
                // 不斷往下挖，直到找到最深層的真正錯誤訊息
                Exception realError = ex;
                while (realError.InnerException != null)
                {
                    realError = realError.InnerException;
                }

                UIMessageBox.ShowError($"真正的錯誤原因：\n{realError.Message}");
            }
        }

        //停用按鈕
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentEditingId == 0) return;

            if (UIMessageBox.Show("確定要停用/離職這位員工嗎？\n此動作將同步鎖定其系統登入帳號，且不會刪除歷史紀錄。", "確認停用", UIStyle.Red, UIMessageBoxButtons.OKCancel))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var emp = db.Employees.FirstOrDefault(x => x.EmployeeId == _currentEditingId);
                        if (emp != null)
                        {
                            emp.EmployeeStatus = 3; // 3 代表停用
                            db.SaveChanges();

                            //同步鎖定對應的 Account 帳號
                            var account = db.Accounts.FirstOrDefault(a => a.EmployeeId == _currentEditingId);
                            if (account != null)
                            {
                                account.IsLocked = true;
                                account.UpdateTime = DateTime.Now;
                                db.SaveChanges();
                            }

                            UIMessageBox.ShowSuccess("員工已成功停用，對應帳號已同步鎖定！");
                            LoadEmployeeList(txtSearch.Text);
                            ClearRightPanel();
                        }
                    }
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"停用失敗：{ex.Message}");
                }
            }
        }
    }
}