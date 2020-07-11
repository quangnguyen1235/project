using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Student(int id, string name, int age, string email)
        {
            StudentID = id;
            StudentName = name;
            Age = age;
            Email = email;
        }
        public override string ToString()
        {
            return $"ID: {StudentID}\t Name: {StudentName}\t Age: {Age}\t Email: {Email}";
        }
    }
}
