using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement
{
    class Mark
    {
        public Subject subject;
        public Student student;
        public int _Mark { get; set; }
        public int StudentID { get => student.StudentID; set => student.StudentID = value; }
        public int SubjectID { get => subject.SubjectID; set => subject.SubjectID = value; }
    }
}
