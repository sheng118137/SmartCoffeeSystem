using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCoffeeSystem.models
{
    public class Accounts
    {
        public int EmployeeId { get; set; }

        // Username / account name
        public string Account { get; set; }

        // Hashed password (never store plain text)
        public string Password { get; set; }

        // Account creation time
        public DateTime? CreateTime { get; set; }

        // Related employee id
        public string Email { get; set; }

        public Accounts() 
        {
        
        }
    }
}
