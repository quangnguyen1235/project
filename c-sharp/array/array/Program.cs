using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArr;
            int rowCol;
            rowCol = InputRowCol();
            intArr = CreateArr(rowCol);
            ShowArr(intArr, rowCol);
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Sum(intArr, rowCol);
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
                    arr[i, j] = rnd.Next(10, 90);
                }
            }
            return arr;
        }
        public static void ShowArr(int[,] arr, int rowCol)
        {
            Console.WriteLine("This is your arr ");
           
            for (int i = 0; i < rowCol; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < rowCol; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
        public static void Sum(int[,] arr, int rowCol)
        {   
            int option = 0 ;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Sum of insert");
                Console.WriteLine("2. Sum of main diagonal");
                Console.WriteLine("3. Sum of filler diagonal");
                Console.WriteLine("4. Sum of borderline");
                Console.WriteLine("5. Show upper triangula matrix");
                Console.WriteLine("6. Show lower triagula matrix");
                Console.WriteLine("7. Exit");
                Console.WriteLine("----------------------------------");
                Console.Write("Your option: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
                ProcessSum(option, arr, rowCol);
            }
            while (option == 7);
            
        }
        public static void ProcessSum(int opt, int[,] arr, int rowCol)
        {
            Console.Clear();
            int sum = 0;
            switch (opt)
            {   
                // Sum of insert nums
                case 1:
                    {
                        for (int i = 0; i < rowCol; i++)
                        {
                            for (int j = 0; j < rowCol; j++)
                            {
                                if (arr[i, j] % 2 == 0)
                                {
                                    sum = sum + arr[i, j];
                                }
                                continue;
                            }
                        }
                        Console.WriteLine("Sum of insert numbers is: {0}", sum);
                        Console.WriteLine("----------------------------------");
                        break;
                    }
                // Sum of main diagonal
                case 2:
                    {
                        for (int i = 0; i < rowCol; i++)
                        {
                            for (int j = 0; j < rowCol; j++)
                            {
                                if (i == j)
                                {
                                    sum = sum + arr[i, j];
                                }
                                continue;
                            }
                        }
                        Console.WriteLine("Sum of main diagonal is: {0}", sum);
                        Console.WriteLine("----------------------------------");
                        break;
                    }
                // Sum of filler diagonal
                case 3:
                    {
                        for (int i = 0; i < rowCol; i++)
                        {
                            for (int j = 0 ; j < rowCol ; j++)
                            {
                                if (j == rowCol-i-1)
                                {
                                    sum = sum + arr[i, j];
                                }
                                continue;
                            }
                        }
                        Console.WriteLine("Sum of filler diagonal is: {0}", sum);
                        Console.WriteLine("----------------------------------");
                        break;
                    }
                // Sum of main borderline
                case 4:
                    {
                        for (int i = 0; i < rowCol; i++)
                        {
                            for (int j = 0; j < rowCol; j++)
                            {
                                if( i == 0 || j == 0 || i == rowCol-1 || j == rowCol-1)
                                {
                                    sum = sum + arr[i, j];
                                }
                                continue;
                            }
                        }
                        Console.WriteLine("Sum of borderline is: {0}", sum);
                        Console.WriteLine("----------------------------------");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Your upper triangula matrix:");
                        Console.WriteLine("----------------------------------");
                        for (int i = 0; i < rowCol; i++)
                        {
                            Console.Write("\n");
                            for (int j = 0; j < rowCol; j++)
                            {
                                if (i >= j)
                                {
                                    Console.Write("   ");
                                }
                                else
                                {
                                    Console.Write(arr[i, j] + " ");
                                }
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Your lower triangula matrix:");
                        Console.WriteLine("----------------------------------");
                        for (int i = 0; i < rowCol; i++)
                        {
                            Console.Write("\n");
                            for (int j = 0; j < rowCol; j++)
                            {
                                if (i > j)
                                {
                                    Console.Write(arr[i, j] + " ");
                                }
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------");
                        break;
                    }

                case 7:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            ShowArr(arr, rowCol);
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Sum(arr, rowCol);
        }
    }
}
