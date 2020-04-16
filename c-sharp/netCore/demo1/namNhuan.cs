using System;
using System.Collections.Generic;
using System.Text;

namespace chuong1
{
    class namNhuan
    {
        public static void Main(string[] args)
        {
            int year;
            bool ifLeapYear = false;
            Console.WriteLine("----Leap Year----");
            Console.Write("Pls input year number: ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year%4==0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        ifLeapYear = true;
                    }
                }
                else {
                    ifLeapYear = true;
                }
            }
            if (ifLeapYear)
            {
                Console.WriteLine("This year is leap!");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("This year is not leap!");
                Console.ReadKey();
            }
        }
    }
}
