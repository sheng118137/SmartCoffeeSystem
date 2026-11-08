using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCoffeeSystem.models
{
    public class OptionItem
    {
        public string Name { get; set; }  // 顯示文字
        public int ExtraPrice { get; set; } // 加價金額
        public string Note { get; set; }

        // 自動組裝畫面文字
        public string GetDisplayText()
        {
            return ExtraPrice > 0 ? $"{Name} (+${ExtraPrice})" : Name;
        }
    }
}
