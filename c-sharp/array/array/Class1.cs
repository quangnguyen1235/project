using System;
using System.Collections.Generic;
using System.Text;

namespace array
{
    class Bai2
    {
        public static void Main(string[] args)
        {
            int rowCol;
            int[,] Intarr1;
            int[,] Intarr2;
            rowCol = InputRowCol();
            Intarr1 = CreateArr(rowCol);
            Intarr2 = CreateArr(rowCol);
            Console.WriteLine("This is your arr1");
            ShowArr(Intarr1, rowCol);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("This is your arr2");
            ShowArr(Intarr2, rowCol);
            Menu(Intarr1, Intarr2, rowCol);
         }
        public static int InputRowCol()
        {
            int rowCol;
            Console.Write("Please input RowCol: ");
            rowCol = int.Parse(Console.ReadLine());
            return rowCol;
        }
        public static int[,] CreateArr(int rowCol)
        {
            int[,] arr = new int[rowCol, rowCol];
            Random rnd = new Random();
            for (int i = 0; i < rowCol; i++)
            {
                for (int j = 0; j < rowCol; j++)
                {
                    arr[i, j] = rnd.Next(10, 40);
                }
            }
            return arr;
        }
        public static void ShowArr(int[,] arr, int rowCol)
        {
            
            for (int i = 0; i < rowCol; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < rowCol; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
        public static void Menu(int[,] arr1, int[,] arr2, int rowCol)
        {
            int option = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Sum of two array");
                Console.WriteLine("2. Products of two array");
                Console.WriteLine("3. Exit");
                Console.WriteLine("----------------------------------");
                Console.Write("Your option: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
                ProcessSumProducts(option, arr1, arr2, rowCol);
            }
            while (option == 3);
        }
        public static void ProcessSumProducts(int opt, int[,] arr1, int[,] arr2, int rowCol)
        {
            int[,] arrAll = new int [rowCol,rowCol];
            Console.Clear();
            Console.WriteLine("This is your arr1");
            ShowArr(arr1, rowCol);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("This is your arr2");
            ShowArr(arr2, rowCol);
            switch (opt)
            {
                case 1:
                    {   for (int i = 0; i < rowCol; i++)
                        {
                            for (int j = 0; j < rowCol; j++)
                            {
                                arrAll[i, j] = arr1[i, j] + arr2[i, j];
                            }
                        }
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Your sum of two array is");
                        ShowArr(arrAll, rowCol);
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < rowCol; i++)
                        {
                            for (int j = 0; j < rowCol; j++)
                            {
                                arrAll[i, j] = arr1[i, j] * arr2[i, j];
                            }
                        }
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Your products of two array is");
                        ShowArr(arrAll, rowCol);
                        break;
                    }
                case 3:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            Menu(arr1, arr2, rowCol);
        }
    }
}