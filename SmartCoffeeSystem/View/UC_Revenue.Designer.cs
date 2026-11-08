namespace SmartCoffeeSystem.View
{
    partial class UC_Revenue
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSearch = new Sunny.UI.UIButton();
            this.btnThisMonth = new Sunny.UI.UIButton();
            this.btnThisWeek = new Sunny.UI.UIButton();
            this.btnToday = new Sunny.UI.UIButton();
            this.dpEnd = new Sunny.UI.UIDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dpStart = new Sunny.UI.UIDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKPI = new System.Windows.Forms.TableLayoutPanel();
            this.panelCard3 = new Sunny.UI.UIPanel();
            this.lblAvgOrder = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelCard2 = new Sunny.UI.UIPanel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCard1 = new Sunny.UI.UIPanel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMainContent = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeftChart = new System.Windows.Forms.Panel();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.panelRightChart = new System.Windows.Forms.Panel();
            this.chartMember = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMemberChartTitle = new System.Windows.Forms.Label();
            this.panelBottomTable = new System.Windows.Forms.Panel();
            this.dgvTopProducts = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelKPI.SuspendLayout();
            this.panelCard3.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            this.panelLeftChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.panelRightChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMember)).BeginInit();
            this.panelBottomTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnThisMonth);
            this.panelTop.Controls.Add(this.btnThisWeek);
            this.panelTop.Controls.Add(this.btnToday);
            this.panelTop.Controls.Add(this.dpEnd);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dpStart);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1655, 80);
            this.panelTop.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(530, 20);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查詢";
            this.btnSearch.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThisMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnThisMonth.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnThisMonth.Location = new System.Drawing.Point(830, 20);
            this.btnThisMonth.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(80, 36);
            this.btnThisMonth.TabIndex = 6;
            this.btnThisMonth.Text = "本月";
            this.btnThisMonth.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThisWeek.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnThisWeek.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnThisWeek.Location = new System.Drawing.Point(740, 20);
            this.btnThisWeek.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(80, 36);
            this.btnThisWeek.TabIndex = 5;
            this.btnThisWeek.Text = "本週";
            this.btnThisWeek.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnThisWeek.Click += new System.EventHandler(this.btnThisWeek_Click);
            // 
            // btnToday
            // 
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnToday.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnToday.Location = new System.Drawing.Point(650, 20);
            this.btnToday.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(80, 36);
            this.btnToday.TabIndex = 4;
            this.btnToday.Text = "今日";
            this.btnToday.TipsFont = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dpEnd
            // 
            this.dpEnd.DateCultureInfo = new System.Globalization.CultureInfo("");
            this.dpEnd.FillColor = System.Drawing.Color.White;
            this.dpEnd.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.dpEnd.Location = new System.Drawing.Point(310, 20);
            this.dpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpEnd.MaxLength = 10;
            this.dpEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpEnd.Size = new System.Drawing.Size(200, 36);
            this.dpEnd.SymbolDropDown = 61555;
            this.dpEnd.SymbolNormal = 61555;
            this.dpEnd.SymbolSize = 24;
            this.dpEnd.TabIndex = 8;
            this.dpEnd.Text = "2026-07-31";
            this.dpEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpEnd.Value = new System.DateTime(2026, 7, 31, 1, 32, 55, 223);
            this.dpEnd.Watermark = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(280, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "~";
            // 
            // dpStart
            // 
            this.dpStart.DateCultureInfo = new System.Globalization.CultureInfo("");
            this.dpStart.FillColor = System.Drawing.Color.White;
            this.dpStart.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.dpStart.Location = new System.Drawing.Point(70, 20);
            this.dpStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpStart.MaxLength = 10;
            this.dpStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpStart.Size = new System.Drawing.Size(200, 36);
            this.dpStart.SymbolDropDown = 61555;
            this.dpStart.SymbolNormal = 61555;
            this.dpStart.SymbolSize = 24;
            this.dpStart.TabIndex = 9;
            this.dpStart.Text = "2026-07-31";
            this.dpStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpStart.Value = new System.DateTime(2026, 7, 31, 1, 32, 55, 245);
            this.dpStart.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "區間:";
            // 
            // panelKPI
            // 
            this.panelKPI.ColumnCount = 3;
            this.panelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelKPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelKPI.Controls.Add(this.panelCard3, 2, 0);
            this.panelKPI.Controls.Add(this.panelCard2, 1, 0);
            this.panelKPI.Controls.Add(this.panelCard1, 0, 0);
            this.panelKPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKPI.Location = new System.Drawing.Point(0, 80);
            this.panelKPI.Name = "panelKPI";
            this.panelKPI.Padding = new System.Windows.Forms.Padding(15);
            this.panelKPI.RowCount = 1;
            this.panelKPI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelKPI.Size = new System.Drawing.Size(1655, 130);
            this.panelKPI.TabIndex = 1;
            // 
            // panelCard3
            // 
            this.panelCard3.Controls.Add(this.lblAvgOrder);
            this.panelCard3.Controls.Add(this.label9);
            this.panelCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelCard3.Location = new System.Drawing.Point(1107, 20);
            this.panelCard3.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panelCard3.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelCard3.Name = "panelCard3";
            this.panelCard3.Radius = 10;
            this.panelCard3.Size = new System.Drawing.Size(523, 90);
            this.panelCard3.TabIndex = 2;
            this.panelCard3.Text = null;
            this.panelCard3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgOrder
            // 
            this.lblAvgOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblAvgOrder.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lblAvgOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblAvgOrder.Location = new System.Drawing.Point(15, 38);
            this.lblAvgOrder.Name = "lblAvgOrder";
            this.lblAvgOrder.Size = new System.Drawing.Size(315, 40);
            this.lblAvgOrder.TabIndex = 1;
            this.lblAvgOrder.Text = "$0";
            this.lblAvgOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(15, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "平均客單價";
            // 
            // panelCard2
            // 
            this.panelCard2.Controls.Add(this.lblTotalOrders);
            this.panelCard2.Controls.Add(this.label6);
            this.panelCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelCard2.Location = new System.Drawing.Point(566, 20);
            this.panelCard2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panelCard2.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Radius = 10;
            this.panelCard2.Size = new System.Drawing.Size(521, 90);
            this.panelCard2.TabIndex = 1;
            this.panelCard2.Text = null;
            this.panelCard2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrders.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTotalOrders.Location = new System.Drawing.Point(15, 38);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(310, 40);
            this.lblTotalOrders.TabIndex = 1;
            this.lblTotalOrders.Text = "0 單";
            this.lblTotalOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(15, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "期間總訂單";
            // 
            // panelCard1
            // 
            this.panelCard1.Controls.Add(this.lblTotalRevenue);
            this.panelCard1.Controls.Add(this.label3);
            this.panelCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCard1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.panelCard1.Location = new System.Drawing.Point(15, 20);
            this.panelCard1.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.panelCard1.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Radius = 10;
            this.panelCard1.Size = new System.Drawing.Size(531, 90);
            this.panelCard1.TabIndex = 0;
            this.panelCard1.Text = null;
            this.panelCard1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRevenue.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(85)))), ((int)(((byte)(30)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(15, 38);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(310, 40);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "$0";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(15, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "期間總營業額";
            // 
            // panelMainContent
            // 
            this.panelMainContent.ColumnCount = 2;
            this.panelMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.panelMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.panelMainContent.Controls.Add(this.panelLeftChart, 0, 0);
            this.panelMainContent.Controls.Add(this.panelRightChart, 1, 0);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainContent.Location = new System.Drawing.Point(0, 210);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.panelMainContent.RowCount = 1;
            this.panelMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMainContent.Size = new System.Drawing.Size(1655, 380);
            this.panelMainContent.TabIndex = 4;
            // 
            // panelLeftChart
            // 
            this.panelLeftChart.BackColor = System.Drawing.Color.White;
            this.panelLeftChart.Controls.Add(this.chartRevenue);
            this.panelLeftChart.Controls.Add(this.lblChartTitle);
            this.panelLeftChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftChart.Location = new System.Drawing.Point(18, 18);
            this.panelLeftChart.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panelLeftChart.Name = "panelLeftChart";
            this.panelLeftChart.Size = new System.Drawing.Size(880, 354);
            this.panelLeftChart.TabIndex = 0;
            // 
            // chartRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(0, 36);
            this.chartRevenue.Name = "chartRevenue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(880, 318);
            this.chartRevenue.TabIndex = 5;
            this.chartRevenue.Text = "chart1";
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartTitle.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.Location = new System.Drawing.Point(0, 0);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblChartTitle.Size = new System.Drawing.Size(880, 36);
            this.lblChartTitle.TabIndex = 4;
            this.lblChartTitle.Text = "每日營收趨勢圖";
            this.lblChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRightChart
            // 
            this.panelRightChart.BackColor = System.Drawing.Color.White;
            this.panelRightChart.Controls.Add(this.chartMember);
            this.panelRightChart.Controls.Add(this.lblMemberChartTitle);
            this.panelRightChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightChart.Location = new System.Drawing.Point(911, 18);
            this.panelRightChart.Name = "panelRightChart";
            this.panelRightChart.Size = new System.Drawing.Size(726, 354);
            this.panelRightChart.TabIndex = 1;
            // 
            // chartMember
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMember.ChartAreas.Add(chartArea3);
            this.chartMember.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartMember.Legends.Add(legend3);
            this.chartMember.Location = new System.Drawing.Point(0, 36);
            this.chartMember.Name = "chartMember";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartMember.Series.Add(series3);
            this.chartMember.Size = new System.Drawing.Size(726, 318);
            this.chartMember.TabIndex = 3;
            this.chartMember.Text = "chart2";
            // 
            // lblMemberChartTitle
            // 
            this.lblMemberChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMemberChartTitle.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblMemberChartTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMemberChartTitle.Name = "lblMemberChartTitle";
            this.lblMemberChartTitle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblMemberChartTitle.Size = new System.Drawing.Size(726, 36);
            this.lblMemberChartTitle.TabIndex = 2;
            this.lblMemberChartTitle.Text = "會員 vs 非會員 營收佔比";
            this.lblMemberChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBottomTable
            // 
            this.panelBottomTable.BackColor = System.Drawing.Color.White;
            this.panelBottomTable.Controls.Add(this.dgvTopProducts);
            this.panelBottomTable.Controls.Add(this.lblTableTitle);
            this.panelBottomTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomTable.Location = new System.Drawing.Point(0, 590);
            this.panelBottomTable.Name = "panelBottomTable";
            this.panelBottomTable.Padding = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.panelBottomTable.Size = new System.Drawing.Size(1655, 415);
            this.panelBottomTable.TabIndex = 5;
            // 
            // dgvTopProducts
            // 
            this.dgvTopProducts.AllowUserToAddRows = false;
            this.dgvTopProducts.AllowUserToDeleteRows = false;
            this.dgvTopProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colTotalQty,
            this.colTotalSales});
            this.dgvTopProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopProducts.Location = new System.Drawing.Point(15, 41);
            this.dgvTopProducts.Name = "dgvTopProducts";
            this.dgvTopProducts.ReadOnly = true;
            this.dgvTopProducts.RowTemplate.Height = 30;
            this.dgvTopProducts.Size = new System.Drawing.Size(1625, 359);
            this.dgvTopProducts.TabIndex = 3;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "商品名稱";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colTotalQty
            // 
            this.colTotalQty.HeaderText = "總銷售數量";
            this.colTotalQty.Name = "colTotalQty";
            this.colTotalQty.ReadOnly = true;
            // 
            // colTotalSales
            // 
            this.colTotalSales.HeaderText = "總銷售金額";
            this.colTotalSales.Name = "colTotalSales";
            this.colTotalSales.ReadOnly = true;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTableTitle.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.Location = new System.Drawing.Point(15, 5);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(1625, 36);
            this.lblTableTitle.TabIndex = 2;
            this.lblTableTitle.Text = "熱銷商品排行榜";
            this.lblTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.panelBottomTable);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelKPI);
            this.Controls.Add(this.panelTop);
            this.Name = "UC_Revenue";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.Size = new System.Drawing.Size(1670, 1020);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelKPI.ResumeLayout(false);
            this.panelCard3.ResumeLayout(false);
            this.panelCard3.PerformLayout();
            this.panelCard2.ResumeLayout(false);
            this.panelCard2.PerformLayout();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.panelMainContent.ResumeLayout(false);
            this.panelLeftChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.panelRightChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMember)).EndInit();
            this.panelBottomTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIDatePicker dpStart;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIDatePicker dpEnd;
        private Sunny.UI.UIButton btnToday;
        private Sunny.UI.UIButton btnThisWeek;
        private Sunny.UI.UIButton btnThisMonth;
        private Sunny.UI.UIButton btnSearch;
        private System.Windows.Forms.TableLayoutPanel panelKPI;
        private Sunny.UI.UIPanel panelCard1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRevenue;
        private Sunny.UI.UIPanel panelCard3;
        private System.Windows.Forms.Label lblAvgOrder;
        private System.Windows.Forms.Label label9;
        private Sunny.UI.UIPanel panelCard2;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel panelMainContent;
        private System.Windows.Forms.Panel panelLeftChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel panelRightChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMember;
        private System.Windows.Forms.Label lblMemberChartTitle;
        private System.Windows.Forms.Panel panelBottomTable;
        private System.Windows.Forms.DataGridView dgvTopProducts;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalSales;
    }
}