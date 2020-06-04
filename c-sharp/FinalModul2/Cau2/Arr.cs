using System;
using System.Collections.Generic;
using System.Text;

namespace Cau2
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
            return arr;
        }
        public bool IsSymmetryArray()
        {
            for (int i = 0; i < (arr.Length) / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        public void SelectionSort()
        {
            if (CheckArr() == false)
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
        public bool CheckArr()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public override string ToString()
        {
            string result = "";
            foreach (var item in arr)
            {
                result += item + " ";
            }
            return result;
        }
    }
}
