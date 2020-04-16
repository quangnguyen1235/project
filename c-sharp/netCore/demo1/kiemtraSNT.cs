using System;
using System.Collections.Generic;
using System.Text;

namespace demo1
{
    class kiemtraSNT
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("KIEMTRASNT");
            int number;
            Console.Write("enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2 ) Console.WriteLine("is not Prime");
            else
            {
                int i = 2;
                bool flag = true;
                for (i = 2; i<= Math.Sqrt(number); i++)
                {
                    if (number%i==0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("is Prime");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("is not Prime");
                    Console.ReadKey();
                }
            }
        }
    }
}
