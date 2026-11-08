using Sunny.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_GlobalOptionManager : UserControl
    {
        private int _currentGroupId = 0;
        private bool _isLoaded = false;

        public UC_GlobalOptionManager()
        {
            InitializeComponent();
            this.Load += UC_GlobalOptionManager_Load;
        }

        private void UC_GlobalOptionManager_Load(object sender, EventArgs e)
        {
            dgvGroups.AutoGenerateColumns = false;
            dgvItems.AutoGenerateColumns = false;

            colGroupId.DataPropertyName = "GroupID";
            colGroupName.DataPropertyName = "GroupName";
            colGroupSort.DataPropertyName = "DisplayOrder";

            colItemId.DataPropertyName = "ItemID";
            colItemName.DataPropertyName = "ItemName";
            colExtraPrice.DataPropertyName = "ExtraPrice";
            colItemSort.DataPropertyName = "DisplayOrder";

            dgvGroups.SelectionChanged += DgvGroups_SelectionChanged;

            _isLoaded = true;
            LoadGroups();
        }

        // 左全域選項群組
        private void LoadGroups(int selectId = 0)
        {
            if (!_isLoaded) return;

            try
            {
                using (var db = new POSContext())
                {
                    var groups = db.ProductOptionGroups
                        .OrderBy(g => g.DisplayOrder)
                        .Select(g => new
                        {
                            GroupID = g.GroupID,
                            GroupName = g.GroupName,
                            DisplayOrder = g.DisplayOrder
                        }).ToList();

                    //暫時解除綁定，避免觸發SelectionChanged頻繁讀取右邊
                    dgvGroups.SelectionChanged -= DgvGroups_SelectionChanged;

                    dgvGroups.DataSource = null;
                    dgvGroups.DataSource = groups;

                    dgvGroups.SelectionChanged += DgvGroups_SelectionChanged;

                    if (groups.Count > 0)
                    {
                        if (selectId > 0)
                        {
                            // 找回剛剛選取的那一列
                            foreach (DataGridViewRow row in dgvGroups.Rows)
                            {
                                if (Convert.ToInt32(row.Cells["colGroupId"].Value) == selectId)
                                {
                                    dgvGroups.CurrentCell = row.Cells["colGroupName"];
                                    break;
                                }
                            }
                        }
                        else
                        {
                            // 預設選第一列
                            dgvGroups.CurrentCell = dgvGroups.Rows[0].Cells["colGroupName"];
                        }
                        //觸發一次讀右邊明細
                        DgvGroups_SelectionChanged(null, null);
                    }
                    else
                    {
                        _currentGroupId = 0;
                        LoadItems();
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取群組失敗：{ex.Message}");
            }
        }

        private void DgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow != null)
            {
                _currentGroupId = Convert.ToInt32(dgvGroups.CurrentRow.Cells["colGroupId"].Value);
                string groupName = dgvGroups.CurrentRow.Cells["colGroupName"].Value.ToString();

                lblItemTitle.Text = $"「{groupName}」的選項明細";
                LoadItems();
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            FrmInput frm = new FrmInput("新增全域選項群組", "請輸入群組名稱 (例如: 冰塊, 甜度)");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string name = frm.InputText;
                try
                {
                    using (var db = new POSContext())
                    {
                        if (db.ProductOptionGroups.Any(g => g.GroupName == name))
                        {
                            UIMessageBox.ShowWarning("已經有相同名稱的群組了！");
                            return;
                        }

                        int maxOrder = db.ProductOptionGroups.Any() ? db.ProductOptionGroups.Max(g => g.DisplayOrder) : 0;
                        var newGroup = new ProductOptionGroup
                        {
                            GroupName = name,
                            DisplayOrder = maxOrder + 1
                        };
                        db.ProductOptionGroups.Add(newGroup);
                        db.SaveChanges();
                    }
                    LoadGroups();
                    UIMessageBox.ShowSuccess("新增群組成功！");
                }
                catch (Exception ex) { UIMessageBox.ShowError(ex.Message); }
            }
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow == null) return;

            int groupId = Convert.ToInt32(dgvGroups.CurrentRow.Cells["colGroupId"].Value);
            string oldName = dgvGroups.CurrentRow.Cells["colGroupName"].Value.ToString();

            FrmInput frm = new FrmInput("修改群組名稱", "請輸入新的群組名稱：", oldName);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string newName = frm.InputText;
                if (newName == oldName) return;

                try
                {
                    using (var db = new POSContext())
                    {
                        if (db.ProductOptionGroups.Any(g => g.GroupName == newName && g.GroupID != groupId))
                        {
                            UIMessageBox.ShowWarning("已經有相同名稱的群組了！");
                            return;
                        }

                        var group = db.ProductOptionGroups.Find(groupId);
                        if (group != null)
                        {
                            group.GroupName = newName;
                            db.SaveChanges();
                        }
                    }
                    LoadGroups(groupId); // 保持選取狀態
                }
                catch (Exception ex) { UIMessageBox.ShowError(ex.Message); }
            }
        }

        private void btnDelGroup_Click(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow == null) return;

            int groupId = Convert.ToInt32(dgvGroups.CurrentRow.Cells["colGroupId"].Value);
            string groupName = dgvGroups.CurrentRow.Cells["colGroupName"].Value.ToString();

            try
            {
                using (var db = new POSContext())
                {
                    bool isUsed = db.ProductOptionMappings.Any(m => m.GroupID == groupId);
                    if (isUsed)
                    {
                        UIMessageBox.ShowWarning($"警告！【{groupName}】目前已經被綁定到某些商品上。\n請先解除綁定後，才能刪除此群組！");
                        return;
                    }

                    if (UIMessageBox.ShowAsk($"確定要永久刪除群組「{groupName}」及其所有明細嗎？\n(此動作無法復原！)"))
                    {
                        var items = db.ProductOptionItems.Where(i => i.GroupID == groupId).ToList();
                        db.ProductOptionItems.RemoveRange(items);

                        var group = db.ProductOptionGroups.Find(groupId);
                        if (group != null) db.ProductOptionGroups.Remove(group);

                        db.SaveChanges();
                        LoadGroups();
                        UIMessageBox.ShowSuccess("刪除成功！");
                    }
                }
            }
            catch (Exception ex) { UIMessageBox.ShowError(ex.Message); }
        }

        private void btnGroupUp_Click(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow == null || dgvGroups.CurrentRow.Index <= 0) return; // 已經在最上面

            int currentIndex = dgvGroups.CurrentRow.Index;
            int currentId = Convert.ToInt32(dgvGroups.Rows[currentIndex].Cells["colGroupId"].Value);
            int prevId = Convert.ToInt32(dgvGroups.Rows[currentIndex - 1].Cells["colGroupId"].Value);

            SwapGroupSort(currentId, prevId);
        }

        private void btnGroupDown_Click(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow == null || dgvGroups.CurrentRow.Index >= dgvGroups.Rows.Count - 1) return; // 已經在最下面

            int currentIndex = dgvGroups.CurrentRow.Index;
            int currentId = Convert.ToInt32(dgvGroups.Rows[currentIndex].Cells["colGroupId"].Value);
            int nextId = Convert.ToInt32(dgvGroups.Rows[currentIndex + 1].Cells["colGroupId"].Value);

            SwapGroupSort(currentId, nextId);
        }

        private void SwapGroupSort(int id1, int id2)
        {
            try
            {
                using (var db = new POSContext())
                {
                    var obj1 = db.ProductOptionGroups.Find(id1);
                    var obj2 = db.ProductOptionGroups.Find(id2);

                    if (obj1 != null && obj2 != null)
                    {
                        int temp = obj1.DisplayOrder;
                        obj1.DisplayOrder = obj2.DisplayOrder;
                        obj2.DisplayOrder = temp;
                        db.SaveChanges();
                    }
                }
                LoadGroups(id1); // 重新載入，並維持選中原本那一列
            }
            catch (Exception ex) { UIMessageBox.ShowError(ex.Message); }
        }

        // 右-全域選項明細
        private void LoadItems(int selectId = 0)
        {
            if (_currentGroupId == 0)
            {
                dgvItems.DataSource = null;
                return;
            }

            try
            {
                using (var db = new POSContext())
                {
                    var items = db.ProductOptionItems
                        .Where(i => i.GroupID == _currentGroupId)
                        .OrderBy(i => i.DisplayOrder)
                        .Select(i => new
                        {
                            ItemID = i.ItemID,
                            ItemName = i.ItemName,
                            ExtraPrice = i.ExtraPrice,
                            DisplayOrder = i.DisplayOrder
                        }).ToList();

                    dgvItems.DataSource = null;
                    dgvItems.DataSource = items;

                    if (selectId > 0 && items.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvItems.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["colItemId"].Value) == selectId)
                            {
                                dgvItems.CurrentCell = row.Cells["colItemName"];
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取明細失敗：{ex.Message}");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (_currentGroupId == 0)
            {
                UIMessageBox.ShowWarning("請先在左側選擇一個群組！");
                return;
            }

            FrmInput frm = new FrmInput("新增選項明細", "請輸入格式：[名稱],[加價金額]\n範例：加珍珠,15  (不加價請輸入 0)");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string[] parts = frm.InputText.Split(',');
                if (parts.Length != 2 || !int.TryParse(parts[1].Trim(), out int price))
                {
                    UIMessageBox.ShowError("輸入格式錯誤！請用半形逗號分隔名稱與數字金額。");
                    return;
                }

                try
                {
                    using (var db = new POSContext())
                    {
                        int maxSort = db.ProductOptionItems.Where(i => i.GroupID == _currentGroupId).Any()
                                      ? db.ProductOptionItems.Where(i => i.GroupID == _currentGroupId).Max(i => i.DisplayOrder) : 0;

                        var newItem = new ProductOptionItem
                        {
                            GroupID = _currentGroupId,
                            ItemName = parts[0].Trim(),
                            ExtraPrice = price,
                            DisplayOrder = maxSort + 1
                        };
                        db.ProductOptionItems.Add(newItem);
                        db.SaveChanges();
                    }
                    LoadItems();
                }
                catch (Exception ex) { UIMessageBox.ShowError(ex.Message); }
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null) return;

            int itemId = Convert.ToInt32(dgvItems.CurrentRow.Cells["colItemId"].Value);
            string oldName = dgvItems.CurrentRow.Cells["colItemName"].Value.ToString();
            string oldPrice = dgvItems.CurrentRow.Cells["colExtraPrice"].Value.ToString();

            FrmInput frm = new FrmInput("修改選項明細", "請輸入格式：[名稱],[加價金額]", $"{oldName},{oldPrice}");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string[] parts = frm.InputText.Split(',');
                if (parts.Length != 2 || !int.TryParse(parts[1].Trim(), out int newPrice))
                {
                    UIMessageBox.ShowError("輸入格式錯誤！");
                    return;
                }

                try
                {
                    using (var db = new POSContext())
                    {
                        var item = db.ProductOptionItems.Find(itemId);
                        if (item != null)
                        {
                            item.ItemName = parts[0].Trim();
                            item.ExtraPrice = newPrice;
                            db.SaveChanges();
                        }
                    }
                    LoadItems(itemId);
                }
                catch (Exception ex) { UIMessageBox.ShowError(ex.Message); }
            }
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null) return;

            int itemId = Convert.ToInt32(dgvItems.CurrentRow.Cells["colItemId"].Value);
            string itemName = dgvItems.CurrentRow.Cells["colItemName"].Value.ToString();

            if (UIMessageBox.ShowAsk($"確定要永久刪除明細「{itemName}」嗎？\n(注意：這會影響所有正在使用此群組的商品！) "))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var item = db.ProductOptionItems.Find(itemId);
                        if (item != null)
                        {
                            db.ProductOptionItems.Remove(item);
                            db.SaveChanges();
                        }
                    }
                    LoadItems();
                }
                catch (Exception ex) { UIMessageBox.ShowError(ex.Message); }
            }
        }

        private void btnItemUp_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null || dgvItems.CurrentRow.Index <= 0) return;

            int currentIndex = dgvItems.CurrentRow.Index;
            int currentId = Convert.ToInt32(dgvItems.Rows[currentIndex].Cells["colItemId"].Value);
            int prevId = Convert.ToInt32(dgvItems.Rows[currentIndex - 1].Cells["colItemId"].Value);

            SwapItemSort(currentId, prevId);
        }

        private void btnItemDown_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null || dgvItems.CurrentRow.Index >= dgvItems.Rows.Count - 1) return;

            int currentIndex = dgvItems.CurrentRow.Index;
            int currentId = Convert.ToInt32(dgvItems.Rows[currentIndex].Cells["colItemId"].Value);
            int nextId = Convert.ToInt32(dgvItems.Rows[currentIndex + 1].Cells["colItemId"].Value);

            SwapItemSort(currentId, nextId);
        }

        private void SwapItemSort(int id1, int id2)
        {
            try
            {
                using (var db = new POSContext())
                {
                    var obj1 = db.ProductOptionItems.Find(id1);
                    var obj2 = db.ProductOptionItems.Find(id2);

                    if (obj1 != null && obj2 != null)
                    {
                        int temp = obj1.DisplayOrder;
                        obj1.DisplayOrder = obj2.DisplayOrder;
                        obj2.DisplayOrder = temp;
                        db.SaveChanges();
                    }
                }
                LoadItems(id1);
            }
            catch (Exception ex) { UIMessageBox.ShowError(ex.Message); }
        }
    }
}