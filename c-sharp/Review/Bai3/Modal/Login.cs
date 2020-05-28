using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class Login
    {
        private string email;
        private string pass;
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Pass
        {
            get => pass;
            set => pass = value;
        }
        public Login(string email, string pass)
        {
            this.email = email;
            this.pass = pass;
        }
    }
}
