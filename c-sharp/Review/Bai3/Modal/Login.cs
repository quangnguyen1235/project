using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class Login
    {
        private string email;
        private string pass; 
        public string Email { get; set; }
        public string Pass { get; set; }
        public Login(string email, string pass)
        {
            this.email = email;
            this.pass = pass;
        }
    }
}
