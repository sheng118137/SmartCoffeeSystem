using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCoffeeSystem.models
{
    public class CartItem
    {
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public string SpecString { get; set; } // 明細
        public int UnitPrice { get; set; }     // 最終單價 (包含加價)
        public int Quantity { get; set; }      // 購買數量

        public int Subtotal => UnitPrice * Quantity;
    }
}
