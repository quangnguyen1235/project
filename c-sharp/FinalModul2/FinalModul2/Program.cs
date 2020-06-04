using System;

namespace FinalModul2
{
    using System;
    namespace Demo
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.Write("Matrix's row: ");
                int.TryParse(Console.ReadLine(), out int n);
                Console.Write("Matrix's col: ");
                int.TryParse(Console.ReadLine(), out int m);
                if (n <= 0 || m <= 0)
                {
                    Console.WriteLine("Can't create matrix!");
                }
                else
                {
                    int[,] matrix = InitMatrix(n, m);
                    Console.WriteLine("Matrix: ");
                    ShowMatrix(matrix);
                    Console.WriteLine("Max Row: ");
                    ShowArray(MaxRow(matrix));
                }
            }
            static int[,] InitMatrix(int n, int m)
            {
                Random rd = new Random();
                int[,] matrix = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrix[i, j] = rd.Next(10, 50);
                    }
                }
                return matrix;
            }
            static int Sum(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += i;
                }
                return sum;
            }
            static int[] MaxRow(int[,] matrix)
            {
                int[] maxRow = GetRow(matrix, 0);
                int SumMaxRow = Sum(maxRow);
                for (int i = 1; i < matrix.GetLength(0); i++)
                {
                    if (SumMaxRow < Sum(GetRow(matrix, i)))
                    {
                        maxRow = GetRow(matrix, i);
                        SumMaxRow = Sum(maxRow);
                    }
                }
                return maxRow;
            }
            static int[] GetRow(int[,] matrix, int row)
            {
                int[] array = new int[matrix.GetLength(1)];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = matrix[row, i];
                }
                return array;
            }
            static void ShowArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            static void ShowMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    ShowArray(GetRow(matrix, i));
                }
            }
        }
    }
}
