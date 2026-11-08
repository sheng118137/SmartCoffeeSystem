using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCoffeeSystem.models
{
    public class OrderView
    {
        public  int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderType { get; set; }
        public int FinalAmount { get; set; }
        public int OrderSort { get; set; }
        public string StatusText { get; set; }

    }
}
