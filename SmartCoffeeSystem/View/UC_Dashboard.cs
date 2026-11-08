using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem
{
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private List<ProductView> allProductViews = new List<ProductView>();
        private List<OrderView> allOrderViews = new List<OrderView>();

        // 拖曳必須的變數
        private int dragRowIndex = -1; // 商品拖曳
        private Rectangle dragBoxFromMouseDown; // 商品拖曳緩衝區

        private int dragRowIndexOrder = -1; // 訂單拖曳
        private Rectangle dragBoxFromMouseDownOrder; // 訂單拖曳緩衝區

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvOrderData.AutoGenerateColumns = false;

            // 設定全列選取
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            colSort.DataPropertyName = "Sort";
            colProductId.DataPropertyName = "ProductID";
            colProductName.DataPropertyName = "ProductName";
            colCategory.DataPropertyName = "Category";
            colPrice.DataPropertyName = "Price";
            colStatus.DataPropertyName = "Status";

            OrdersID.DataPropertyName = "OrderID";
            OrderTime.DataPropertyName = "OrderDate";
            OrderType.DataPropertyName = "OrderType";
            Account.DataPropertyName = "FinalAmount";
            OrdersSort.DataPropertyName = "OrderSort";
            OrdersStatus.DataPropertyName = "StatusText";

            // 事件綁定
            ibtnReflash.Click += (s, ev) => LoadRealData();
            ibtnCreateProduct.Click += ibtnCreateProduct_Click;
            dgvProducts.CellDoubleClick += dgvProducts_CellClick;
            dgvProducts.KeyDown += dgvProducts_KeyDown;
            dgvOrderData.CellDoubleClick += dgvOrderData_CellDoubleClick;

            // 拖放排序商品
            dgvProducts.MouseDown += dgvProducts_MouseDown;
            dgvProducts.MouseMove += dgvProducts_MouseMove;
            dgvProducts.DragOver += dgvProducts_DragOver;
            dgvProducts.DragDrop += dgvProducts_DragDrop;

            // 拖放排序訂單
            dgvOrderData.MouseDown += dgvOrderData_MouseDown;
            dgvOrderData.MouseMove += dgvOrderData_MouseMove;
            dgvOrderData.DragOver += dgvOrderData_DragOver;
            dgvOrderData.DragDrop += dgvOrderData_DragDrop;

            LoadRealData();
        }

        private void LoadRealData()
        {
            using (var db = new POSContext())
            {
                DateTime now = DateTime.Now;
                DateTime thisMonthStart = new DateTime(now.Year, now.Month, 1);
                DateTime lastMonthStart = thisMonthStart.AddMonths(-1);

                DateTime today = now.Date;
                DateTime yesterday = today.AddDays(-1);
                DateTime tomorrow = today.AddDays(1);

                // 會員數
                var membersList = db.Members.ToList();
                lblMemberCount.Text = $"{membersList.Count}";

                int thisMonthMember = membersList.Count(m => m.JoinDate.Year == now.Year && m.JoinDate.Month == now.Month);
                int lastMonthMember = membersList.Count(m => m.JoinDate.Year == lastMonthStart.Year && m.JoinDate.Month == lastMonthStart.Month);
                SetTrendLabel(lblMemberLastMonth, thisMonthMember, lastMonthMember);


                // 商品數
                var rawProducts = db.Products.ToList();
                lblProductCount.Text = $"{rawProducts.Count}";

                int thisMonthProduct = rawProducts.Count(p => p.CreateAt.HasValue && p.CreateAt.Value.Year == now.Year && p.CreateAt.Value.Month == now.Month);
                int lastMonthProduct = rawProducts.Count(p => p.CreateAt.HasValue && p.CreateAt.Value.Year == lastMonthStart.Year && p.CreateAt.Value.Month == lastMonthStart.Month);
                SetTrendLabel(lblProductLastMonth, thisMonthProduct, lastMonthProduct);


                // 訂單數、營收
                var Orders = db.Orders.ToList();
                var recentOrders = Orders.Where(o => o.OrderDate >= yesterday && o.OrderDate < tomorrow).ToList();

                var todayOrders = recentOrders.Where(o => o.OrderDate >= today && o.OrderStatus!=3).ToList();
                var yesterdayOrders = recentOrders.Where(o => o.OrderDate >= yesterday && o.OrderDate < today).ToList();

                int todayOrderCount = todayOrders.Count;
                int yesterdayOrderCount = yesterdayOrders.Count;
                lblOrderCount.Text = $"{todayOrderCount}";
                SetTrendLabel(lblOrderLastDay, todayOrderCount, yesterdayOrderCount);

                double todayRevenue = todayOrders.Where(o => o.OrderStatus != 3).Sum(o => o.FinalAmount ?? 0);
                double yesterdayRevenue = yesterdayOrders.Where(o => o.OrderStatus != 3).Sum(o => o.FinalAmount ?? 0);
                lblCount.Text = $"$ {todayRevenue:#,0}";
                SetTrendLabel(lblRevenueLastDay, todayRevenue, yesterdayRevenue);


                //下方商品列表dgv
                var categoryList = db.Categories.ToList();

                allProductViews = rawProducts
                    .Select(p => new ProductView
                    {
                        Sort = p.Sort ?? 0,
                        ProductID = p.ProductID,
                        ProductName = p.ProductName,
                        Category = categoryList.FirstOrDefault(c => c.CategoryID == p.CategoryID)?.CategoryName ?? "未分類",
                        Price = p.Price,
                        Status = (p.IsActive == true) ? "上架中" : "下架中"
                    })
                    .OrderBy(x => x.Category)
                    .ToList();

                dgvProducts.DataSource = allProductViews;

                allOrderViews = Orders
                    .Select(o => new OrderView
                    {
                        OrderID = (int)o.OrderID,
                        OrderDate = o.OrderDate,
                        OrderType = o.OrderType,
                        FinalAmount = (int)(o.FinalAmount ?? 0),
                        OrderSort = (int)(o.OrderSort ?? 0),
                        StatusText = o.OrderStatus == 3 ? "已作廢" : (o.OrderStatus == 2 ? "已完成" : "製作中")
                    })
                    .OrderByDescending(o => o.StatusText)
                    .ToList();

                dgvOrderData.DataSource = allOrderViews;

                // 移除不需要的參數直接呼圖表更新
                LoadChartData();
            }
        }

        private void SetTrendLabel(Label lbl, double current, double previous)
        {
            double percentChange = 0;
            if (previous > 0) percentChange = ((current - previous) / previous) * 100;
            else if (current > 0) percentChange = 100;

            if (percentChange > 0)
            {
                lbl.Text = $"↑ {Math.Abs(percentChange):0.0}%";
                lbl.ForeColor = System.Drawing.Color.Red;
            }
            else if (percentChange < 0)
            {
                lbl.Text = $"↓ {Math.Abs(percentChange):0.0}%";
                lbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl.Text = "- 0.0%";
                lbl.ForeColor = System.Drawing.Color.DimGray;
            }
        }

        private void ibtnCreateProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductEditForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new POSContext())
                {
                    if (form.ProductEntity.Sort == null)
                    {
                        var maxSort = db.Products.Max(p => (int?)p.Sort) ?? 0;
                        form.ProductEntity.Sort = maxSort + 1;
                    }
                    if (form.ProductEntity.Stock == null)
                    {
                        form.ProductEntity.Stock = 0;
                    }
                    db.Products.Add(form.ProductEntity);
                    db.SaveChanges();
                }
                LoadRealData();
            }
        }

        private void dgvOrderData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var item = dgvOrderData.Rows[e.RowIndex].DataBoundItem as OrderView;
            if (item == null) return;

            using (var db = new POSContext())
            {
                var order = db.Orders.FirstOrDefault(o => o.OrderID == item.OrderID);
                if (order == null) return;

                //如果是已作廢的訂單不能再被切回未完成或已完成
                if (order.OrderStatus == 3)
                {
                    MessageBox.Show("此訂單已經作廢，無法更改狀態！", "操作無效", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string askMsg = order.OrderStatus == 2
                    ? $"確認要將訂單編號 {order.OrderID} 改為『未完成』嗎？"
                    : $"確認要將訂單編號 {order.OrderID} 標記為『已完成』嗎？";

                var confirm = MessageBox.Show(askMsg, "切換訂單狀態", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    order.OrderStatus = (byte)(order.OrderStatus == 2 ? 1 : 2);
                    db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    LoadRealData();
                }
            }
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var item = dgvProducts.Rows[e.RowIndex].DataBoundItem as ProductView;
            if (item == null) return;

            using (var db = new POSContext())
            {
                var prod = db.Products.FirstOrDefault(p => p.ProductID == item.ProductID);
                if (prod == null) return;

                var form = new ProductEditForm(prod);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    LoadRealData();
                }
            }
        }

        private void dgvProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvProducts.SelectedRows.Count == 0) return;
                var item = dgvProducts.SelectedRows[0].DataBoundItem as ProductView;
                if (item == null) return;

                var confirm = MessageBox.Show($"確定要刪除商品：{item.ProductName} ?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;

                using (var db = new POSContext())
                {
                    var prod = db.Products.FirstOrDefault(p => p.ProductID == item.ProductID);
                    if (prod != null)
                    {
                        db.Products.Remove(prod);
                        db.SaveChanges();
                    }
                }
                LoadRealData();
            }
        }

        // 商品拖放實作,緩衝
        private void dgvProducts_MouseDown(object sender, MouseEventArgs e)
        {
            //只允許滑鼠左鍵觸發拖曳
            if (e.Button != MouseButtons.Left) return;

            string keyword = txtSearching?.Text?.Trim()?.ToLower() ?? "";
            if (!string.IsNullOrWhiteSpace(keyword) && keyword != "搜尋商品...")
            {
                dragRowIndex = -1;
                dragBoxFromMouseDown = Rectangle.Empty;
                return;
            }

            var hit = dgvProducts.HitTest(e.X, e.Y);
            if (hit.RowIndex >= 0)
            {
                dragRowIndex = hit.RowIndex;
                // 畫出隱形緩衝區
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRowIndex = -1;
                dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        private void dgvProducts_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left && dragRowIndex >= 0)
            {
                // 只有當滑鼠移動超過緩衝區，才正式啟動拖曳
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // 傳遞帶有專屬標籤的字串，避免跨表格干擾
                    dgvProducts.DoDragDrop("Product_" + dragRowIndex, DragDropEffects.Move);
                }
            }
        }

        private void dgvProducts_DragOver(object sender, DragEventArgs e)
        {
            // 檢查來源是否為商品表格
            if (e.Data.GetDataPresent(typeof(string)) && e.Data.GetData(typeof(string)).ToString().StartsWith("Product_"))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvProducts_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string))) return;
            string dropData = e.Data.GetData(typeof(string)).ToString();

            // 確保接收到的是商品資料
            if (!dropData.StartsWith("Product_")) return;

            int sourceIndex = int.Parse(dropData.Split('_')[1]);

            Point clientPoint = dgvProducts.PointToClient(new Point(e.X, e.Y));
            var hit = dgvProducts.HitTest(clientPoint.X, clientPoint.Y);
            int targetIndex = hit.RowIndex;
            if (targetIndex < 0 || sourceIndex == targetIndex) return;

            var list = dgvProducts.DataSource as List<ProductView>;
            if (list == null) return;

            var item = list[sourceIndex];
            list.RemoveAt(sourceIndex);
            list.Insert(targetIndex, item);

            using (var db = new POSContext())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var pv = list[i];
                    var prod = db.Products.FirstOrDefault(p => p.ProductID == pv.ProductID);
                    if (prod != null) prod.Sort = i + 1;
                }
                db.SaveChanges();
            }
            LoadRealData();
        }

        // 訂單拖放實作緩衝
        private void dgvOrderData_MouseDown(object sender, MouseEventArgs e)
        {
            //只允許滑鼠左鍵脫義
            if (e.Button != MouseButtons.Left) return;

            var hit = dgvOrderData.HitTest(e.X, e.Y);
            if (hit.RowIndex >= 0)
            {
                dragRowIndexOrder = hit.RowIndex;
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDownOrder = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragRowIndexOrder = -1;
                dragBoxFromMouseDownOrder = Rectangle.Empty;
            }
        }

        private void dgvOrderData_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left && dragRowIndexOrder >= 0)
            {
                if (dragBoxFromMouseDownOrder != Rectangle.Empty && !dragBoxFromMouseDownOrder.Contains(e.X, e.Y))
                {
                    // 傳遞帶有專屬標籤的字串
                    dgvOrderData.DoDragDrop("Order_" + dragRowIndexOrder, DragDropEffects.Move);
                }
            }
        }

        private void dgvOrderData_DragOver(object sender, DragEventArgs e)
        {
            // 檢查來源是否為訂單表格
            if (e.Data.GetDataPresent(typeof(string)) && e.Data.GetData(typeof(string)).ToString().StartsWith("Order_"))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvOrderData_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string))) return;
            string dropData = e.Data.GetData(typeof(string)).ToString();

            // 確保接收到的是訂單資料
            if (!dropData.StartsWith("Order_")) return;

            int sourceIndex = int.Parse(dropData.Split('_')[1]);

            Point clientPoint = dgvOrderData.PointToClient(new Point(e.X, e.Y));
            var hit = dgvOrderData.HitTest(clientPoint.X, clientPoint.Y);
            int targetIndex = hit.RowIndex;
            if (targetIndex < 0 || sourceIndex == targetIndex) return;

            var list = dgvOrderData.DataSource as List<OrderView>;
            if (list == null) return;

            var item = list[sourceIndex];
            list.RemoveAt(sourceIndex);
            list.Insert(targetIndex, item);

            using (var db = new POSContext())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var ov = list[i];
                    var order = db.Orders.FirstOrDefault(o => o.OrderID == ov.OrderID);
                    if (order != null) order.OrderSort = i + 1;
                }
                db.SaveChanges();
            }
            LoadRealData();
        }

        // 搜尋功能
        private void txtSearching_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearching?.Text?.Trim()?.ToLower() ?? "";

            if (string.IsNullOrWhiteSpace(keyword) || keyword == "搜尋商品...")
            {
                dgvProducts.DataSource = allProductViews;
                return;
            }
            var filteredList = allProductViews.Where(p =>
                (p.ProductName != null && p.ProductName.ToLower().Contains(keyword)) ||
                (p.Category != null && p.Category.ToLower().Contains(keyword)) ||
                (p.Status != null && p.Status.ToLower().Contains(keyword))
            ).ToList();

            dgvProducts.DataSource = filteredList;
        }

        private void LoadChartData()
        {
            using (var db = new POSContext())
            {
                DateTime sevenDaysAgo = DateTime.Now.Date.AddDays(-6);
                DateTime todayEnd = DateTime.Now.Date.AddDays(1);

                var recentOrders = db.Orders
                    .Where(o => o.OrderDate >= sevenDaysAgo && o.OrderDate < todayEnd)
                    .ToList();

                //只抓7天訂單的明細，避免資料庫的效能浪費~
                var validOrderIds = recentOrders.Where(o => o.OrderStatus != 3).Select(o => o.OrderID).ToList();
                var recentDetails = db.OrderDetails
                    .Where(od => validOrderIds.Contains(od.OrderID))
                    .ToList();

                // 近7日營收 (平滑折線圖 Spline)
                var dailyStats = recentOrders
                    .Where(o => o.OrderDate.HasValue && o.OrderStatus != 3)
                    .Where(o => o.OrderDate.HasValue && o.OrderStatus != 3)
                    .GroupBy(o => o.OrderDate.Value.Date)
                    .Select(g => new
                    {
                        Date = g.Key,
                        Revenue = g.Sum(o => o.FinalAmount ?? 0)
                    })
                    .OrderBy(x => x.Date)
                    .ToList();

                chartRevenue.Series.Clear();
                chartRevenue.Titles.Clear();
                chartRevenue.Titles.Add("近7日營收").Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                chartRevenue.Legends[0].Enabled = false;

                chartRevenue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd";

                var seriesRev = chartRevenue.Series.Add("營收金額");
                seriesRev.ChartType = SeriesChartType.Spline;
                seriesRev.BorderWidth = 3;
                seriesRev.Color = Color.FromArgb(64, 158, 255);
                seriesRev.MarkerStyle = MarkerStyle.Circle;
                seriesRev.MarkerSize = 8;
                seriesRev.MarkerColor = Color.White;
                seriesRev.MarkerBorderColor = Color.FromArgb(64, 158, 255);
                seriesRev.MarkerBorderWidth = 2;

                foreach (var item in dailyStats)
                {
                    seriesRev.Points.AddXY(item.Date, item.Revenue);
                }

                //分類營收統計圖
                try
                {
                    var products = db.Products.ToList();
                    var categories = db.Categories.ToList();

                    var categoryStats = recentDetails
                        .Join(products, od => od.ProductID, p => p.ProductID, (od, p) => new { od, p })
                        .GroupBy(x => x.p.CategoryID)
                        .Select(g => new
                        {
                            CategoryName = categories.FirstOrDefault(c => c.CategoryID == g.Key)?.CategoryName ?? "其他",
                            //改用 Subtotal 避免歷史單價變動誤差
                            Revenue = g.Sum(x => Convert.ToDouble(x.od.Subtotal ?? 0))
                        })
                        .Where(x => x.Revenue > 0)
                        .ToList();

                    chartCategory.Series.Clear();
                    chartCategory.Titles.Clear();
                    chartCategory.Annotations.Clear();

                    chartCategory.Legends[0].Docking = Docking.Right;
                    chartCategory.Legends[0].Alignment = StringAlignment.Center;
                    chartCategory.Legends[0].BorderColor = Color.Transparent;

                    var seriesCat = chartCategory.Series.Add("分類營收");
                    seriesCat.ChartType = SeriesChartType.Doughnut;
                    seriesCat["DoughnutRadius"] = "55";
                    seriesCat.IsValueShownAsLabel = false;
                    seriesCat.LegendText = "#VALX\t#PERCENT{P0}";

                    double totalRevenue = 0;
                    foreach (var item in categoryStats)
                    {
                        seriesCat.Points.AddXY(item.CategoryName, item.Revenue);
                        totalRevenue += item.Revenue;
                    }

                    chartCategory.Titles.Add($"訂單分類數量\n近7日訂單分類數").Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //熱門商品TOP5
                try
                {
                    var topProducts = recentDetails
                        .GroupBy(od => od.ProductName) //用明細內的商品名稱分組
                        .Select(g => new
                        {
                            ProductName = string.IsNullOrWhiteSpace(g.Key) ? "未知商品" : g.Key,
                            TotalQty = g.Sum(od => od.Quantity)
                        })
                        .Where(x => x.TotalQty > 0)
                        .OrderByDescending(x => x.TotalQty)
                        .Take(5)
                        .ToList();

                    chartHotProduct.Series.Clear();
                    chartHotProduct.Titles.Clear();

                    chartHotProduct.Titles.Add("近七日熱門商品 TOP 5").Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                    chartHotProduct.Legends[0].Enabled = false;

                    chartHotProduct.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chartHotProduct.ChartAreas[0].AxisX.LineWidth = 0;
                    chartHotProduct.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
                    chartHotProduct.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chartHotProduct.ChartAreas[0].AxisY.LineWidth = 0;
                    chartHotProduct.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
                    chartHotProduct.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;

                    var seriesHot = chartHotProduct.Series.Add("購買數量");
                    seriesHot.ChartType = SeriesChartType.Bar;
                    seriesHot.Color = Color.FromArgb(121, 85, 72);
                    seriesHot.IsValueShownAsLabel = true;
                    seriesHot.Label = "#VAL";
                    seriesHot["PointWidth"] = "0.3";

                    topProducts.Reverse();

                    foreach (var item in topProducts)
                    {
                        seriesHot.Points.AddXY(item.ProductName, item.TotalQty);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //訂單狀態
                var statusStats = recentOrders
                    .GroupBy(o => o.OrderStatus)
                    .Select(g => new
                    {
                        //三種狀態
                        Status = g.Key == 3 ? "已作廢" : (g.Key == 2 ? "已完成" : "製作中"),
                        Count = g.Count()
                    })
                    .Where(x => x.Count > 0)
                    .ToList();

                chartOrderStatus.Series.Clear();
                chartOrderStatus.Titles.Clear();
                chartOrderStatus.Annotations.Clear();

                chartOrderStatus.Legends[0].Docking = Docking.Right;
                chartOrderStatus.Legends[0].Alignment = StringAlignment.Center;
                chartOrderStatus.Legends[0].BorderColor = Color.Transparent;

                var seriesStatus = chartOrderStatus.Series.Add("狀態數量");
                seriesStatus.ChartType = SeriesChartType.Doughnut;
                seriesStatus["DoughnutRadius"] = "55";
                seriesStatus.IsValueShownAsLabel = false;
                seriesStatus.LegendText = "#VALX\t#VAL (#PERCENT{P0})";

                int totalOrders = 0;
                foreach (var item in statusStats)
                {
                    var idx = seriesStatus.Points.AddXY(item.Status, item.Count);
                    var pt = seriesStatus.Points[idx];

                    //三種狀態指定不同顏色
                    if (item.Status == "已完成")
                        pt.Color = Color.FromArgb(64, 158, 255); // 藍色
                    else if (item.Status == "已作廢")
                        pt.Color = Color.FromArgb(160, 160, 160); // 灰色
                    else
                        pt.Color = Color.FromArgb(255, 175, 75);  // 橘色

                    totalOrders += item.Count;
                }

                chartOrderStatus.Titles.Add($"訂單狀態\n近7日訂單數:{totalOrders}").Font = new Font("微軟正黑體", 12, FontStyle.Bold);
            }
        }
    }
}