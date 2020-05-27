using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    static class Helper
    {
        public static IntMatrix CreateMutipleMatrix(IntMatrix matrix1, IntMatrix matrix2)
        {
            IntMatrix mutipleMatrix = new IntMatrix(matrix1.row, matrix2.col);
            mutipleMatrix.matrix = CalculateMutipleMatrix(matrix1.matrix, matrix2.matrix);
            return mutipleMatrix;
        }
        public static int[,] CalculateMutipleMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] mutipleMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        sum = sum + matrix1[i, k] * matrix2[k, j];
                    }
                    mutipleMatrix[i, j] = sum;
                }
            }
            return mutipleMatrix;
        }
    }
}
