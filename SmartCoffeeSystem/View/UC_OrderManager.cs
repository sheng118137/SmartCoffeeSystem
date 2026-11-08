using Sunny.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_OrderManager : UserControl
    {
        private bool _isLoaded = false;

        public UC_OrderManager()
        {
            InitializeComponent();
            this.Load += UC_OrderManager_Load;
        }

        private void UC_OrderManager_Load(object sender, EventArgs e)
        {
            // 關閉自動產生的欄位
            dgvOrders.AutoGenerateColumns = false;
            dgvDetails.AutoGenerateColumns = false;

            // 綁定左側訂單表
            colOrderID.DataPropertyName = "OrderID";
            colOrderDate.DataPropertyName = "OrderDate";
            colMemberName.DataPropertyName = "MemberName";
            colTotalAmount.DataPropertyName = "TotalAmount";
            colStatus.DataPropertyName = "StatusText";

            // 綁定右側明細表
            colProductName.DataPropertyName = "ProductName";
            colOptions.DataPropertyName = "OptionsText"; // 客製化選項
            colUnitPrice.DataPropertyName = "UnitPrice";
            colQty.DataPropertyName = "Quantity";
            colSubTotal.DataPropertyName = "SubTotal";

            // 初始化日期區間 (預設顯示今天)
            dpStart.Value = DateTime.Today.AddDays(-7);
            dpEnd.Value = DateTime.Today.AddDays(1).AddSeconds(-1); //今天的 23:59:59

            // 初始化狀態下拉選單
            cboStatus.Items.Clear();
            cboStatus.Items.Add("全部訂單");
            cboStatus.Items.Add("製作中");
            cboStatus.Items.Add("已完成");
            cboStatus.Items.Add("已作廢");
            cboStatus.SelectedIndex = 0; // 預設看全部

            //初始化顧客類型下拉選單
            if (cboMemberType != null)
            {
                cboMemberType.Items.Clear();
                cboMemberType.Items.Add("全部顧客");
                cboMemberType.Items.Add("會員訂單");
                cboMemberType.Items.Add("非會員訂單");
                cboMemberType.SelectedIndex = 0; // 預設看全部
            }

            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;

            _isLoaded = true;
            LoadOrders();
        }

        // 搜尋與過濾
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            if (!_isLoaded) return;

            DateTime startDate = dpStart.Value.Date;
            DateTime endDate = dpEnd.Value.Date.AddDays(1).AddSeconds(-1); // 確保包涵結束日期的整天

            try
            {
                using (var db = new POSContext())
                {
                    //確保有 Select 出 MemberID，後面才能用來判斷是不是會員
                    var query = from o in db.Orders
                                join m in db.Members on o.MemberID equals m.MemberID into memberGroup
                                from m in memberGroup.DefaultIfEmpty() // Left Join
                                where o.OrderDate >= startDate && o.OrderDate <= endDate
                                select new
                                {
                                    OrderID = o.OrderID,
                                    OrderDate = o.OrderDate,
                                    OrderStatus = o.OrderStatus,
                                    MemberID = o.MemberID, // 🌟 抓出 MemberID 供後續過濾使用
                                    FinalAmount = o.FinalAmount,
                                    MemberName = m != null ? m.MemberName : "非會員"
                                };

                    //狀態cbox
                    if (cboStatus.SelectedIndex == 1) query = query.Where(o => o.OrderStatus == 1);
                    else if (cboStatus.SelectedIndex == 2) query = query.Where(o => o.OrderStatus == 2);
                    else if (cboStatus.SelectedIndex == 3) query = query.Where(o => o.OrderStatus == 3);
                    //過濾會員Cboxx
                    if (cboMemberType != null)
                    {
                        if (cboMemberType.SelectedIndex == 1)
                            query = query.Where(o => o.MemberID != null); // 會員訂單 (有 MemberID)
                        else if (cboMemberType.SelectedIndex == 2)
                            query = query.Where(o => o.MemberID == null); // 非會員訂單 (沒有 MemberID)
                    }

                    var orders = query
                        .OrderByDescending(o => o.OrderDate) // 最新訂單在最上面
                        .ToList()
                        .Select(o => new
                        {
                            OrderID = o.OrderID,
                            OrderDate = o.OrderDate?.ToString("yyyy/MM/dd HH:mm"),
                            MemberName = o.MemberName,
                            TotalAmount = o.FinalAmount,
                            StatusText = GetStatusText(o.OrderStatus)
                        }).ToList();

                    dgvOrders.DataSource = null;
                    dgvOrders.DataSource = orders;

                    if (orders.Count == 0)
                    {
                        dgvDetails.DataSource = null;
                        lblDetailTitle.Text = "訂單明細";
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取訂單失敗：{ex.Message}");
            }
        }

        private string GetStatusText(byte? status)
        {
            if (status == 1) return "製作中";
            if (status == 2) return "已完成";
            if (status == 3) return "已作廢";
            return "未知";
        }

        // 左訂單選取連動右側明細
        private void DgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                int orderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["colOrderID"].Value);
                lblDetailTitle.Text = $"訂單明細 (單號：{orderId})";
                LoadOrderDetails(orderId);
            }
        }

        private void LoadOrderDetails(int orderId)
        {
            try
            {
                using (var db = new POSContext())
                {
                    var details = db.OrderDetails
                        .Where(d => d.OrderID == orderId)
                        .Select(d => new
                        {
                            ProductName = d.ProductName,
                            OptionsText = d.SpecString ?? "",
                            UnitPrice = d.UnitPrice,
                            Quantity = d.Quantity,
                            SubTotal = d.Subtotal
                        }).ToList();

                    dgvDetails.DataSource = null;
                    dgvDetails.DataSource = details;
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取明細失敗：{ex.Message}");
            }
        }

        // 作廢訂單
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;

            int orderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["colOrderID"].Value);
            string currentStatus = dgvOrders.CurrentRow.Cells["colStatus"].Value.ToString();

            if (currentStatus == "已作廢")
            {
                UIMessageBox.ShowWarning("此訂單已經是作廢狀態囉！");
                return;
            }

            if (UIMessageBox.ShowAsk($"確定要將訂單【{orderId}】作廢嗎？\n(作廢後金額將不計入營收)"))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var order = db.Orders.Find(orderId);
                        if (order != null)
                        {
                            order.OrderStatus = 3; //代表作廢
                            db.SaveChanges();
                        }
                    }
                    UIMessageBox.ShowSuccess("訂單作廢成功！");
                    LoadOrders(); // 重新整理列表
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"作廢失敗：{ex.Message}");
                }
            }
        }

        private void btnRestoreOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;

            int orderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["colOrderID"].Value);
            string currentStatus = dgvOrders.CurrentRow.Cells["colStatus"].Value.ToString();

            if (currentStatus != "已作廢")
            {
                UIMessageBox.ShowWarning("此訂單並非作廢狀態，不需要恢復！");
                return;
            }

            if (UIMessageBox.ShowAsk($"確定要將已作廢的訂單【{orderId}】恢復嗎？\n(恢復後將重新計入營收)"))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var order = db.Orders.Find(orderId);
                        if (order != null)
                        {
                            //預設把它改回已完成
                            order.OrderStatus = 2;
                            db.SaveChanges();
                        }
                    }
                    UIMessageBox.ShowSuccess("訂單已成功恢復！");
                    LoadOrders(); //重整表
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"恢復失敗：{ex.Message}");
                }
            }
        }
    }
}