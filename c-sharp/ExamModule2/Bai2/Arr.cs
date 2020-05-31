using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class Arr
    {
        public int[] arr { get; set; }
        public int[] CreateArray(int n)
        {
            arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(30, 60);

            }
            Console.WriteLine();
            return arr;
        }
        public bool Isincrement()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                return (arr[i] >= arr[i + 1]);
            }
            return false;
        }
        public void BubbleSort()
        {
            bool needNextPass = true; for (int k = 1; k < arr.Length && needNextPass; k++)
            {
                needNextPass = false;
                for (int i = 0; i < arr.Length - k; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        needNextPass = true;
                    }
                }
            }
        }
         public int Find(int found, int left, int right)
        {
            if (right >= left)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == found)
                {
                    return mid;
                }
                if (arr[mid] > found)
                {
                    return Find(found, left, (mid - 1));
                }
                if (arr[mid] < found)
                {
                    return Find(found, (mid + 1), right);
                }
            }
            return -1;
        }
    }
}
