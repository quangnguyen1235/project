using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class Staff
    {
        public string name { get; set; }
        public Login loginDetail { get; set; }
        public Staff(string name, Login newLogin)
        {
            this.name = name;
            this.loginDetail = newLogin;
        }
        public void editPassWord(string password, string newPass)
        {
            if(loginDetail.Pass == password)
            {
                loginDetail.Pass = newPass;
            }
        }
    }
}
