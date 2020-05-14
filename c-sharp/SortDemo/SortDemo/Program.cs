using System;

namespace SortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9,7,8, 6,10,15,12 };
            Sort.InsertionSort(ref arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
