using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CollectionDemono.SoftDemo
{
    class SoftListDemo
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add("12348", new Student()
            {
                FullName = "quang",
                Dob = DateTime.Parse("2020/01/20")
            }
                );
            s1.Add("12346", new Student()
            {
                FullName = "quang",
                Dob = DateTime.Parse("2020/01/20")
            }
                );
            s1.Add("12347", new Student()
            {
                FullName = "quang",
                Dob = DateTime.Parse("2020/01/20")
            }
                );
            foreach (var item in s1.Keys)
            {
                Console.WriteLine(item);
                Console.WriteLine(s1[item].ToString());
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
