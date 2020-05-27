using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class IntMatrix
    {
        public int[,] matrix { get; set; }
        public int row { get; set; }
        public int col { get; set; }
        public IntMatrix(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        public int[,] CreateMatrix()
        {
            matrix = new int[row, col];
            var rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(10, 50);
                }
            }
            return matrix;
        }
        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    result += matrix[i,j]+" ";
                }
                result += $"\n";
            }
            return result;
        }
    }
}
