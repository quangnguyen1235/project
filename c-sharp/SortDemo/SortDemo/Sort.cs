using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Transactions;

namespace SortDemo
{
    public static class Sort
    {
        static public void InsertionSort(ref int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[i] < arr[j - 1]) --j;
                int tmp = arr[i];
                for (int k = i; k > j; k--)
                    arr[k] = arr[k - 1];
                arr[j] = tmp;
            }
        }
        static public void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
