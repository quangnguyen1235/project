using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement
{
    class ClassStudent
    {
        public Student student;
        public Classes classes;
        public int StudentID { get => student.StudentID; set => student.StudentID = value; }
        public int ClassID { get => classes.ClassID; set => classes.ClassID = value; }
    }
}
