using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using BCrypt;
using System.Windows.Forms;
using SmartCoffeeSystem.models; // keep models for helper classes; no change needed for EF entities here



namespace SmartCoffeeSystem.Services
{
    public class Services : Accounts
    {
        public static string HashPassword(string userPassword)
        {
            userPassword = BCrypt.Net.BCrypt.HashPassword(userPassword);
            return userPassword;
            

        }
    }


}
