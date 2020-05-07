using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace StudentManagementSystem
{
    public class Student : IStudent
    {
        private string name;
        private int id;
        private DateTime dateofbirth;
        private string native;
        private string classes;
        private string phoneNo;
        private int mobile;
        public string Name { get => name; set => name = value; }
        public int ID { get => id; set => id = value; }
        public DateTime DateofBirth { get => dateofbirth; set => dateofbirth = value; }
        public string Native { get => native; set => native = value; }
        public string Class { get => classes; set => classes = value; }
        public string PhoneNo { get => PhoneNo; set => phoneNo = value; }
        public int Mobile { get => mobile; set => mobile = value; }

        public void Display()
        {
            Console.WriteLine($"ID: {id}\t FullName: {name}\t DOB: {dateofbirth}\t Native: {native}\t Class: {classes}\t PhoneNO: {phoneNo}\t Moblie: {mobile}");
        }
    }
}
