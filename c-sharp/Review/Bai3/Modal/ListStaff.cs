using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.Modal
{
    class ListStaff
    {
        public List<Staff> staffs { get; set; }
        public void CreateStaff(string name, string email, string pass)
        {
            Staff newStaff = new Staff(name, new Login(email, pass));
            staffs.Add(newStaff);
        }
    }
}
