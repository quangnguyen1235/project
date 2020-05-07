using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    interface IStudent
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Native { get; set; }
        public string Class { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }
        void Display();
    }
}
