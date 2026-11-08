using Sunny.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_MemberManager : UserControl
    {
        private bool _isLoaded = false;
        private int _currentMemberId = 0;

        public UC_MemberManager()
        {
            InitializeComponent();
            this.Load += UC_MemberManager_Load;
        }

        private void UC_MemberManager_Load(object sender, EventArgs e)
        {
            dgvMembers.AutoGenerateColumns = false;

            colMemberID.DataPropertyName = "MemberID";
            colName.DataPropertyName = "MemberName";
            colPhone.DataPropertyName = "Phone";
            colLevel.DataPropertyName = "LevelName";
            colPoints.DataPropertyName = "Point";

            dgvMembers.SelectionChanged += DgvMembers_SelectionChanged;

            LoadLevels();
            LoadMembers();
            _isLoaded = true;
        }

        //載資料和等級選單
        private void LoadLevels()
        {
            try
            {
                using (var db = new POSContext())
                {
                    var levels = db.MemberLevels.OrderBy(l => l.LevelID).ToList();

                    // 右邊編輯區的下拉選單用只能選存在的等級
                    cboLevel.DataSource = levels;
                    cboLevel.DisplayMember = "LevelName";
                    cboLevel.ValueMember = "LevelID";

                    // 搜尋過濾區的下拉選單用多一個「全部等級」選項
                    var filterLevels = levels.Select(l => new { LevelID = l.LevelID, LevelName = l.LevelName }).ToList();
                    filterLevels.Insert(0, new { LevelID = 0, LevelName = "全部等級" }); //塞預設選項

                    //先解除綁定事件，避免DataSource變更時誤觸發搜尋
                    cboFilterLevel.SelectedIndexChanged -= cboFilterLevel_SelectedIndexChanged;

                    cboFilterLevel.DataSource = filterLevels;
                    cboFilterLevel.DisplayMember = "LevelName";
                    cboFilterLevel.ValueMember = "LevelID";

                    //重綁事件
                    cboFilterLevel.SelectedIndexChanged += cboFilterLevel_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取會員等級失敗：{ex.Message}");
            }
        }

        private void LoadMembers(string keyword = "", int filterLevelId = 0)
        {
            try
            {
                using (var db = new POSContext())
                {
                    var query = from m in db.Members
                                join l in db.MemberLevels on m.LevelID equals l.LevelID into levelGroup
                                from level in levelGroup.DefaultIfEmpty()
                                where m.IsActive == true &&
                                      (string.IsNullOrEmpty(keyword) ||
                                       m.Phone.Contains(keyword) ||
                                       m.MemberName.Contains(keyword)) &&
                                      (filterLevelId == 0 || m.LevelID == filterLevelId)
                                orderby m.JoinDate descending
                                select new
                                {
                                    MemberID = m.MemberID,
                                    MemberName = m.MemberName,
                                    Phone = m.Phone,
                                    LevelName = level != null ? level.LevelName : "未知",
                                    Point = m.Point
                                };
                    var members = query.ToList();

                    dgvMembers.DataSource = null;
                    dgvMembers.DataSource = members;

                    if (members.Count == 0)
                    {
                        ClearEditPanel();
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取會員列表失敗：{ex.Message}");
            }
        }

        // 左側：動態搜尋與過濾

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!_isLoaded) return;
            ExecuteSearch();
        }

        private void cboFilterLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isLoaded) return;
            ExecuteSearch();
        }

        // 同時讀關鍵字和目前選中的等級
        private void ExecuteSearch()
        {
            string keyword = txtSearch.Text.Trim();
            int filterId = 0;

            if (cboFilterLevel.SelectedValue != null)
            {
                int.TryParse(cboFilterLevel.SelectedValue.ToString(), out filterId);
            }

            LoadMembers(keyword, filterId);
        }

        private void DgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (!_isLoaded || dgvMembers.CurrentRow == null) return;

            int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["colMemberID"].Value);
            LoadMemberDetails(memberId);
        }

        //編輯面板
        private void LoadMemberDetails(int memberId)
        {
            try
            {
                using (var db = new POSContext())
                {
                    var member = db.Members.Find(memberId);
                    if (member != null)
                    {
                        _currentMemberId = member.MemberID;
                        lblEditTitle.Text = $"編輯會員 (ID: {member.MemberID})";
                        lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(80, 160, 255);

                        txtName.Text = member.MemberName;
                        txtPhone.Text = member.Phone;
                        txtPoints.Text = member.Point.ToString();
                        txtCarrier.Text = member.DefaultCarrierNum ?? "";
                        txtTaxID.Text = member.DefaultTaxID ?? "";

                        if (member.LevelID != null)
                        {
                            cboLevel.SelectedValue = member.LevelID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取會員詳細資料失敗：{ex.Message}");
            }
        }

        private void ClearEditPanel()
        {
            //先暫停觸發SelectionChanged事件，避免又被重新載入
            dgvMembers.SelectionChanged -= DgvMembers_SelectionChanged;

            _currentMemberId = 0;
            lblEditTitle.Text = "新增會員";
            lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(110, 190, 40);

            txtName.Text = "";
            txtPhone.Text = "";
            txtPoints.Text = "0";
            txtCarrier.Text = "";
            txtTaxID.Text = "";
            if (cboLevel.Items.Count > 0) cboLevel.SelectedIndex = 0;

            //焦點反白都清除
            dgvMembers.CurrentCell = null;
            dgvMembers.ClearSelection();

            //重新把事件綁回來
            dgvMembers.SelectionChanged += DgvMembers_SelectionChanged;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearEditPanel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                UIMessageBox.ShowWarning("「姓名」與「手機號碼」為必填欄位！");
                return;
            }

            if (!int.TryParse(txtPoints.Text, out int points))
            {
                UIMessageBox.ShowWarning("「點數」必須是整數數字！");
                return;
            }

            //載具與統編資料
            string carrierNum = string.IsNullOrWhiteSpace(txtCarrier.Text) ? null : txtCarrier.Text.Trim();
            string taxId = string.IsNullOrWhiteSpace(txtTaxID.Text) ? null : txtTaxID.Text.Trim();
            string carrierType = null;

            //DefaultCarrierType 的優先邏輯
            if (!string.IsNullOrEmpty(carrierNum))
            {
                //只要有填手機條碼，無論有沒有統編，預設手機條碼
                carrierType = "手機條碼";
            }
            else if (!string.IsNullOrEmpty(taxId))
            {
                //沒條碼但有統編，預設公司統編
                carrierType = "公司統編";
            }

            try
            {
                using (var db = new POSContext())
                {
                    string phone = txtPhone.Text.Trim();
                    if (db.Members.Any(m => m.Phone == phone &&m.IsActive==true && m.MemberID != _currentMemberId))
                    {
                        UIMessageBox.ShowWarning("此手機號碼已經被註冊過了！");
                        return;
                    }

                    if (_currentMemberId == 0)
                    {
                        // 新增模式
                        var newMember = new Member
                        {
                            MemberName = txtName.Text.Trim(),
                            Phone = phone,
                            LevelID = Convert.ToInt32(cboLevel.SelectedValue),
                            Point = points,
                            DefaultCarrierType = carrierType,
                            DefaultCarrierNum = carrierNum,
                            DefaultTaxID = taxId,
                            IsActive = true, // 順便補上軟刪除的預設啟用狀態
                            JoinDate = DateTime.Now
                        };
                        db.Members.Add(newMember);
                        db.SaveChanges();
                        UIMessageBox.ShowSuccess("新增會員成功！");
                    }
                    else
                    {
                        // 修改模式
                        var member = db.Members.Find(_currentMemberId);
                        if (member != null)
                        {
                            member.MemberName = txtName.Text.Trim();
                            member.Phone = phone;
                            member.LevelID = Convert.ToInt32(cboLevel.SelectedValue);
                            member.Point = points;
                            member.DefaultCarrierType = carrierType;
                            member.DefaultCarrierNum = carrierNum;
                            member.DefaultTaxID = taxId;

                            db.SaveChanges();
                            UIMessageBox.ShowSuccess("會員資料更新成功！");
                        }
                    }
                }
                ExecuteSearch(); // 儲存後保持當前的搜尋狀態
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"儲存失敗：{ex.Message}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentMemberId == 0) return;

            if (UIMessageBox.ShowAsk($"確定要刪除會員「{txtName.Text}」嗎？\n此動作無法復原"))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var member = db.Members.Find(_currentMemberId);
                        if (member != null)
                        {
                            member.IsActive = false;

                            db.SaveChanges();
                            UIMessageBox.ShowSuccess("會員已成功刪除！");
                        }
                    }
                    ClearEditPanel();
                    ExecuteSearch();
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"刪除失敗：{ex.Message}");
                }
            }
        }
    }
}