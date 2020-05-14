using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace MatrixDemo
{
    public class Matrix
    {
        public static int SumOfMatrix(int[,] matrix)
        {
            int sum = 0;
            foreach(var item in matrix)
            {
                sum += item;
            }
            return sum;
        }
        public static int NumofPrime(int[,] matrix)
        {
            int qltPrime = 0;
            foreach(var item in matrix)
            {
                if (isPrime(item))
                {
                    qltPrime += 1;
                }
            }
            return qltPrime;
        }
        public static int NumofOld(int[,] matrix)
        {
            int qltOld = 0;
            foreach(var item in matrix)
            {
                if (isOld(item))
                {
                    qltOld += 1;
                }
            }
            return qltOld;
        }
        public static bool isPrime(int num)
        {
            bool flag = true;
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static int SumofDigonal(int row, int col, int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == col - i - 1)
                    {
                        sum = sum + matrix[i, j];
                    }
                    continue;
                }
            }
            return sum;
        }
        public static bool isOld(int num)
        {
            bool flag = true;
            if (num % 2 == 0)
            {
                flag = false;
            }
            return flag;
        }
    }
}
