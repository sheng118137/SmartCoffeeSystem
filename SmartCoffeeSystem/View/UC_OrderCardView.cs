using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_OrderCardView : UserControl
    {
        private Timer _autoRefreshTimer;

        public UC_OrderCardView()
        {
            InitializeComponent();
            this.Load += UC_OrderCardView_Load;
            this.HandleDestroyed += UC_OrderCardView_HandleDestroyed;//綁畫面關閉停用計時器,不然記憶體一直往上


            // 初始化計時器
            _autoRefreshTimer = new Timer();
            _autoRefreshTimer.Interval = 5000; // 5000 毫秒 = 5 秒
            _autoRefreshTimer.Tick += _autoRefreshTimer_Tick;
        }

        private void UC_OrderCardView_Load(object sender, EventArgs e)
        {
            LoadPendingOrders();

            //畫面載入時計時器啟動~
            _autoRefreshTimer.Start();
        }

        //當UserControl被關閉或切換掉時GC避免浪費資源，本來這邊想Override寫Despose,結果,Designer已經有了....改用其他的名稱
        private void UC_OrderCardView_HandleDestroyed(object sender, EventArgs e)
        {
            if (_autoRefreshTimer != null)
            {
                _autoRefreshTimer.Stop();
                _autoRefreshTimer.Dispose();
            }
        }
        private void _autoRefreshTimer_Tick(object sender, EventArgs e)
        {
            //時間一到自動執行一次重新載入
            LoadPendingOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //手動點更新也先停掉計時器，做完再重開不然狀一起就好笑了
            _autoRefreshTimer.Stop();
            LoadPendingOrders();
            _autoRefreshTimer.Start();
        }

        private void LoadPendingOrders()
        {
            //清除卡片前紀錄目前的捲軸位置
            int scrollPosition = flowLayoutPanelCards.AutoScrollPosition.Y;

            //避免畫面一直狂閃~SuspendLayout()來先暫停繪製
            flowLayoutPanelCards.SuspendLayout();

            //記面上所有的訂單ID，用來比對有沒有變動
            var currentOrderIds = flowLayoutPanelCards.Controls.OfType<UC_OrderCard>().Select(c => c.Tag?.ToString()).ToList();

            try
            {
                using (var db = new POSContext())
                {
                    DateTime today = DateTime.Today;
                    var pendingOrders = db.Orders
                        .Where(o => o.OrderStatus == 1 && o.OrderDate >= today)
                        .OrderBy(o => o.OrderDate)
                        .ToList();

                    if (pendingOrders.Count == 0)
                    {
                        flowLayoutPanelCards.Controls.Clear();
                        lblEmpty.Visible = true;
                        return;
                    }

                    lblEmpty.Visible = false;

                    //檢查資料庫抓到的訂單ID跟畫面上現有的訂單ID是不是完全一樣
                    var newOrderIds = pendingOrders.Select(o => o.OrderID.ToString()).ToList();
                    bool isSame = currentOrderIds.SequenceEqual(newOrderIds);

                    //如果完全一樣代表沒新單進來不重畫卡片
                    if (!isSame)
                    {
                        flowLayoutPanelCards.Controls.Clear();

                        foreach (var order in pendingOrders)
                        {
                            var details = db.OrderDetails.Where(d => d.OrderID == order.OrderID).ToList();

                            UC_OrderCard card = new UC_OrderCard(
                                orderId: order.OrderID,
                                orderType: order.OrderType ?? "內用",
                                orderTime: order.OrderDate ?? DateTime.Now,
                                details: details
                            );

                            card.Tag = order.OrderID.ToString(); //ID存Tag方便比對

                            card.OrderCompleted += (s, ev) =>
                            {
                                _autoRefreshTimer.Stop();
                                LoadPendingOrders();
                                _autoRefreshTimer.Start();
                            };

                            flowLayoutPanelCards.Controls.Add(card);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //5秒跳一次錯誤視窗,太奇怪,所以先用用Console
                Console.WriteLine($"自動更新讀取後廚訂單失敗：{ex.Message}");
            }
            finally
            {
                //恢復繪製並把捲軸拉回原本的地方
                flowLayoutPanelCards.ResumeLayout();
                if (Math.Abs(flowLayoutPanelCards.AutoScrollPosition.Y) != Math.Abs(scrollPosition))
                {
                    flowLayoutPanelCards.AutoScrollPosition = new System.Drawing.Point(0, Math.Abs(scrollPosition));
                }
            }
        }
    }
}