using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CollectionDemono.HashDemo
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hb1 = new Hashtable();
            hb1.Add("12345", new Student()
                {
                FullName = "quang",
                Dob = DateTime.Parse("2020/01/20")
                }
                );
            hb1.Add("12346", new Student()
                {
                FullName = "quang",
                Dob = DateTime.Parse("2020/01/20")
                }
                );
            hb1.Add("12347", new Student()
                {
                FullName = "quang",
                Dob = DateTime.Parse("2020/01/20")
                }
                );
            foreach(var item in hb1.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
    class Student
    {
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public override string ToString()
        {
            return $"{FullName}\t {Dob.ToString("dd/MM/yyy")}";
        }
    }
}
