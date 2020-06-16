using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string department { get; set; }
        public string avatarPath { get; set; }
        public Employee(int id, string name, string depath, string ava)
        {
            this.id = id;
            this.fullName = name;
            this.department = depath;
            this.avatarPath = ava;
        }
    }
}
