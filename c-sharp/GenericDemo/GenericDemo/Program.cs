using System;
using System.Collections;
using System.Collections.Generic;
namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack ts = new Stack();
            Stack<int> vs = new Stack<int>();
            Queue<string> vs1 = new Queue<string>();
            SortedList<int, Employee> list = new SortedList<int, Employee>();
            LinkedList<Employee> employees = new LinkedList<Employee>();
            MyGeneric<Employee> myGeneric = new MyGeneric<Employee>();
            myGeneric.Add(new Employee()
            {
                Employeeid = 1,
                Name = "quang"
            });
            foreach (var item in myGeneric.MG)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Employee
    {
        public int Employeeid { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Employeeid}\t {Name}";
        }
    }
}
