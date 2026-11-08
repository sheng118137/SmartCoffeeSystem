using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCoffeeSystem.models
{
    // 用來綁DataGridView
    public class ProductView
    {
        public int? Sort { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int? Price { get; set; }
        public string Status { get; set; }
        public int? Stock { get; set; }

    }
}

