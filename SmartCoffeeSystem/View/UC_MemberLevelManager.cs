using Sunny.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_MemberLevelManager : UserControl
    {
        private bool _isLoaded = false;
        private int _currentLevelId = 0;

        public UC_MemberLevelManager()
        {
            InitializeComponent();
            this.Load += UC_MemberLevelManager_Load;
        }

        private void UC_MemberLevelManager_Load(object sender, EventArgs e)
        {
            dgvLevels.AutoGenerateColumns = false;

            colLevelID.DataPropertyName = "LevelID";
            colLevelName.DataPropertyName = "LevelName";
            colDiscount.DataPropertyName = "DiscountRate";
            colMultiplier.DataPropertyName = "PointMultiplier";
            colUpgradeCost.DataPropertyName = "UpgradeCost";

            dgvLevels.SelectionChanged += DgvLevels_SelectionChanged;

            LoadLevels();
            _isLoaded = true;
        }

        private void LoadLevels()
        {
            try
            {
                using (var db = new POSContext())
                {
                    var levels = db.MemberLevels.OrderBy(l => l.PointMultiplier).ToList();

                    dgvLevels.DataSource = null;
                    dgvLevels.DataSource = levels;

                    if (levels.Count == 0)
                    {
                        ClearEditPanel();
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取會員等級失敗：{ex.Message}");
            }
        }

        private void DgvLevels_SelectionChanged(object sender, EventArgs e)
        {
            if (!_isLoaded || dgvLevels.CurrentRow == null) return;

            int levelId = Convert.ToInt32(dgvLevels.CurrentRow.Cells["colLevelID"].Value);
            LoadLevelDetails(levelId);
        }

        private void LoadLevelDetails(int levelId)
        {
            try
            {
                using (var db = new POSContext())
                {
                    var level = db.MemberLevels.Find(levelId);
                    if (level != null)
                    {
                        _currentLevelId = level.LevelID;
                        lblEditTitle.Text = $"編輯等級 (ID: {level.LevelID})";
                        lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(80, 160, 255);

                        txtLevelName.Text = level.LevelName;
                        txtDiscount.Text = level.DiscountRate.ToString("0.00");
                        txtMultiplier.Text = level.PointMultiplier.ToString("0.00");
                        txtUpgradeCost.Text = level.UpgradeCost.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取等級詳細資料失敗：{ex.Message}");
            }
        }

        private void ClearEditPanel()
        {
            dgvLevels.SelectionChanged -= DgvLevels_SelectionChanged;

            _currentLevelId = 0;
            lblEditTitle.Text = "新增會員等級";
            lblEditTitle.ForeColor = System.Drawing.Color.FromArgb(110, 190, 40);

            txtLevelName.Text = "";
            txtDiscount.Text = "1.00";     // 預設不打折
            txtMultiplier.Text = "1.00";   // 預設1倍點數
            txtUpgradeCost.Text = "0";     // 預設不用扣點

            dgvLevels.CurrentCell = null;
            dgvLevels.ClearSelection();

            dgvLevels.SelectionChanged += DgvLevels_SelectionChanged;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearEditPanel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLevelName.Text))
            {
                UIMessageBox.ShowWarning("「等級名稱」為必填欄位！");
                return;
            }

            if (!decimal.TryParse(txtDiscount.Text, out decimal discount) || discount <= 0 || discount > 1)
            {
                UIMessageBox.ShowWarning("「結帳折扣」必須是 0.01 到 1.00 之間的數字！(例如 9折 請輸入 0.90)");
                return;
            }

            if (!decimal.TryParse(txtMultiplier.Text, out decimal multiplier) || multiplier < 0)
            {
                UIMessageBox.ShowWarning("「點數倍率」格式錯誤！(例如 1.5 倍請輸入 1.50)");
                return;
            }

            if (!int.TryParse(txtUpgradeCost.Text, out int upgradeCost) || upgradeCost < 0)
            {
                UIMessageBox.ShowWarning("「升級扣點」必須是 0 或正整數！");
                return;
            }

            try
            {
                using (var db = new POSContext())
                {
                    string levelName = txtLevelName.Text.Trim();
                    if (db.MemberLevels.Any(l => l.LevelName == levelName && l.LevelID != _currentLevelId))
                    {
                        UIMessageBox.ShowWarning("此「等級名稱」已經存在了！");
                        return;
                    }

                    if (_currentLevelId == 0)
                    {
                        var newLevel = new MemberLevel
                        {
                            LevelName = levelName,
                            DiscountRate = discount,
                            PointMultiplier = multiplier,
                            UpgradeCost = upgradeCost
                        };
                        db.MemberLevels.Add(newLevel);
                        db.SaveChanges();
                        UIMessageBox.ShowSuccess("新增等級成功！");
                    }
                    else
                    {
                        var level = db.MemberLevels.Find(_currentLevelId);
                        if (level != null)
                        {
                            level.LevelName = levelName;
                            level.DiscountRate = discount;
                            level.PointMultiplier = multiplier;
                            level.UpgradeCost = upgradeCost;

                            db.SaveChanges();
                            UIMessageBox.ShowSuccess("等級資料更新成功！");
                        }
                    }
                }
                LoadLevels();
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"儲存失敗：{ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentLevelId == 0) return;

            // 預設等級(通常是 ID = 1) 絕對不能刪除
            if (_currentLevelId == 1)
            {
                UIMessageBox.ShowWarning("系統預設的「一般會員」等級無法刪除！");
                return;
            }

            try
            {
                using (var db = new POSContext())
                {
                    // 🌟 防呆：檢查是否還有會員掛在這個等級下
                    if (db.Members.Any(m => m.LevelID == _currentLevelId))
                    {
                        UIMessageBox.ShowWarning("這個等級目前還有會員正在使用，無法刪除！\n請先將相關的會員轉移至其他等級。");
                        return;
                    }

                    if (UIMessageBox.ShowAsk($"確定要永久刪除「{txtLevelName.Text}」嗎？\n此動作無法復原！"))
                    {
                        var level = db.MemberLevels.Find(_currentLevelId);
                        if (level != null)
                        {
                            db.MemberLevels.Remove(level);
                            db.SaveChanges();
                            UIMessageBox.ShowSuccess("等級已成功刪除！");
                        }
                        ClearEditPanel();
                        LoadLevels();
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"刪除失敗：{ex.Message}");
            }
        }
    }
}