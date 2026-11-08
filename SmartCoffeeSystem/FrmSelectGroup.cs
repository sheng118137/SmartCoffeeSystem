using Sunny.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem
{
    public partial class FrmSelectGroup : UIForm
    {
        // 給外部讀取的結果
        public int SelectedGroupID { get; private set; }
        public string SelectedGroupName { get; private set; }
        public bool IsNewGroup { get; private set; }

        public FrmSelectGroup()
        {
            InitializeComponent();
            LoadExistingGroups();
        }

        private void LoadExistingGroups()
        {
            try
            {
                using (var db = new POSContext())
                {
                    // 撈出所有現存的群組供使用者選擇
                    var groups = db.ProductOptionGroups.OrderBy(g => g.DisplayOrder).ToList();

                    cboExisting.DataSource = groups;
                    cboExisting.DisplayMember = "GroupName";
                    cboExisting.ValueMember = "GroupID";
                    cboExisting.SelectedIndex = -1; // 預設不選
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("載入現有群組失敗：" + ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 邏輯 1：如果使用者有在「新增欄位」打字，優先建立新的！
            string newGroup = txtNewGroup.Text.Trim();
            if (!string.IsNullOrEmpty(newGroup))
            {
                SelectedGroupName = newGroup;
                IsNewGroup = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // 邏輯 2：如果沒有打字，檢查是否有選擇下拉選單？
            if (cboExisting.SelectedValue != null)
            {
                SelectedGroupID = Convert.ToInt32(cboExisting.SelectedValue);
                SelectedGroupName = cboExisting.Text;
                IsNewGroup = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            // 都沒有的話，擋下來
            UIMessageBox.ShowWarning("請從下拉選單選擇一個群組，或是輸入新群組的名稱！");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}