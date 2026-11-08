using Sunny.UI;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_Revenue : UserControl
    {
        private bool _isLoaded = false;

        public UC_Revenue()
        {
            InitializeComponent();
            this.Load += UC_Revenue_Load;
        }

        private void UC_Revenue_Load(object sender, EventArgs e)
        {
            // 設定熱銷商品表格
            if (dgvTopProducts != null)
            {
                dgvTopProducts.AutoGenerateColumns = false;
                colProductName.DataPropertyName = "ProductName";
                colTotalQty.DataPropertyName = "TotalQty";
                colTotalSales.DataPropertyName = "TotalSales";
            }

            // 初始化圖表樣式
            SetupChartStyles();

            // 初始化日期區間：預設看「本月」
            dpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dpEnd.Value = DateTime.Today;

            _isLoaded = true;
            LoadRevenueData();
        }

        // 🎨 設定兩張圖表的樣式
        private void SetupChartStyles()
        {
            if (chartRevenue != null)
            {
                chartRevenue.Series.Clear();
                var series = chartRevenue.Series.Add("每日營業額");
                series.ChartType = SeriesChartType.Spline;
                series.Color = Color.FromArgb(230, 85, 30);
                series.BorderWidth = 3;
                series.MarkerStyle = MarkerStyle.Circle;
                series.MarkerSize = 8;
                series.MarkerColor = Color.FromArgb(60, 40, 30);

                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd";
                chartRevenue.ChartAreas[0].AxisX.Interval = 1;
                chartRevenue.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
                chartRevenue.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
                chartRevenue.BackColor = Color.White;
                chartRevenue.ChartAreas[0].BackColor = Color.White;
            }

            if (chartMember != null)
            {
                chartMember.Series.Clear();
                var seriesMember = chartMember.Series.Add("會員佔比");
                seriesMember.ChartType = SeriesChartType.Doughnut; // 甜甜圈圖
                seriesMember["PieLabelStyle"] = "Percent"; // 顯示百分比
                seriesMember.IsValueShownAsLabel = true;

                chartMember.BackColor = Color.White;
                chartMember.ChartAreas[0].BackColor = Color.White;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadRevenueData();
        private void btnToday_Click(object sender, EventArgs e)
        {
            dpStart.Value = DateTime.Today;
            dpEnd.Value = DateTime.Today;
            LoadRevenueData();
        }
        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            dpStart.Value = DateTime.Today.AddDays(-7);
            dpEnd.Value = DateTime.Today;
            LoadRevenueData();
        }
        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dpEnd.Value = DateTime.Today;
            LoadRevenueData();
        }

        // 📊 核心：載入並計算營收數據、更新雙圖表與排行榜
        private void LoadRevenueData()
        {
            if (!_isLoaded) return;

            DateTime startDate = dpStart.Value.Date;
            DateTime endDate = dpEnd.Value.Date.AddDays(1).AddSeconds(-1);

            try
            {
                using (var db = new POSContext())
                {
                    //撈出有效訂單
                    var validOrders = db.Orders
                        .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate && o.OrderStatus != 3)
                        .ToList();

                    // KPI 數據計算
                    int totalRevenue = validOrders.Sum(o => (int?)o.FinalAmount) ?? 0;
                    int totalOrders = validOrders.Count;
                    int avgOrderAmount = totalOrders > 0 ? totalRevenue / totalOrders : 0;

                    if (lblTotalRevenue != null) lblTotalRevenue.Text = $"${totalRevenue:N0}";
                    if (lblTotalOrders != null) lblTotalOrders.Text = $"{totalOrders:N0} 單";
                    if (lblAvgOrder != null) lblAvgOrder.Text = $"${avgOrderAmount:N0}";

                    //繪製每日營收折線圖數據
                    var dailyRevenue = validOrders
                        .Where(o => o.OrderDate.HasValue)
                        .GroupBy(o => o.OrderDate.Value.Date)
                        .Select(g => new
                        {
                            Date = g.Key,
                            Revenue = g.Sum(o => o.FinalAmount)
                        })
                        .OrderBy(x => x.Date)
                        .ToList();

                    chartRevenue.Series["每日營業額"].Points.Clear();
                    foreach (var item in dailyRevenue)
                    {
                        chartRevenue.Series["每日營業額"].Points.AddXY(item.Date, item.Revenue);
                    }

                    //會員非會員 營收佔比圖數據
                    int memberRevenue = validOrders.Where(o => o.MemberID != null).Sum(o => (int?)o.FinalAmount) ?? 0;
                    int nonMemberRevenue = validOrders.Where(o => o.MemberID == null).Sum(o => (int?)o.FinalAmount) ?? 0;
                    chartMember.Series["會員佔比"].Points.Clear();
                    chartMember.Series["會員佔比"].Points.AddXY($"會員 (${memberRevenue:N0})", memberRevenue);
                    chartMember.Series["會員佔比"].Points.AddXY($"非會員 (${nonMemberRevenue:N0})", nonMemberRevenue);

                    // 自訂顏色
                    if (chartMember.Series["會員佔比"].Points.Count >= 2)
                    {
                        chartMember.Series["會員佔比"].Points[0].Color = Color.FromArgb(230, 85, 30); // 橘色 (會員)
                        chartMember.Series["會員佔比"].Points[1].Color = Color.FromArgb(120, 120, 120); // 灰色 (非會員)
                    }

                    //熱銷商品排行榜
                    var orderIds = validOrders.Select(o => o.OrderID).ToList();
                    var topProducts = db.OrderDetails
                        .Where(d => orderIds.Contains(d.OrderID))
                        .GroupBy(d => d.ProductName)
                        .Select(g => new
                        {
                            ProductName = g.Key,
                            TotalQty = g.Sum(d => d.Quantity),
                            TotalSales = g.Sum(d => d.Subtotal)
                        })
                        .OrderByDescending(x => x.TotalSales)
                        .ToList();

                    if (dgvTopProducts != null)
                    {
                        dgvTopProducts.DataSource = null;
                        dgvTopProducts.DataSource = topProducts;
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"讀取營收數據失敗：{ex.Message}");
            }
        }
    }
}