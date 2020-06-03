using System;
using System.Collections.Generic;
using System.Text;

namespace FinalModul2
{
    class Matrix
    {
        public int row { get; set; }
        public int col { get; set; }
        public int[,] matrix;
        public Matrix (int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        public void InitMatrix()
        {
            matrix = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(10, 50);
                }
            }
        }
        public int Sum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public void ShowMaxrow(int[] arr)
        {
            foreach( var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        public int[] GetRow(int[,]matrix, int row)
        {
            int[] arr = new int[row];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = matrix[row, i];
            }
            return arr;
        }
        public int[] MaxRow(int[,] matrix)
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
        public void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                ShowMaxrow(GetRow(matrix, i));
            }
        }
    }
}
