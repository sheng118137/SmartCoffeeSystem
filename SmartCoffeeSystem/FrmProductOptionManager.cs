using Sunny.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models; // 你的 EF Models 命名空間

namespace SmartCoffeeSystem
{
    public partial class FrmProductOptionManager : UIForm
    {
        private int _productId;
        private string _productName;
        private int _currentGroupId = 0;

        public FrmProductOptionManager()
        {
            InitializeComponent();
        }

        public FrmProductOptionManager(int productId, string productName) : this()
        {
            _productId = productId;
            _productName = productName;
            lblProductName.Text = $"  目前設定商品：{_productName}";

            dgvGroups.AutoGenerateColumns = false;
            dgvItems.AutoGenerateColumns = false;

            // 綁左邊對應ProductOptionGroup
            colGroupId.DataPropertyName = "GroupID";
            colGroupName.DataPropertyName = "GroupName";
            // colIsRequired 已經被拔除，所以不用綁定

            //綁右邊對應ProductOptionItem)
            colItemId.DataPropertyName = "ItemID";
            colItemName.DataPropertyName = "ItemName";
            colExtraPrice.DataPropertyName = "ExtraPrice";
            colItemSort.DataPropertyName = "DisplayOrder";

            dgvGroups.SelectionChanged += DgvGroups_SelectionChanged;

            LoadGroups();
        }

        // 左邊群組
        private void LoadGroups()
        {
            try
            {
                using (var db = new POSContext())
                {
                    //Mapping表找出這個商品綁定了哪些
                    var groups = (from m in db.ProductOptionMappings
                                  join g in db.ProductOptionGroups on m.GroupID equals g.GroupID
                                  where m.ProductID == _productId
                                  orderby g.DisplayOrder
                                  select new
                                  {
                                      GroupID = g.GroupID,
                                      GroupName = g.GroupName
                                  }).ToList();

                    dgvGroups.DataSource = null;
                    dgvGroups.DataSource = groups;

                    if (groups.Count == 0)
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



        // 右邊項明細
        private void LoadItems()
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
                    //不需要 ?? 0，因為 ExtraPrice 和 DisplayOrder 都是純 int
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
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取明細失敗：{ex.Message}");
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            // 燈燈燈燈燈...又一個新Form= =
            FrmSelectGroup frm = new FrmSelectGroup();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        int groupIdToMap = 0;
                        string name = frm.SelectedGroupName;

                        if (frm.IsNewGroup)
                        {
                            // 雖然說使用者要建新的，但我們還是防呆一下，看他輸入的名字是不是剛好資料庫有
                            var existing = db.ProductOptionGroups.FirstOrDefault(g => g.GroupName == name);
                            if (existing != null)
                            {
                                groupIdToMap = existing.GroupID;
                            }
                            else
                            {
                                //真的沒有，幫他建一個全新的群組！
                                int maxOrder = db.ProductOptionGroups.Any() ? db.ProductOptionGroups.Max(g => g.DisplayOrder) : 0;
                                var newGroup = new ProductOptionGroup
                                {
                                    GroupName = name,
                                    DisplayOrder = maxOrder + 1
                                };
                                db.ProductOptionGroups.Add(newGroup);
                                db.SaveChanges(); // 存檔取得新 ID

                                groupIdToMap = newGroup.GroupID;
                            }
                        }
                        else
                        {
                            //使用者直接從下拉選單選的現有群組
                            groupIdToMap = frm.SelectedGroupID;
                        }

                        //檢查這個群組是不是已經綁定過這個商品
                        bool alreadyMapped = db.ProductOptionMappings.Any(m => m.ProductID == _productId && m.GroupID == groupIdToMap);
                        if (alreadyMapped)
                        {
                            UIMessageBox.ShowWarning($"此商品已經綁定過「{name}」群組了！");
                            return;
                        }

                        //建關聯
                        var newMapping = new ProductOptionMapping
                        {
                            ProductID = _productId,
                            GroupID = groupIdToMap
                        };
                        db.ProductOptionMappings.Add(newMapping);
                        db.SaveChanges();
                    }

                    //刷新左邊群組
                    LoadGroups();
                    UIMessageBox.ShowSuccess($"成功綁定「{frm.SelectedGroupName}」群組！");
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"綁定失敗：{ex.Message}");
                }
            }
        }
        private void btnDelGroup_Click(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow == null) return;

            int groupId = Convert.ToInt32(dgvGroups.CurrentRow.Cells["colGroupId"].Value);
            string groupName = dgvGroups.CurrentRow.Cells["colGroupName"].Value.ToString();

            if (UIMessageBox.ShowAsk($"確定要將「{groupName}」從此商品中移除嗎？\n(此動作僅解除綁定，不會刪除群組本身的資料)"))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var mapping = db.ProductOptionMappings.FirstOrDefault(m => m.ProductID == _productId && m.GroupID == groupId);
                        if (mapping != null)
                        {
                            db.ProductOptionMappings.Remove(mapping);
                            db.SaveChanges();
                        }
                    }
                    LoadGroups();
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"移除失敗：{ex.Message}");
                }
            }

        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null) return;

            int itemId = Convert.ToInt32(dgvItems.CurrentRow.Cells["colItemId"].Value);
            string itemName = dgvItems.CurrentRow.Cells["colItemName"].Value.ToString();

            if (UIMessageBox.ShowAsk($"確定要刪除選項明細「{itemName}」嗎？\n(注意：修改會影響所有綁定此群組的商品！)"))
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
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"刪除失敗：{ex.Message}");
                }
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (_currentGroupId == 0)
            {
                UIMessageBox.ShowWarning("請先在左側選擇或新增一個「選項群組」！");
                return;
            }

            FrmInput frm = new FrmInput("新增選項明細", "請輸入格式：[名稱],[加價金額]\n範例：加珍珠,15  (不加價請輸入 0)");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                string input = frm.InputText;
                string[] parts = input.Split(',');

                if (parts.Length != 2)
                {
                    UIMessageBox.ShowError("輸入格式錯誤！請用半形逗號分隔名稱與金額。");
                    return;
                }

                string name = parts[0].Trim();
                if (!int.TryParse(parts[1].Trim(), out int price))
                {
                    UIMessageBox.ShowError("加價金額必須是數字！");
                    return;
                }

                try
                {
                    using (var db = new POSContext())
                    {
                        int maxSort = db.ProductOptionItems.Where(i => i.GroupID == _currentGroupId).Any()
                         ? db.ProductOptionItems.Where(i => i.GroupID == _currentGroupId).Max(i => i.DisplayOrder): 0;

                        var newItem = new ProductOptionItem
                        {
                            GroupID = _currentGroupId,
                            ItemName = name,
                            ExtraPrice = price,
                            DisplayOrder = maxSort + 1
                        };
                        db.ProductOptionItems.Add(newItem);
                        db.SaveChanges();
                    }
                    LoadItems();
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"新增失敗：{ex.Message}");
                }
            }
        }
    }
}