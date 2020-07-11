using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement
{
    class Classes
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public Classes(int id, string name)
        {
            ClassID = id;
            ClassName = name;
        }
    }
}
