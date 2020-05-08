using System;
using System.Diagnostics.CodeAnalysis;

namespace Examination
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input Row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("input Col: ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = CreateMatrix(row, col);
            ShowMatrix(matrix, row, col);
            Console.WriteLine();
            int[] sum = Sum(matrix, row, col);
            for(int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine(sum[i] + " ");
            }
            Console.WriteLine();
            int maRow = FindMaxRow(sum);
            Console.WriteLine(maRow);
            ShowMaxRow(matrix, row, col, maRow);
        }
        public static int[,] CreateMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(10, 50);
                }
            }
            return matrix;
        }
        public static int[] Sum(int [,] matrix, int row, int col)
        {
            int[] sum = new int[row];
            for (int i = 0; i < row; i++)
            {
                sum[i] = 0;
                for (int j = 0; j < col; j++)
                {
                    sum[i] += matrix[i, j];
                }
            }
            return sum;
        }
        public static int FindMaxRow(int [] sum)
        {
            int maxRow = 0;
            int max = sum[0];
            for (int i = 1; i < sum.Length; i++)
            {
                if(sum[i] > max)
                {
                    maxRow = i;
                }
            }
            return maxRow;
        }
        public static void ShowMaxRow(int[,] matrix, int row, int col, int maxRow)
        {
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if ( i == maxRow)
                    {
                        Console.Write(" "+matrix[i, j]);
                    }
                }
            }
        }
        public static void ShowMatrix(int[,] matrix, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
            }
        }
    }
}
