using System;
using System.Data;

namespace ExamModule2
{
    class Program
    {
        public static int[,] matrix;
        static void Main(string[] args)
        {
            createMatrix(4,4);
            int[,] matrix1 = new int[4, 4]
            {
                {10,55,2,8 },
                {5,-2,10,7 },
                {8,9,10,20 },
                {11,7,12,15 }
            };
            Console.WriteLine(FindMin(matrix1));
            Console.WriteLine(DiagonalDifference(CalculateMainDiagonal(matrix1), CalculateFillerDiagonal(matrix1)));
        }
        public static void createMatrix(int row, int col)
        {
            var rnd = new Random();
            matrix = new int[row, col];
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(40, 80);
                }
            }
        }
        public static int FindMin(int[,] matrix)
        {
            int min = matrix[0,0];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }
        public static int DiagonalDifference(int a, int b)
        {
            return Math.Abs(a-b);
        }
        public static int CalculateMainDiagonal(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        public static int CalculateFillerDiagonal(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, (matrix.GetLength(0) - 1 - i)];
            }
            return sum;
        }
    }
}
