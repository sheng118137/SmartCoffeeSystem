using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace SmartCoffeeSystem
{
    partial class UC_Dashboard
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tplTopCards = new System.Windows.Forms.TableLayoutPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.lblProductLastMonth = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblMemberLastMonth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMemberCount = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.lblOrderLastDay = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.lblRevenueLastDay = new System.Windows.Forms.Label();
            this.lblLastDay = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.PanelHeader = new Sunny.UI.UIPanel();
            this.PanelChart = new Sunny.UI.UIPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiPanel8 = new Sunny.UI.UIPanel();
            this.uiPanel6 = new Sunny.UI.UIPanel();
            this.uiPanel7 = new Sunny.UI.UIPanel();
            this.uiPanel9 = new Sunny.UI.UIPanel();
            this.PanelMiddel = new Sunny.UI.UIPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvProducts = new Sunny.UI.UIDataGridView();
            this.txtSearching = new Sunny.UI.UITextBox();
            this.Toolbar = new Sunny.UI.UIPanel();
            this.ibtnReflash = new FontAwesome.Sharp.IconButton();
            this.ibtnOutPutProduct = new FontAwesome.Sharp.IconButton();
            this.ibtnInsertProduct = new FontAwesome.Sharp.IconButton();
            this.ibtnCreateProduct = new FontAwesome.Sharp.IconButton();
            this.dgvOrderData = new Sunny.UI.UIDataGridView();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiDataGridView2 = new Sunny.UI.UIDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiScrollBar1 = new Sunny.UI.UIScrollBar();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.colSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOrderStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHotProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tplTopCards.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelChart.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.uiPanel8.SuspendLayout();
            this.uiPanel6.SuspendLayout();
            this.uiPanel7.SuspendLayout();
            this.uiPanel9.SuspendLayout();
            this.PanelMiddel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.Toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHotProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tplTopCards
            // 
            this.tplTopCards.BackColor = System.Drawing.Color.Transparent;
            this.tplTopCards.ColumnCount = 4;
            this.tplTopCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplTopCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplTopCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplTopCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tplTopCards.Controls.Add(this.uiPanel4, 3, 0);
            this.tplTopCards.Controls.Add(this.uiPanel3, 2, 0);
            this.tplTopCards.Controls.Add(this.uiPanel2, 1, 0);
            this.tplTopCards.Controls.Add(this.uiPanel1, 0, 0);
            this.tplTopCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tplTopCards.Location = new System.Drawing.Point(0, 0);
            this.tplTopCards.Margin = new System.Windows.Forms.Padding(0);
            this.tplTopCards.Name = "tplTopCards";
            this.tplTopCards.RowCount = 1;
            this.tplTopCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplTopCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tplTopCards.Size = new System.Drawing.Size(1670, 116);
            this.tplTopCards.TabIndex = 0;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.iconPictureBox4);
            this.uiPanel4.Controls.Add(this.lblProductLastMonth);
            this.uiPanel4.Controls.Add(this.label11);
            this.uiPanel4.Controls.Add(this.lblProductCount);
            this.uiPanel4.Controls.Add(this.label13);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel4.FillColor = System.Drawing.Color.White;
            this.uiPanel4.FillColor2 = System.Drawing.Color.White;
            this.uiPanel4.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel4.Location = new System.Drawing.Point(1255, 5);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Radius = 15;
            this.uiPanel4.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel4.Size = new System.Drawing.Size(411, 106);
            this.uiPanel4.TabIndex = 3;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Indigo;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Indigo;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 89;
            this.iconPictureBox4.Location = new System.Drawing.Point(11, -10);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(89, 132);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox4.TabIndex = 4;
            this.iconPictureBox4.TabStop = false;
            // 
            // lblProductLastMonth
            // 
            this.lblProductLastMonth.AutoSize = true;
            this.lblProductLastMonth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLastMonth.ForeColor = System.Drawing.Color.Red;
            this.lblProductLastMonth.Location = new System.Drawing.Point(170, 76);
            this.lblProductLastMonth.Name = "lblProductLastMonth";
            this.lblProductLastMonth.Size = new System.Drawing.Size(73, 22);
            this.lblProductLastMonth.TabIndex = 3;
            this.lblProductLastMonth.Text = "↑ 12.5%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(106, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "較上月";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCount.Location = new System.Drawing.Point(104, 45);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(44, 31);
            this.lblProductCount.TabIndex = 2;
            this.lblProductCount.Text = "89";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(104, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 31);
            this.label13.TabIndex = 1;
            this.label13.Text = "商品總數";
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.iconPictureBox3);
            this.uiPanel3.Controls.Add(this.lblMemberLastMonth);
            this.uiPanel3.Controls.Add(this.label7);
            this.uiPanel3.Controls.Add(this.lblMemberCount);
            this.uiPanel3.Controls.Add(this.lblMember);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel3.FillColor = System.Drawing.Color.White;
            this.uiPanel3.FillColor2 = System.Drawing.Color.White;
            this.uiPanel3.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel3.Location = new System.Drawing.Point(838, 5);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Radius = 15;
            this.uiPanel3.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel3.Size = new System.Drawing.Size(409, 106);
            this.uiPanel3.TabIndex = 2;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.DarkOrange;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox3.IconColor = System.Drawing.Color.DarkOrange;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 89;
            this.iconPictureBox3.Location = new System.Drawing.Point(11, -10);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(89, 132);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox3.TabIndex = 4;
            this.iconPictureBox3.TabStop = false;
            // 
            // lblMemberLastMonth
            // 
            this.lblMemberLastMonth.AutoSize = true;
            this.lblMemberLastMonth.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberLastMonth.ForeColor = System.Drawing.Color.Red;
            this.lblMemberLastMonth.Location = new System.Drawing.Point(170, 76);
            this.lblMemberLastMonth.Name = "lblMemberLastMonth";
            this.lblMemberLastMonth.Size = new System.Drawing.Size(73, 22);
            this.lblMemberLastMonth.TabIndex = 3;
            this.lblMemberLastMonth.Text = "↑ 12.5%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(106, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "較上月";
            // 
            // lblMemberCount
            // 
            this.lblMemberCount.AutoSize = true;
            this.lblMemberCount.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberCount.Location = new System.Drawing.Point(104, 45);
            this.lblMemberCount.Name = "lblMemberCount";
            this.lblMemberCount.Size = new System.Drawing.Size(81, 31);
            this.lblMemberCount.TabIndex = 2;
            this.lblMemberCount.Text = "1,267";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(104, 14);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(110, 31);
            this.lblMember.TabIndex = 1;
            this.lblMember.Text = "會員總數";
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.lblOrderLastDay);
            this.uiPanel2.Controls.Add(this.lbl1);
            this.uiPanel2.Controls.Add(this.lblOrderCount);
            this.uiPanel2.Controls.Add(this.lblOrder);
            this.uiPanel2.Controls.Add(this.iconPictureBox2);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.FillColor2 = System.Drawing.Color.White;
            this.uiPanel2.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel2.Location = new System.Drawing.Point(421, 5);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Radius = 15;
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(409, 106);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderLastDay
            // 
            this.lblOrderLastDay.AutoSize = true;
            this.lblOrderLastDay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderLastDay.ForeColor = System.Drawing.Color.Red;
            this.lblOrderLastDay.Location = new System.Drawing.Point(170, 76);
            this.lblOrderLastDay.Name = "lblOrderLastDay";
            this.lblOrderLastDay.Size = new System.Drawing.Size(73, 22);
            this.lblOrderLastDay.TabIndex = 3;
            this.lblOrderLastDay.Text = "↑ 12.5%";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Silver;
            this.lbl1.Location = new System.Drawing.Point(106, 76);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 22);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "較昨日";
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCount.Location = new System.Drawing.Point(104, 45);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(59, 31);
            this.lblOrderCount.TabIndex = 2;
            this.lblOrderCount.Text = "888";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(104, 14);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(134, 31);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "今日訂單數";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.SandyBrown;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconPictureBox2.IconColor = System.Drawing.Color.SandyBrown;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 89;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, -8);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(89, 132);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 0;
            this.iconPictureBox2.TabStop = false;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.lblRevenueLastDay);
            this.uiPanel1.Controls.Add(this.lblLastDay);
            this.uiPanel1.Controls.Add(this.lblCount);
            this.uiPanel1.Controls.Add(this.lblRevenue);
            this.uiPanel1.Controls.Add(this.iconPictureBox1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.FillColor2 = System.Drawing.Color.White;
            this.uiPanel1.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel1.Location = new System.Drawing.Point(4, 5);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 15;
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(409, 106);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueLastDay
            // 
            this.lblRevenueLastDay.AutoSize = true;
            this.lblRevenueLastDay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueLastDay.ForeColor = System.Drawing.Color.Red;
            this.lblRevenueLastDay.Location = new System.Drawing.Point(170, 76);
            this.lblRevenueLastDay.Name = "lblRevenueLastDay";
            this.lblRevenueLastDay.Size = new System.Drawing.Size(73, 22);
            this.lblRevenueLastDay.TabIndex = 3;
            this.lblRevenueLastDay.Text = "↑ 12.5%";
            // 
            // lblLastDay
            // 
            this.lblLastDay.AutoSize = true;
            this.lblLastDay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastDay.ForeColor = System.Drawing.Color.Silver;
            this.lblLastDay.Location = new System.Drawing.Point(106, 76);
            this.lblLastDay.Name = "lblLastDay";
            this.lblLastDay.Size = new System.Drawing.Size(58, 22);
            this.lblLastDay.TabIndex = 3;
            this.lblLastDay.Text = "較昨日";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(104, 45);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(111, 31);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "$28,500";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(104, 14);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(110, 31);
            this.lblRevenue.TabIndex = 1;
            this.lblRevenue.Text = "今日營收";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Turquoise;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Turquoise;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 89;
            this.iconPictureBox1.Location = new System.Drawing.Point(11, -7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(89, 132);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelHeader.Controls.Add(this.tplTopCards);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.FillColor = System.Drawing.Color.Gainsboro;
            this.PanelHeader.FillColor2 = System.Drawing.Color.Transparent;
            this.PanelHeader.FillDisableColor = System.Drawing.Color.Transparent;
            this.PanelHeader.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.RectColor = System.Drawing.Color.Transparent;
            this.PanelHeader.Size = new System.Drawing.Size(1670, 117);
            this.PanelHeader.TabIndex = 1;
            this.PanelHeader.Text = null;
            this.PanelHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelChart
            // 
            this.PanelChart.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelChart.Controls.Add(this.tableLayoutPanel1);
            this.PanelChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelChart.FillColor = System.Drawing.Color.Gainsboro;
            this.PanelChart.FillColor2 = System.Drawing.Color.Transparent;
            this.PanelChart.FillDisableColor = System.Drawing.Color.Transparent;
            this.PanelChart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PanelChart.Location = new System.Drawing.Point(0, 659);
            this.PanelChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.RectColor = System.Drawing.Color.Transparent;
            this.PanelChart.Size = new System.Drawing.Size(1670, 361);
            this.PanelChart.TabIndex = 2;
            this.PanelChart.Text = null;
            this.PanelChart.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.uiPanel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiPanel6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiPanel7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiPanel9, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1670, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // uiPanel8
            // 
            this.uiPanel8.Controls.Add(this.chartCategory);
            this.uiPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel8.FillColor = System.Drawing.Color.White;
            this.uiPanel8.FillColor2 = System.Drawing.Color.White;
            this.uiPanel8.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel8.Location = new System.Drawing.Point(421, 5);
            this.uiPanel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel8.Name = "uiPanel8";
            this.uiPanel8.Radius = 15;
            this.uiPanel8.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel8.Size = new System.Drawing.Size(409, 351);
            this.uiPanel8.TabIndex = 1;
            this.uiPanel8.Text = null;
            this.uiPanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel6
            // 
            this.uiPanel6.Controls.Add(this.chartHotProduct);
            this.uiPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel6.FillColor = System.Drawing.Color.White;
            this.uiPanel6.FillColor2 = System.Drawing.Color.White;
            this.uiPanel6.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel6.Location = new System.Drawing.Point(1255, 5);
            this.uiPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel6.Name = "uiPanel6";
            this.uiPanel6.Radius = 15;
            this.uiPanel6.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel6.Size = new System.Drawing.Size(411, 351);
            this.uiPanel6.TabIndex = 3;
            this.uiPanel6.Text = null;
            this.uiPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel7
            // 
            this.uiPanel7.Controls.Add(this.chartOrderStatus);
            this.uiPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel7.FillColor = System.Drawing.Color.White;
            this.uiPanel7.FillColor2 = System.Drawing.Color.White;
            this.uiPanel7.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel7.Location = new System.Drawing.Point(838, 5);
            this.uiPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel7.Name = "uiPanel7";
            this.uiPanel7.Radius = 15;
            this.uiPanel7.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel7.Size = new System.Drawing.Size(409, 351);
            this.uiPanel7.TabIndex = 2;
            this.uiPanel7.Text = null;
            this.uiPanel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel9
            // 
            this.uiPanel9.Controls.Add(this.chartRevenue);
            this.uiPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel9.FillColor = System.Drawing.Color.White;
            this.uiPanel9.FillColor2 = System.Drawing.Color.White;
            this.uiPanel9.FillDisableColor = System.Drawing.Color.White;
            this.uiPanel9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiPanel9.Location = new System.Drawing.Point(4, 5);
            this.uiPanel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel9.Name = "uiPanel9";
            this.uiPanel9.Radius = 15;
            this.uiPanel9.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel9.Size = new System.Drawing.Size(409, 351);
            this.uiPanel9.TabIndex = 0;
            this.uiPanel9.Text = null;
            this.uiPanel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMiddel
            // 
            this.PanelMiddel.BackColor = System.Drawing.Color.White;
            this.PanelMiddel.Controls.Add(this.splitContainer1);
            this.PanelMiddel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMiddel.FillColor = System.Drawing.Color.Gainsboro;
            this.PanelMiddel.FillColor2 = System.Drawing.Color.Transparent;
            this.PanelMiddel.FillDisableColor = System.Drawing.Color.Transparent;
            this.PanelMiddel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PanelMiddel.Location = new System.Drawing.Point(0, 117);
            this.PanelMiddel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelMiddel.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelMiddel.Name = "PanelMiddel";
            this.PanelMiddel.Radius = 15;
            this.PanelMiddel.RectColor = System.Drawing.Color.Transparent;
            this.PanelMiddel.Size = new System.Drawing.Size(1670, 903);
            this.PanelMiddel.TabIndex = 3;
            this.PanelMiddel.Text = null;
            this.PanelMiddel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvProducts);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearching);
            this.splitContainer1.Panel1.Controls.Add(this.Toolbar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label20);
            this.splitContainer1.Panel2.Controls.Add(this.dgvOrderData);
            this.splitContainer1.Size = new System.Drawing.Size(1670, 903);
            this.splitContainer1.SplitterDistance = 771;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowDrop = true;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(70)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSort,
            this.colProductId,
            this.colProductName,
            this.colCategory,
            this.colPrice,
            this.colStatus});
            this.dgvProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(70)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(70)));
            this.dgvProducts.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvProducts.Location = new System.Drawing.Point(4, 89);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RectColor = System.Drawing.Color.Black;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.RowTemplate.Height = 45;
            this.dgvProducts.ScrollBarColor = System.Drawing.Color.Coral;
            this.dgvProducts.ScrollBarRectColor = System.Drawing.Color.Black;
            this.dgvProducts.ScrollBarStyleInherited = false;
            this.dgvProducts.SelectedIndex = -1;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(767, 450);
            this.dgvProducts.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvProducts.TabIndex = 2;
            // 
            // txtSearching
            // 
            this.txtSearching.ButtonFillColor = System.Drawing.Color.Transparent;
            this.txtSearching.ButtonFillHoverColor = System.Drawing.Color.Transparent;
            this.txtSearching.ButtonFillPressColor = System.Drawing.Color.White;
            this.txtSearching.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSearching.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSearching.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtSearching.ButtonStyleInherited = false;
            this.txtSearching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearching.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.txtSearching.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearching.Location = new System.Drawing.Point(15, 52);
            this.txtSearching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearching.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearching.Name = "txtSearching";
            this.txtSearching.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearching.RectColor = System.Drawing.Color.Black;
            this.txtSearching.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(172)))));
            this.txtSearching.ScrollBarStyleInherited = false;
            this.txtSearching.ShowText = false;
            this.txtSearching.Size = new System.Drawing.Size(512, 29);
            this.txtSearching.Style = Sunny.UI.UIStyle.Custom;
            this.txtSearching.TabIndex = 1;
            this.txtSearching.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearching.Watermark = "🔍  搜尋商品名稱 / 編號";
            this.txtSearching.TextChanged += new System.EventHandler(this.txtSearching_TextChanged);
            // 
            // Toolbar
            // 
            this.Toolbar.BackColor = System.Drawing.Color.Transparent;
            this.Toolbar.Controls.Add(this.ibtnReflash);
            this.Toolbar.Controls.Add(this.ibtnOutPutProduct);
            this.Toolbar.Controls.Add(this.ibtnInsertProduct);
            this.Toolbar.Controls.Add(this.ibtnCreateProduct);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toolbar.FillColor = System.Drawing.Color.White;
            this.Toolbar.FillColor2 = System.Drawing.Color.White;
            this.Toolbar.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Toolbar.MinimumSize = new System.Drawing.Size(1, 1);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.RectColor = System.Drawing.Color.Transparent;
            this.Toolbar.RectDisableColor = System.Drawing.Color.Transparent;
            this.Toolbar.Size = new System.Drawing.Size(771, 60);
            this.Toolbar.TabIndex = 0;
            this.Toolbar.Text = null;
            this.Toolbar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibtnReflash
            // 
            this.ibtnReflash.BackColor = System.Drawing.Color.White;
            this.ibtnReflash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnReflash.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnReflash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.ibtnReflash.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnReflash.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.ibtnReflash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnReflash.IconSize = 24;
            this.ibtnReflash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnReflash.Location = new System.Drawing.Point(403, 9);
            this.ibtnReflash.Name = "ibtnReflash";
            this.ibtnReflash.Size = new System.Drawing.Size(124, 39);
            this.ibtnReflash.TabIndex = 1;
            this.ibtnReflash.Text = "    重新整理";
            this.ibtnReflash.UseVisualStyleBackColor = false;
            // 
            // ibtnOutPutProduct
            // 
            this.ibtnOutPutProduct.BackColor = System.Drawing.Color.White;
            this.ibtnOutPutProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOutPutProduct.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnOutPutProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.ibtnOutPutProduct.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.ibtnOutPutProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.ibtnOutPutProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOutPutProduct.IconSize = 24;
            this.ibtnOutPutProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOutPutProduct.Location = new System.Drawing.Point(273, 8);
            this.ibtnOutPutProduct.Name = "ibtnOutPutProduct";
            this.ibtnOutPutProduct.Size = new System.Drawing.Size(124, 39);
            this.ibtnOutPutProduct.TabIndex = 1;
            this.ibtnOutPutProduct.Text = "    匯出";
            this.ibtnOutPutProduct.UseVisualStyleBackColor = false;
            // 
            // ibtnInsertProduct
            // 
            this.ibtnInsertProduct.BackColor = System.Drawing.Color.White;
            this.ibtnInsertProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnInsertProduct.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnInsertProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.ibtnInsertProduct.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.ibtnInsertProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.ibtnInsertProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInsertProduct.IconSize = 24;
            this.ibtnInsertProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnInsertProduct.Location = new System.Drawing.Point(143, 9);
            this.ibtnInsertProduct.Name = "ibtnInsertProduct";
            this.ibtnInsertProduct.Size = new System.Drawing.Size(124, 39);
            this.ibtnInsertProduct.TabIndex = 1;
            this.ibtnInsertProduct.Text = "    批次匯入";
            this.ibtnInsertProduct.UseVisualStyleBackColor = false;
            // 
            // ibtnCreateProduct
            // 
            this.ibtnCreateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(54)))), ((int)(((byte)(40)))));
            this.ibtnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCreateProduct.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnCreateProduct.ForeColor = System.Drawing.Color.White;
            this.ibtnCreateProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnCreateProduct.IconColor = System.Drawing.Color.White;
            this.ibtnCreateProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCreateProduct.IconSize = 24;
            this.ibtnCreateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCreateProduct.Location = new System.Drawing.Point(13, 9);
            this.ibtnCreateProduct.Name = "ibtnCreateProduct";
            this.ibtnCreateProduct.Size = new System.Drawing.Size(124, 39);
            this.ibtnCreateProduct.TabIndex = 0;
            this.ibtnCreateProduct.Text = "    新增商品";
            this.ibtnCreateProduct.UseVisualStyleBackColor = false;
            // 
            // dgvOrderData
            // 
            this.dgvOrderData.AllowDrop = true;
            this.dgvOrderData.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvOrderData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrderData.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrderData.ColumnHeadersHeight = 40;
            this.dgvOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdersID,
            this.OrdersSort,
            this.OrderTime,
            this.OrderType,
            this.Account,
            this.OrdersStatus});
            this.dgvOrderData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderData.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderData.EnableHeadersVisualStyles = false;
            this.dgvOrderData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvOrderData.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvOrderData.Location = new System.Drawing.Point(2, 89);
            this.dgvOrderData.Name = "dgvOrderData";
            this.dgvOrderData.ReadOnly = true;
            this.dgvOrderData.RectColor = System.Drawing.Color.Black;
            this.dgvOrderData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvOrderData.RowHeadersVisible = false;
            this.dgvOrderData.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvOrderData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrderData.RowTemplate.Height = 45;
            this.dgvOrderData.ScrollBarColor = System.Drawing.Color.Orange;
            this.dgvOrderData.ScrollBarRectColor = System.Drawing.Color.Black;
            this.dgvOrderData.ScrollBarStyleInherited = false;
            this.dgvOrderData.SelectedIndex = -1;
            this.dgvOrderData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderData.Size = new System.Drawing.Size(893, 450);
            this.dgvOrderData.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvOrderData.TabIndex = 3;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.uiDataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.uiDataGridView1.RowTemplate.Height = 24;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(240, 150);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 2;
            // 
            // uiDataGridView2
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.uiDataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.uiDataGridView2.ColumnHeadersHeight = 32;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView2.DefaultCellStyle = dataGridViewCellStyle18;
            this.uiDataGridView2.EnableHeadersVisualStyles = false;
            this.uiDataGridView2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.uiDataGridView2.Name = "uiDataGridView2";
            this.uiDataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.uiDataGridView2.RowHeadersWidth = 62;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiDataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.uiDataGridView2.RowTemplate.Height = 24;
            this.uiDataGridView2.SelectedIndex = -1;
            this.uiDataGridView2.Size = new System.Drawing.Size(240, 150);
            this.uiDataGridView2.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(211, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // uiScrollBar1
            // 
            this.uiScrollBar1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiScrollBar1.Location = new System.Drawing.Point(104, -220);
            this.uiScrollBar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiScrollBar1.Name = "uiScrollBar1";
            this.uiScrollBar1.Size = new System.Drawing.Size(19, 300);
            this.uiScrollBar1.TabIndex = 0;
            this.uiScrollBar1.Text = "uiScrollBar1";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(321, 249);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // colSort
            // 
            this.colSort.HeaderText = "排序";
            this.colSort.MinimumWidth = 8;
            this.colSort.Name = "colSort";
            this.colSort.ReadOnly = true;
            this.colSort.Width = 150;
            // 
            // colProductId
            // 
            this.colProductId.HeaderText = "商品編號";
            this.colProductId.MinimumWidth = 8;
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "商品名稱";
            this.colProductName.MinimumWidth = 8;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 150;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "分類";
            this.colCategory.MinimumWidth = 8;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 150;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "售價";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 60;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "狀態";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 150;
            // 
            // OrdersID
            // 
            this.OrdersID.HeaderText = "訂單編號";
            this.OrdersID.MinimumWidth = 8;
            this.OrdersID.Name = "OrdersID";
            this.OrdersID.ReadOnly = true;
            this.OrdersID.Width = 150;
            // 
            // OrdersSort
            // 
            this.OrdersSort.HeaderText = "訂單排序";
            this.OrdersSort.MinimumWidth = 8;
            this.OrdersSort.Name = "OrdersSort";
            this.OrdersSort.ReadOnly = true;
            this.OrdersSort.Width = 150;
            // 
            // OrderTime
            // 
            this.OrderTime.HeaderText = "下單時間";
            this.OrderTime.MinimumWidth = 8;
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.ReadOnly = true;
            this.OrderTime.Width = 150;
            // 
            // OrderType
            // 
            this.OrderType.HeaderText = "用餐形式";
            this.OrderType.MinimumWidth = 8;
            this.OrderType.Name = "OrderType";
            this.OrderType.ReadOnly = true;
            this.OrderType.Width = 150;
            // 
            // Account
            // 
            this.Account.HeaderText = "訂單價格";
            this.Account.MinimumWidth = 8;
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 150;
            // 
            // OrdersStatus
            // 
            this.OrdersStatus.HeaderText = "訂單狀態";
            this.OrdersStatus.Name = "OrdersStatus";
            this.OrdersStatus.ReadOnly = true;
            this.OrdersStatus.Width = 150;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(501, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(390, 28);
            this.label20.TabIndex = 4;
            this.label20.Text = "雙擊表格內資料進行訂單狀態修改與編輯";
            // 
            // chartRevenue
            // 
            chartArea4.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend4);
            this.chartRevenue.Location = new System.Drawing.Point(11, -2);
            this.chartRevenue.Name = "chartRevenue";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartRevenue.Series.Add(series4);
            this.chartRevenue.Size = new System.Drawing.Size(424, 334);
            this.chartRevenue.TabIndex = 0;
            this.chartRevenue.Text = "chart1";
            // 
            // chartCategory
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea1);
            this.chartCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCategory.Legends.Add(legend1);
            this.chartCategory.Location = new System.Drawing.Point(0, 0);
            this.chartCategory.Name = "chartCategory";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCategory.Series.Add(series1);
            this.chartCategory.Size = new System.Drawing.Size(409, 351);
            this.chartCategory.TabIndex = 0;
            this.chartCategory.Text = "chart2";
            // 
            // chartOrderStatus
            // 
            chartArea3.Name = "ChartArea1";
            this.chartOrderStatus.ChartAreas.Add(chartArea3);
            this.chartOrderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartOrderStatus.Legends.Add(legend3);
            this.chartOrderStatus.Location = new System.Drawing.Point(0, 0);
            this.chartOrderStatus.Name = "chartOrderStatus";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartOrderStatus.Series.Add(series3);
            this.chartOrderStatus.Size = new System.Drawing.Size(409, 351);
            this.chartOrderStatus.TabIndex = 1;
            this.chartOrderStatus.Text = "chart3";
            // 
            // chartHotProduct
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHotProduct.ChartAreas.Add(chartArea2);
            this.chartHotProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartHotProduct.Legends.Add(legend2);
            this.chartHotProduct.Location = new System.Drawing.Point(0, 0);
            this.chartHotProduct.Name = "chartHotProduct";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHotProduct.Series.Add(series2);
            this.chartHotProduct.Size = new System.Drawing.Size(411, 351);
            this.chartHotProduct.TabIndex = 1;
            this.chartHotProduct.Text = "chart4";
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.PanelChart);
            this.Controls.Add(this.PanelMiddel);
            this.Controls.Add(this.PanelHeader);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1670, 1020);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.tplTopCards.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelChart.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.uiPanel8.ResumeLayout(false);
            this.uiPanel6.ResumeLayout(false);
            this.uiPanel7.ResumeLayout(false);
            this.uiPanel9.ResumeLayout(false);
            this.PanelMiddel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.Toolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHotProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplTopCards;
        private Sunny.UI.UIPanel uiPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblLastDay;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblRevenueLastDay;
        private Sunny.UI.UIPanel uiPanel4;
        private System.Windows.Forms.Label lblProductLastMonth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label label13;
        private Sunny.UI.UIPanel uiPanel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label lblMemberLastMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMemberCount;
        private System.Windows.Forms.Label lblMember;
        private Sunny.UI.UIPanel uiPanel2;
        private System.Windows.Forms.Label lblOrderLastDay;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Label lblOrder;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Sunny.UI.UIPanel PanelHeader;
        private Sunny.UI.UIPanel PanelChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UIPanel uiPanel8;
        private Sunny.UI.UIPanel uiPanel9;
        private Sunny.UI.UIPanel PanelMiddel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Sunny.UI.UIPanel Toolbar;
        private FontAwesome.Sharp.IconButton ibtnReflash;
        private FontAwesome.Sharp.IconButton ibtnOutPutProduct;
        private FontAwesome.Sharp.IconButton ibtnInsertProduct;
        private FontAwesome.Sharp.IconButton ibtnCreateProduct;
        private Sunny.UI.UITextBox txtSearching;
        private Sunny.UI.UIDataGridView uiDataGridView2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIDataGridView dgvProducts;
        private PictureBox pictureBox1;
        private Sunny.UI.UIScrollBar uiScrollBar1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Sunny.UI.UIDataGridView dgvOrderData;
        private DataGridViewTextBoxColumn colSort;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn OrdersID;
        private DataGridViewTextBoxColumn OrdersSort;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn OrderType;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn OrdersStatus;
        private Label label20;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHotProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrderStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
    }
}
