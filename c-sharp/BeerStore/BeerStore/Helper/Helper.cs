using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BeerStore.Helper
{
    public static class Helper
    {
        public static string inputName()
        {
            Console.Write("Input Product Name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static int inputQlt()
        {
            Console.Write("Input Product Qlt: ");
            int qlt = int.Parse(Console.ReadLine());
            return qlt;
        }
    }
}
