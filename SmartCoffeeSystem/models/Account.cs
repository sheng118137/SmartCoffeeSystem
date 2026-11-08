using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCoffeeSystem.models
{
    public class Account
    {
        public int EmployessID { get; set; } 
        public string Accounts { get; set; }
        public string Password { get; set; }

        public bool IsLocked { get; set; }

        public int FailedLoginCount{ get; set; }

        public DateTime? Lockuntil { get; set; }
    }
}
