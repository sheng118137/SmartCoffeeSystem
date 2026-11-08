using Sunny.UI;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem
{
    public partial class UC_LoginLogManager : UserControl
    {
        // --- 自訂分頁控制變數 ---
        private int currentPage = 1;
        private int pageSize = 20;
        private int totalPages = 1;
        private int totalRecords = 0;

        public UC_LoginLogManager()
        {
            InitializeComponent();

            InitControls();
            BindEvents();
        }

        // 初始化搜尋控制項狀態
        private void InitControls()
        {
            // 1. 初始化狀態下拉選單
            cboStatus.Items.Clear();
            cboStatus.Items.Add("所有狀態");
            cboStatus.Items.Add("Success");
            cboStatus.Items.Add("Failed");
            cboStatus.SelectedIndex = 0;

            // 2. 初始化自訂分頁的筆數下拉選單
            cboPageSize.Items.Clear();
            cboPageSize.Items.Add("20");
            cboPageSize.Items.Add("50");
            cboPageSize.Items.Add("100");
            cboPageSize.SelectedIndex = 0;

            // 3. 初始化日期搜尋區間 (預設最近 30 天)
            dtpStart.Value = DateTime.Now.AddDays(-30);
            dtpEnd.Value = DateTime.Now;

            // 4. 綁定 CellFormatting 紅綠字效果
            dgvLogs.CellFormatting += dgvLogs_CellFormatting;
        }

        private void BindEvents()
        {
            // 查詢與重置按鈕
            btnSearch.Click += (s, e) => { currentPage = 1; QueryLogs(); };
            btnRefresh.Click += (s, e) => ResetSearchFilters();

            // 輸入框 Placeholder 邏輯
            txtSearching.Enter += (s, e) =>
            {
                if (txtSearching.Text == "🔍 搜尋帳號或IP...")
                {
                    txtSearching.Text = "";
                    txtSearching.ForeColor = Color.Black;
                }
            };

            txtSearching.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearching.Text))
                {
                    txtSearching.Text = "🔍 搜尋帳號或IP...";
                    txtSearching.ForeColor = Color.Gray;
                }
            };

            // 按下 Enter 直接觸發查詢
            txtSearching.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    currentPage = 1;
                    QueryLogs();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            // --- 自訂分頁按鈕事件 ---
            btnFirstPage.Click += (s, e) => { if (currentPage > 1) { currentPage = 1; QueryLogs(); } };
            btnPrevPage.Click += (s, e) => { if (currentPage > 1) { currentPage--; QueryLogs(); } };
            btnNextPage.Click += (s, e) => { if (currentPage < totalPages) { currentPage++; QueryLogs(); } };
            btnLastPage.Click += (s, e) => { if (currentPage < totalPages) { currentPage = totalPages; QueryLogs(); } };

            cboPageSize.SelectedIndexChanged += (s, e) =>
            {
                if (int.TryParse(cboPageSize.SelectedItem?.ToString(), out int size))
                {
                    pageSize = size;
                    currentPage = 1; // 改變每頁筆數時回到第一頁
                    QueryLogs();
                }
            };
        }

        private void UC_LoginLogManager_Load(object sender, EventArgs e)
        {
            dgvLogs.AutoGenerateColumns = false;
            currentPage = 1;
            QueryLogs();
        }

        // 核心複合條件查詢與分頁載入
        private void QueryLogs()
        {
            try
            {
                using (var db = new POSContext())
                {
                    var query = db.LoginLogs.AsQueryable();

                    // 1. 日期區間過濾 (結束日期設定為當天的 23:59:59)
                    DateTime startDate = dtpStart.Value.Date;
                    DateTime endDate = dtpEnd.Value.Date.AddDays(1).AddSeconds(-1);
                    query = query.Where(l => l.AttemptTime >= startDate && l.AttemptTime <= endDate);

                    // 2. 狀態過濾
                    string selectedStatus = cboStatus.SelectedItem?.ToString();
                    if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "所有狀態")
                    {
                        query = query.Where(l => l.Status == selectedStatus);
                    }

                    // 3. 關鍵字過濾 (帳號或 IP)
                    string keyword = txtSearching.Text.Trim();
                    if (!string.IsNullOrEmpty(keyword) && keyword != "🔍 搜尋帳號或IP...")
                    {
                        string lowerKeyword = keyword.ToLower();
                        query = query.Where(l => l.Username.ToLower().Contains(lowerKeyword) ||
                                                 l.IPAddress.ToLower().Contains(lowerKeyword));
                    }

                    // 4. 計算總筆數與總頁數
                    totalRecords = query.Count();
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (totalPages == 0) totalPages = 1; // 至少顯示 1 頁

                    if (currentPage > totalPages) currentPage = totalPages; // 邊界防護

                    // 5. 分頁查詢資料
                    var logsList = query
                        .OrderByDescending(l => l.AttemptTime)
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    // 6. 重新繫結 DataGridView
                    dgvLogs.DataSource = null;
                    dgvLogs.DataSource = logsList;

                    // 7. 更新自訂分頁的 UI 標籤與按鈕狀態
                    UpdatePaginationUI();
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.Show($"查詢紀錄失敗：{ex.Message}");
            }
        }

        // 更新分頁文字與按鈕啟用狀態
        private void UpdatePaginationUI()
        {
            lblPageInfo.Text = $"第 {currentPage} 頁 / 共 {totalPages} 頁 (總計 {totalRecords} 筆)";

            // 第一頁或上一頁的按鈕控制
            btnFirstPage.Enabled = (currentPage > 1);
            btnPrevPage.Enabled = (currentPage > 1);

            // 最後一頁或下一頁的按鈕控制
            btnNextPage.Enabled = (currentPage < totalPages);
            btnLastPage.Enabled = (currentPage < totalPages);
        }

        // 重置所有條件
        private void ResetSearchFilters()
        {
            dtpStart.Value = DateTime.Now.AddDays(-30);
            dtpEnd.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;
            cboPageSize.SelectedIndex = 0;
            txtSearching.Text = "🔍 搜尋帳號或IP...";
            txtSearching.ForeColor = Color.Gray;

            currentPage = 1;
            QueryLogs();
        }

        // DataGridView 格式化：失敗變紅字，成功變綠字
        private void dgvLogs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvLogs.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Failed")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }
                else if (status == "Success")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionForeColor = Color.Green;
                }
            }
        }
    }
}