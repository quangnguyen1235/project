using System;
using System.Collections.Generic;
using System.Text;

namespace chuong1
{
    class menu
    {
        public static void Main(string[] args)
        {
            createMenu();
        }
        public static void createMenu()
        {
            int option = 0;
            int[] numbers = { };
            do
            {
                Console.Clear();
                Console.WriteLine("PROGRAM");
                Console.WriteLine("PRESS 1 TO CREATE NEW ARRAY!");
                Console.WriteLine("PRESS 2 TO SHOW THE ARRAY!");
                Console.WriteLine("PRESS 3 TO SHOW TOTAL OF THE ARRAY!");
                Console.WriteLine("PRESS 4 TO SHOW INSERT NUMBER OF THE ARRAY!");
                Console.WriteLine("PRESS 5 TO SHOW ODD NUMBER OF THE ARRAY!");
                Console.WriteLine("PRESS 6 TO EXIT THE PROGRAM");
                Console.Write("OPTION: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option!=6);
            Process(option, ref numbers);
        }
        public static void Process(int option, ref int[] intArr)
        {
            Console.Clear();
            switch (option)
            {
                case 1:
                    {
                        creArray();
                        break;
                    };
                case 2:
                    {
                        showArr(creArray());
                        break;
                    };
                case 3:
                    {
                        Console.WriteLine(totalArr(creArray()));
                        break;
                    }
                case 4:
                    {
                        displayEven(creArray());
                        break;
                    }
            }
        }
        static int[] creArray()
        {
            int[] intArr = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                intArr[i] = rnd.Next(10, 50);
            }
            return intArr;
        }
        
        static int totalArr(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < 20; i++)
            {
                total = total + arr[i];
            }
            return total;
        }
        public static void showArr(int[] arr)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Element[{0}]: {1}", i, arr[i]);
            }
        }
        static void displayEven(int[] arr)
        {
            Console.WriteLine();
            Console.Write("Cac so chan co trong mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    Console.Write(arr[i] + " ");
            }
        }
    }
}
