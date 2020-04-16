using System;
using System.Collections.Generic;
using System.Text;

namespace array
{
    class Bai3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("<----------Array Example 2---------->");
            Console.Write("Input row number: ");
            int row = InputRowCol();
            Console.Write("Input col number: ");
            int col = InputRowCol();
            int[,] arr1 = CreateArr(row, col);
            ShowArr(arr1,row, col);
            Menu(arr1, row, col);
            
        }
        public static int InputRowCol()
        {
            int rowCol;
            rowCol = int.Parse(Console.ReadLine());
            return rowCol;
        }
        public static int[,] CreateArr(int row, int col)
        {
            int[,] arr = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = rnd.Next(20,60);
                }
            }
            return arr;
        }
        public static void ShowArr(int[,] arr, int row, int col)
        {
            Console.WriteLine(" ----------------------------------- ");
            Console.WriteLine("This is your arr:");

            for (int i = 0; i < row; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
        public static void Menu(int[,] arr, int row, int col)
        {
            
            int option = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("<---------------Menu--------------->");
                Console.WriteLine("1. Input number and filter this array");
                Console.WriteLine("2. Input number and fill multiples this array");
                Console.WriteLine("3. Create new arry");
                Console.WriteLine("4. Exit");
                Console.WriteLine(" ----------------------------------- ");
                Console.Write("Your option: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
                Process(option, arr, row, col);
            }
            while (option == 4);
        }
        public static void Process(int opt, int[,] arr, int row, int col)
        {
            Console.Clear();
            int[,] array = new int[col, row];
            int number;
            switch (opt)
            {
                case 1:
                    {
                        Console.Write("Please input number to fill: ");
                        number = InputRowCol();
                        for (int i = 0; i < row; i++)
                        {
                            Console.WriteLine();
                            for(int j = 0; j < col; j++)
                            {
                                if (arr[i, j] == number)
                                {
                                    Console.Write(arr[i, j]+" ");
                                }
                                else
                                {
                                    Console.Write("-- ");
                                }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Please input number to find mutiples: ");
                        number = InputRowCol();
                        for (int i = 0; i < row; i++)
                        {
                            Console.WriteLine();
                            for (int j = 0; j < col; j++)
                            {
                                if (arr[i, j]%number==0)
                                {
                                    Console.Write(arr[i, j] + " ");
                                }
                                else
                                {
                                    Console.Write("-- ");
                                }
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        array = CreateArr(col, row);
                        ShowArr(array, col, row);
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            Console.WriteLine();
            ShowArr(arr, row, col);
            Menu(arr, row, col);
        }
    }
}
