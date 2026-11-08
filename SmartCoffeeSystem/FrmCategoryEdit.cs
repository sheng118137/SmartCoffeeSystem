using FontAwesome.Sharp;
using Sunny.UI;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SmartCoffeeSystem
{
    public partial class FrmCategoryEdit : UIForm
    {
        public string CategoryName { get; private set; }
        public string SelectedIconName { get; private set; }

        private IconButton currentIconBtn = null;

        // 建構子：可以傳入預設的名稱與圖示 (修改時很好用)
        public FrmCategoryEdit(string title, string defaultName = "", string defaultIcon = "Utensils")
        {
            InitializeComponent();
            this.Text = title;
            txtName.Text = defaultName;

            // 防呆：如果資料庫裡是空值，預設給刀叉
            SelectedIconName = string.IsNullOrEmpty(defaultIcon) ? "Utensils" : defaultIcon;

            LoadIcons();
        }

        private void LoadIcons()
        {
            //
            IconChar[] icons = {
                //食物與餐飲類
                IconChar.Utensils, IconChar.Coffee, IconChar.MugHot, IconChar.Hamburger,
                IconChar.PizzaSlice, IconChar.IceCream, IconChar.Cocktail, IconChar.WineGlassAlt,
                IconChar.Beer, IconChar.GlassCheers, IconChar.Bacon,IconChar.Egg, IconChar.Carrot, IconChar.AppleAlt, IconChar.Lemon,IconChar.Leaf, IconChar.Seedling, IconChar.Fish, IconChar.DrumstickBite,IconChar.Bone, IconChar.BreadSlice, IconChar.Cheese, IconChar.Cookie,    IconChar.CookieBite, IconChar.Hotdog, IconChar.CandyCane, IconChar.PepperHot,IconChar.Stroopwafel, IconChar.BowlRice,IconChar.CakeCandles,
                
                //購物與包裝類
                IconChar.ShoppingBag, IconChar.ShoppingCart, IconChar.BasketShopping, IconChar.CartPlus,
                IconChar.Store, IconChar.StoreAlt, IconChar.Gift, IconChar.Box,
                IconChar.Boxes, IconChar.BoxOpen, IconChar.Archive, IconChar.Tags,
                IconChar.Receipt, IconChar.TicketAlt,
                
                //促銷與分類標籤類
                IconChar.Star, IconChar.Heart, IconChar.Fire, IconChar.FireAlt,
                IconChar.Gem, IconChar.Crown, IconChar.Trophy, IconChar.Medal,
                IconChar.ThumbsUp, IconChar.Smile, IconChar.GrinStars, IconChar.Bolt,
                IconChar.Certificate, IconChar.Award, IconChar.StarOfLife,

                //通用分類圖示
                IconChar.ThLarge, IconChar.Th, IconChar.List, IconChar.ListUl,
                IconChar.LayerGroup, IconChar.Cubes, IconChar.Shapes, IconChar.PuzzlePiece
            };

            flowLayoutPanelIcons.Controls.Clear();

            foreach (var icon in icons)
            {
                IconButton btn = new IconButton();
                btn.IconChar = icon;
                btn.IconSize = 36;
                btn.Size = new Size(55, 55);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
                btn.Tag = icon.ToString();

                // 判斷是不是目前選中的圖示
                if (icon.ToString().Equals(SelectedIconName, StringComparison.OrdinalIgnoreCase))
                {
                    btn.BackColor = Color.FromArgb(80, 160, 255);
                    btn.IconColor = Color.White;
                    currentIconBtn = btn;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(245, 245, 245);
                    btn.IconColor = Color.FromArgb(80, 80, 80);
                }

                btn.Click += IconBtn_Click;
                flowLayoutPanelIcons.Controls.Add(btn);
            }
        }
        private void IconBtn_Click(object sender, EventArgs e)
        {
            // 把舊的按鈕顏色恢復
            if (currentIconBtn != null)
            {
                currentIconBtn.BackColor = Color.FromArgb(245, 245, 245);
                currentIconBtn.IconColor = Color.FromArgb(80, 80, 80);
            }

            //把點擊的按鈕反白
            IconButton clickedBtn = (IconButton)sender;
            clickedBtn.BackColor = Color.FromArgb(80, 160, 255);
            clickedBtn.IconColor = Color.White;
            currentIconBtn = clickedBtn;

            // 記錄選中的圖示名稱
            SelectedIconName = clickedBtn.Tag.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                UIMessageBox.ShowWarning("分類名稱不能為空白！");
                return;
            }

            CategoryName = txtName.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}