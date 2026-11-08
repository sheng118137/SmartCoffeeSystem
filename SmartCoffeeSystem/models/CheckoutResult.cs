using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCoffeeSystem.models
{
    public class CheckoutResult
    {
        public bool IsMember { get; set; } = false;
        public int? MemberID { get; set; } = null;
        public string MemberPhone { get; set; } = "";
        public string PaymentMethod { get; set; } = "現金";
        public string CarrierType { get; set; } = "紙本發票";
        public string CarrierNumber { get; set; } = "";
        public int TotalAmount { get; set; }
        public int DiscountAmount { get; set; } = 0;
        public int FinalAmount { get; set; }
        public int UsedPoints { get; set; }
    }
}
