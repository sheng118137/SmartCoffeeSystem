using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartCoffeeSystem;
using SmartCoffeeSystem.models;

namespace SmartCoffeeSystem
{
    public partial class FrmCheckout : Form
    {
        private int? currentMemberId = null;
        int originalTotal = 0;
        public CheckoutResult Result { get; set; }

        // 類別變數來記住查到的會員，方便其他取他的載具資料
        Member currentQueriedMember = null;

        string selectedPayment = "現金";
        string selectedCarrier = "紙本發票";
        bool isMember = false;
        int discount = 0;

        //記錄目前決定使用的點數
        int usedPoints = 0;

        public FrmCheckout(int totalAmount)
        {
            InitializeComponent();
            originalTotal = totalAmount;
            Result = new CheckoutResult { TotalAmount = originalTotal, UsedPoints = 0 };

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(60, 40, 30), 2), 0, 0, this.Width - 1, this.Height - 1);
            };

            SetupEventHandlers();
            UpdateTotalDisplay();

            btnCash.BackColor = Color.FromArgb(230, 85, 30);
            btnCash.ForeColor = Color.White;
            btnPaper.BackColor = Color.FromArgb(230, 85, 30);
            btnPaper.ForeColor = Color.White;

            txtPhone.Text = "請輸入手機號碼...";
            txtPhone.ForeColor = Color.Gray;

            //預設隱藏點數輸入框，等查到會員再顯示
            if (txtUsePoints != null)
            {
                txtUsePoints.Visible = false;
                if (btnPoints != null) btnPoints.Visible = false;
                txtUsePoints.Text = "0";
            }
        }

        private void SetupEventHandlers()
        {
            btnClose.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            btnConfirm.Click += BtnConfirm_Click;
            btnCheckMember.Click += BtnCheckMember_Click;

            txtPhone.Enter += (s, e) =>
            {
                if (txtPhone.Text == "請輸入手機號碼...") { txtPhone.Text = ""; txtPhone.ForeColor = Color.Black; }
            };
            txtPhone.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPhone.Text)) { txtPhone.Text = "請輸入手機號碼..."; txtPhone.ForeColor = Color.Gray; }
            };

            //綁定明確定義的事件方法，避免無窮迴圈
            if (txtUsePoints != null)
            {
                txtUsePoints.TextChanged += TxtUsePoints_TextChanged;
            }

            //定點數付款按鈕
            if (btnPoints != null)
            {
                btnPoints.Click += BtnPoints_Click;
            }

            btnCash.Click += Payment_Click;
            btnCard.Click += Payment_Click;
            btnLinePay.Click += Payment_Click;
            btnEasyCard.Click += Payment_Click;

            btnPaper.Click += Carrier_Click;
            btnMobile.Click += Carrier_Click;
            btnTax.Click += Carrier_Click;
        }

        //專門處理文字改變事件
        private void TxtUsePoints_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalDisplay();
        }

        //點擊點數按鈕時，自動帶入最大可用點數或取消折抵
        private void BtnPoints_Click(object sender, EventArgs e)
        {
            if (!isMember || currentQueriedMember == null || txtUsePoints == null) return;

            int subTotal = originalTotal - discount;
            int currentPoints = currentQueriedMember.Point ?? 0;

            int maxUsablePoints = Math.Min(currentPoints, subTotal);

            //判斷目前是折抵狀態還是非折抵狀態
            if (txtUsePoints.Text == maxUsablePoints.ToString() && maxUsablePoints > 0)
            {
                //如果已經是最大了，再點一下代表取消折抵
                txtUsePoints.Text = "0";

                //恢復點數按鈕的預設顏色
                btnPoints.BackColor = Color.White;
                btnPoints.ForeColor = Color.FromArgb(60, 40, 30);
            }
            else
            {
                //點擊後全額折抵
                txtUsePoints.Text = maxUsablePoints.ToString();

                //只要有使用點數，按鈕就變色亮起
                if (maxUsablePoints > 0)
                {
                    btnPoints.BackColor = Color.FromArgb(230, 85, 30);
                    btnPoints.ForeColor = Color.White;
                }

                //如果點數夠付全額，才把其他支付按鈕取消；如果不夠付，其他支付按鈕還是要亮著，讓店員選剩下的錢怎麼付
                if (maxUsablePoints == subTotal)
                {
                    selectedPayment = "點數付款";
                    Button[] btns = { btnCash, btnCard, btnLinePay, btnEasyCard };
                    foreach (var b in btns)
                    {
                        b.BackColor = Color.White;
                        b.ForeColor = Color.FromArgb(60, 40, 30);
                    }
                }
            }
        }
        private void BtnCheckMember_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            usedPoints = 0; //重新查詢會員時，重置使用點數
            if (txtUsePoints != null) txtUsePoints.Text = "0";

            if (phone.Length == 10 && phone.StartsWith("09"))
            {
                using (var db = new POSContext())
                {
                    var query = from m in db.Members
                                join l in db.MemberLevels on m.LevelID equals l.LevelID into levelGroup
                                from level in levelGroup.DefaultIfEmpty()
                                where m.Phone == phone && m.IsActive == true
                                select new
                                {
                                    Member = m,
                                    LevelName = level != null ? level.LevelName : "一般會員",
                                    DiscountRate = level != null ? level.DiscountRate : 1.00m
                                };

                    var memberData = query.FirstOrDefault();

                    if (memberData != null)
                    {
                        currentQueriedMember = memberData.Member;
                        isMember = true;
                        currentMemberId = currentQueriedMember.MemberID;

                        discount = originalTotal - (int)Math.Floor(originalTotal * memberData.DiscountRate);

                        string discountStr = memberData.DiscountRate < 1.0m ? $"({(memberData.DiscountRate * 10).ToString("0.##")}折)" : "(無折扣)";
                        lblMemberStatus.Text = $"✓ {currentQueriedMember.MemberName} | {memberData.LevelName} | {discountStr} | 點數:{currentQueriedMember.Point}";
                        lblMemberStatus.ForeColor = Color.FromArgb(40, 160, 60);

                        //查到會員，顯示點數折抵輸入框與按鈕
                        if (txtUsePoints != null) txtUsePoints.Visible = true;
                        if (btnPoints != null) btnPoints.Visible = true;

                        if (currentQueriedMember.DefaultCarrierType == "手機條碼") btnMobile.PerformClick();
                        else if (currentQueriedMember.DefaultCarrierType == "公司統編") btnTax.PerformClick();
                        else btnPaper.PerformClick();
                    }
                    else
                    {
                        isMember = false;
                        currentMemberId = null;
                        currentQueriedMember = null;
                        discount = 0;
                        lblMemberStatus.Text = "查無此會員或已停用";
                        lblMemberStatus.ForeColor = Color.Red;

                        //查無會員，隱藏點數折抵輸入框與按鈕
                        if (txtUsePoints != null) txtUsePoints.Visible = false;
                        if (btnPoints != null) btnPoints.Visible = false;

                        btnPaper.PerformClick();
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入正確的手機號碼格式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            UpdateTotalDisplay();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            // 將所有支付按鈕恢復預設顏色
            Button[] btns = { btnCash, btnCard, btnLinePay, btnEasyCard };
            foreach (var b in btns)
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.FromArgb(60, 40, 30);
            }

            // 點擊的按鈕變色
            Button clicked = (Button)sender;
            clicked.BackColor = Color.FromArgb(230, 85, 30);
            clicked.ForeColor = Color.White;
            selectedPayment = clicked.Text;

        }
        private void Carrier_Click(object sender, EventArgs e)
        {
            Button[] btns = { btnPaper, btnMobile, btnTax };
            foreach (var b in btns)
            {
                b.BackColor = Color.White;
                b.ForeColor = Color.FromArgb(60, 40, 30);
            }

            Button clicked = (Button)sender;
            clicked.BackColor = Color.FromArgb(230, 85, 30);
            clicked.ForeColor = Color.White;
            selectedCarrier = clicked.Text;

            if (selectedCarrier == "紙本發票")
            {
                txtCarrier.Visible = false;
                txtCarrier.Text = "";
            }
            else
            {
                txtCarrier.Visible = true;

                if (selectedCarrier == "手機條碼" && currentQueriedMember != null && !string.IsNullOrEmpty(currentQueriedMember.DefaultCarrierNum))
                {
                    txtCarrier.Text = currentQueriedMember.DefaultCarrierNum;
                }
                else if (selectedCarrier == "公司統編" && currentQueriedMember != null && !string.IsNullOrEmpty(currentQueriedMember.DefaultTaxID))
                {
                    txtCarrier.Text = currentQueriedMember.DefaultTaxID;
                }
                else
                {
                    txtCarrier.Text = "";
                }
                txtCarrier.Focus();
            }
        }

        // 重新設計的防呆運算邏輯
        private void UpdateTotalDisplay()
        {
            int subTotal = originalTotal - discount; // 先算完會員等級折扣後的金額

            // 處理點數折抵
            usedPoints = 0;
            if (isMember && currentQueriedMember != null && txtUsePoints != null && !string.IsNullOrWhiteSpace(txtUsePoints.Text))
            {
                if (int.TryParse(txtUsePoints.Text, out int inputPoints))
                {
                    int currentPoints = currentQueriedMember.Point ?? 0;

                    //不能扣超過會員擁有的點數
                    if (inputPoints > currentPoints)
                    {
                        inputPoints = currentPoints;
                    }

                    //1點=1元折抵金額不能超過剩餘應付金額不扣到變負數退錢
                    if (inputPoints > subTotal)
                    {
                        inputPoints = subTotal;
                    }

                    usedPoints = inputPoints;

                    //正確地解除綁定，再重新綁定
                    txtUsePoints.TextChanged -= TxtUsePoints_TextChanged;
                    txtUsePoints.Text = usedPoints.ToString();
                    txtUsePoints.TextChanged += TxtUsePoints_TextChanged;
                }
            }

            int final = subTotal - usedPoints;

            // 顯示文字組合
            string discountMsg = discount > 0 ? $" (已折${discount})" : "";
            string pointsMsg = usedPoints > 0 ? $" (扣點抵${usedPoints})" : "";

            lblFinalAmount.Text = $"應付總額：${final}{discountMsg}{pointsMsg}";
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedCarrier != "紙本發票" && string.IsNullOrWhiteSpace(txtCarrier.Text))
            {
                MessageBox.Show($"請輸入{selectedCarrier}號碼！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Result.MemberID = currentMemberId;
            Result.IsMember = isMember;
            Result.MemberPhone = isMember ? txtPhone.Text : "";
            Result.PaymentMethod = selectedPayment;

            Result.CarrierType = selectedCarrier;
            Result.CarrierNumber = txtCarrier.Visible ? txtCarrier.Text.Trim() : "";

            Result.DiscountAmount = discount;
            Result.TotalAmount = originalTotal;
            //最終金額 = 原價 - 等級折扣 - 點數折抵
            Result.FinalAmount = originalTotal - discount - usedPoints;
            Result.UsedPoints = usedPoints; // 把使用的點數傳回去

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}