using System;
using System.Collections;

namespace CollectionDemono
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList
            arr1 = new ArrayList();
            arr1.Add(1);
            arr1.Add('2');
            arr1.Add("Quang");
            arr1.Add(null);
            arr1.Add(new Student()
            {
                Dob = DateTime.Parse("1998/01/20"),
                FullName = "Quang"
            });
            //foreach(var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < arr1.Count; i++);
            ArrayList arr2 = new ArrayList()
            {
                new Student()
                {
                    FullName = "quang",
                    Dob = DateTime.Parse("2020/01/20")
                },
                 new Student()
                {
                    FullName = "minh",
                    Dob = DateTime.Parse("2020/01/20")
                },
                  new Student()
                {
                    FullName = "trung",
                    Dob = DateTime.Parse("2020/01/20")
                }
            };
            arr2.Sort(new CustomSoft());
            
            foreach (var item in arr2)
            {
                Console.WriteLine(item.ToString());
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
    class CustomSoft : IComparer
    {
        public int Compare(object x, object y)
        {
            return string.Compare(((Student)x).FullName,((Student)y).FullName);
        }
    }
}
