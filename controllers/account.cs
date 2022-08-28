using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStock.controllers
{
    public class account
    {
        private string username;
        private string type;
       
        private string email;
        private string password;
       


        public account(string type, string email, string password, string username)
        {
            this.type = type;
            this.email = email;
            this.password = password;
            this.username= username;
        }
       
        public string Email { get { return email; } }
        public string Username { get { return username; } }
        public string Password { get { return password; } }
        public string Type { get { return type; } }

    }
}
