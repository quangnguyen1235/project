using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

namespace SearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 5, 7, 6, 8, 4, 12, 15, 13, 9 };
            //Console.Write("input value: ");
            //int value = int.Parse(Console.ReadLine());
            //int pos = LinearSearch(arr1, value);
            //if (pos > -1)
            //{
            //    Console.WriteLine($"Your value {value} stand at {pos} in array");
            //}
            //else
            //{
            //    Console.WriteLine("not Found!");
            //}
            //Console.WriteLine($"{value}! = {Giaithua(value)}");
            //Console.WriteLine($"{value}! = {Giaithua2(value)}");
            //int[] arr = Fibonaci();
            //foreach(var item in arr)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();
            //Console.WriteLine(Fibonaci(value));
            //Console.WriteLine($"To hop chap 2 cua 9 phan tu: {ToHop(2,9)}");
            int[] arr = SortArr( arr1);
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            };
        }
        static int LinearSearch (int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        static long Giaithua(long n)
        {
            if(n < 2)
            {
                return 1;
            }
            return n * Giaithua(n - 1);
        } 
        static long Giaithua2(long n)
        {
            long gt = 1;
            for (long i = 1; i <= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
        // n = (n-1) + (n-2)
        static int[] Fibonaci()
        {
            int[] arr = new int[] {1,2};
            for (int i = 0; i < 20; i++)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = arr[arr.Length - 2] + arr[arr.Length - 3];
            }
            return arr;
        }
        static int Fibonaci(int n)
        {
            if ( n == 1 )
            {
                return 1;
            }
            if ( n == 2)
            {
                return 2;
            }
            return Fibonaci(n - 1) + Fibonaci(n - 2);
        }
        static int GT( int n )
        {
            if ( n < 2)
            {
                return 1;
            }
            return n * GT(n - 1);
        }
        static int ToHop(int k, int n)
        {
            return (GT(n)/(GT(k)*GT(n-k)));
        }
        static int[] SortArr(int[] arr)
        {
            bool needSwap = true;
            int swap;
            for (int k = 1; k < arr.Length && needSwap; k++)
            {
                needSwap = false;
                for (int i = 0; i < arr.Length - k; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        swap = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = swap;
                        needSwap = true;
                    }
                }
            }
            //for (int k = arr.Length; k >= 1; k--)
            //{
            //    for (int i = arr.Length; i >= 0; i--)
            //    {
            //        if (arr[i] < arr[i - 1])
            //        {
            //            swap = arr[i - 1];
            //            arr[i] = arr[i - 1];
            //            arr[i] = swap;
            //        }
            //    }
            //}
            return arr;
        }
    }
}
