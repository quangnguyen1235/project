using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement
{
    class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public Subject(int id, string name)
        {
            SubjectID = id;
            SubjectName = name;
        }
    }
}
