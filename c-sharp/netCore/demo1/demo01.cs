using System;
using System.Collections.Generic;
using System.Text;

namespace demo1
{
    class demo01
    {
        public static void Main(string[] args)
        {
            int age = 0;
            string fullName = "";
            Console.WriteLine("my Fist");
            Console.Write("pls input fullname ");
            fullName = Console.ReadLine().ToString();
            Console.Write("input your age ");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("your name is " + fullName + " and your age is " + age);
            Console.ReadKey();

        }
    }
}
