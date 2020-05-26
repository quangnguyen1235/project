using System;
using System.Collections.Generic;
using System.Text;

namespace Review
{
    static class helper
    {
        static int[] CreateArray(int n) 
        {
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(30, 60);
            }
            return arr;
        }
        public static bool IsSymmetryArray(int[] arr)
        {
            for (int i = 0; i < (arr.Length) /2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        public static void SelectionSort(ref int[] arr)
        {
            if (CheckArr(arr) == false)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int currentMin = arr[i];
                    int currenMinIndex = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (currentMin > arr[j])
                        {
                            currentMin = arr[j];
                            currenMinIndex = j;
                        }
                    }
                    if (currenMinIndex != i)
                    {
                        arr[currenMinIndex] = arr[i];
                        arr[i] = currentMin;
                    }
                }
            }
        }
        public static int Find(int found ,int[] arr, int left, int right)
        {
            if (right >= left)
            {
                int mid = (left + (right - left)) / 2;
                if (arr[mid] == found)
                {
                    return mid;
                }
                if (arr[mid] < found)
                {
                    return Find(found, arr, mid + 1, right);
                }
                if (arr[mid] > found)
                {
                    return Find(found, arr, left, mid - 1);
                }
            }
            return -1;
        }
        private static bool CheckArr(int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
