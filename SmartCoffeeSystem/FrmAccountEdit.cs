using BCrypt.Net;
using Sunny.UI;
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Windows.Forms;
using SmartCoffeeSystem.models;
using System.Globalization;

namespace SmartCoffeeSystem
{
    public partial class FrmAccountEdit : UIForm
    {
        private int? _editEmpId = null;
        private bool isPasswordVisible = false;

        // 預設建構子：新增模式
        public FrmAccountEdit()
        {
            InitializeComponent();
            this.Text = "新增系統帳號";
            this.Load += FrmAccountEdit_Load;
        }

        // 帶參數建構子>修改模式
        public FrmAccountEdit(int empId) : this()
        {
            _editEmpId = empId;
            this.Text = "修改帳號資料";
        }

        private void FrmAccountEdit_Load(object sender, EventArgs e)
        {
            LoadEmployeeComboBox();

            // 如果是修改模式載舊資料
            if (_editEmpId.HasValue)
            {
                using (var db = new POSContext())
                {
                    var acc = db.Accounts.FirstOrDefault(a => a.EmployeeId == _editEmpId.Value);
                    if (acc != null)
                    {
                        cmbEmployee.SelectedValue = acc.EmployeeId;
                        cmbEmployee.Enabled = false; // 修改不允許換人
                        txtAccount.Text = acc.Accounts;
                        txtPassword.Watermark = "若不更改密碼請留空";
                    }
                }
            }
        }

        //載入員工資料
        private void LoadEmployeeComboBox()
        {
            using (var db = new POSContext())
            {
                // 只撈出狀態正常的員工
                var emps = db.Employees
                    .Select(e => new
                    {
                        EmployeeId = e.EmployeeId,
                        DisplayText = e.EmployeeId + " - " + e.EmployeeName
                    }).ToList();

                cmbEmployee.DataSource = emps;
                cmbEmployee.ValueMember = "EmployeeId";
                cmbEmployee.DisplayMember = "DisplayText";
                cmbEmployee.SelectedIndex = -1; // 預設不選
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedValue == null)
            {
                UIMessageBox.ShowWarning("請選擇一位員工！");
                return;
            }

            int empId = (int)cmbEmployee.SelectedValue;
            string accountName = txtAccount.Text.Trim();
            string rawPassword = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(accountName))
            {
                UIMessageBox.Show("帳號為必填欄位！");
                return;
            }

            if (!_editEmpId.HasValue && string.IsNullOrWhiteSpace(rawPassword))
            {
                UIMessageBox.ShowWarning("新增帳號時，密碼為必填欄位！");
                return;
            }
            if (rawPassword.Contains(" "))
            {
                UIMessageBox.Show("帳號不得輸入空白鍵!");
                return;
            }

            try
            {
                using (var db = new POSContext())
                {
                    if (_editEmpId.HasValue)
                    {
                        // 修改
                        var acc = db.Accounts.FirstOrDefault(a => a.EmployeeId == _editEmpId.Value);
                        if (acc == null) return;

                        if (db.Accounts.Any(a => a.Accounts == accountName && a.EmployeeId != _editEmpId.Value))
                        {
                            UIMessageBox.Show("此帳號已被其他人使用!");
                            return;
                        }

                        acc.Accounts = accountName;
                        acc.UpdateTime = DateTime.Now;
                        if (!string.IsNullOrWhiteSpace(rawPassword))
                        {
                            acc.PasswordHash = BCrypt.Net.BCrypt.HashPassword(rawPassword);
                        }

                    }
                    else
                    {
                        // 新增
                        if (db.Accounts.Any(a => a.Accounts == accountName))
                        {
                            UIMessageBox.Show("此帳號已經存在!");
                            return;
                        }
                        if (db.Accounts.Any(a => a.EmployeeId == empId))
                        {
                            UIMessageBox.Show("此員工已經有帳號了!");
                            return;
                        }


                        var newAcc = new Account
                        {
                            EmployeeId = empId,
                            Accounts = accountName,
                            PasswordHash = BCrypt.Net.BCrypt.HashPassword(rawPassword),
                            FailedLoginCount = 0,
                            CreateTime = DateTime.Now,
                            UpdateTime = DateTime.Now,
                            IsLocked = false
                        };
                        db.Accounts.Add(newAcc);
                    }

                    db.SaveChanges();
                    this.DialogResult = DialogResult.OK; // 回傳成功訊號給 UC
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"儲存失敗：{ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // 密碼小眼睛切換
        private void btnTogglePwd_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';
            btnTogglePwd.Symbol = isPasswordVisible ? 61550 : 61552;
            btnTogglePwd.SymbolColor = isPasswordVisible ? Color.FromArgb(64, 158, 255) : Color.Gray;
        }

        // 密碼強度檢測
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text;
            if (string.IsNullOrEmpty(pwd))
            {
                lblPwdStrength.Text = "";
                return;
            }

            int score = 0;
            if (pwd.Length >= 8) score++;
            if (pwd.Any(char.IsDigit)) score++;
            if (pwd.Any(char.IsLetter)) score++;
            if (pwd.Any(c => !char.IsLetterOrDigit(c))) score++;

            if (score <= 1) { lblPwdStrength.Text = "強度：弱"; lblPwdStrength.ForeColor = Color.Red; }
            else if (score <= 3) { lblPwdStrength.Text = "強度：中"; lblPwdStrength.ForeColor = Color.Orange; }
            else { lblPwdStrength.Text = "強度：強"; lblPwdStrength.ForeColor = Color.Green; }
        }
    }
}