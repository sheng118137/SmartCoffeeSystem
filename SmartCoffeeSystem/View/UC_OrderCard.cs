using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem.View
{
    public partial class UC_OrderCard : UserControl
    {
        private int _orderId;
        public event EventHandler OrderCompleted;

        // 🌟 建構子改成接收 List<OrderDetail>
        public UC_OrderCard(int orderId, string orderType, DateTime orderTime, List<OrderDetail> details)
        {
            InitializeComponent();
            _orderId = orderId;

            lblOrderID.Text = $"# {orderId:D3}";
            lblTime.Text = orderTime.ToString("HH:mm");

            if (orderType == "內用")
            {
                lblOrderType.Text = "內用";
                lblOrderType.BackColor = Color.FromArgb(255, 152, 0);
            }
            else
            {
                lblOrderType.Text = "外帶";
                lblOrderType.BackColor = Color.FromArgb(76, 175, 80);
            }

            if ((DateTime.Now - orderTime).TotalMinutes > 15)
            {
                lblTime.ForeColor = Color.Red;
                lblTime.Font = new Font(lblTime.Font, FontStyle.Bold);
            }

            // 負責繪製與排版內容
            RenderOrderItems(details);
        }

        private void RenderOrderItems(List<OrderDetail> details)
        {
            flpDetails.Controls.Clear();

            foreach (var d in details)
            {
                // 1. 商品名稱 (放大、粗體、深色)
                Label lblProduct = new Label();
                lblProduct.Text = $"{d.Quantity} x {d.ProductName}";
                lblProduct.Font = new Font("微軟正黑體", 16F, FontStyle.Bold); // 🌟 16號大粗體！
                lblProduct.ForeColor = Color.FromArgb(48, 48, 48); // 深灰色
                lblProduct.AutoSize = true;
                lblProduct.MaximumSize = new Size(230, 0); // 避免名字太長超出版面，自動換行
                lblProduct.Margin = new Padding(5, 10, 5, 0);
                flpDetails.Controls.Add(lblProduct);

                // 2. 客製化選項 (如果有) (一般大小、淺灰色)
                if (!string.IsNullOrWhiteSpace(d.SpecString))
                {
                    Label lblSpec = new Label();
                    lblSpec.Text = $"   └ {d.SpecString}";
                    lblSpec.Font = new Font("微軟正黑體", 12F, FontStyle.Regular); // 🌟 12號一般字體
                    lblSpec.ForeColor = Color.DimGray; // 淺灰色
                    lblSpec.AutoSize = true;
                    lblSpec.MaximumSize = new Size(230, 0);
                    lblSpec.Margin = new Padding(5, 2, 5, 5);
                    flpDetails.Controls.Add(lblSpec);
                }
            }

            // 🌟 最神奇的一步：取得內容真正需要的高度，然後改變整個卡片的高度！
            int preferredHeight = flpDetails.GetPreferredSize(new Size(flpDetails.Width, 0)).Height;

            // 卡片總高度 = 頂部(50) + 底部按鈕(50) + 內容高度 + 預留邊距(30)
            int newHeight = 50 + 50 + preferredHeight + 30;

            // 設個最低高度，免得只點一杯飲料時卡片太扁不好看
            if (newHeight < 220) newHeight = 220;

            this.Height = newHeight;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (UIMessageBox.ShowAsk($"確定單號 #{_orderId:D3} 的餐點已製作完成？"))
            {
                try
                {
                    using (var db = new POSContext())
                    {
                        var order = db.Orders.Find(_orderId);
                        if (order != null)
                        {
                            order.OrderStatus = 2; // 2 = 已完成
                            db.SaveChanges();
                        }
                    }
                    OrderCompleted?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    UIMessageBox.ShowError($"狀態更新失敗：{ex.Message}");
                }
            }
        }
    }
}