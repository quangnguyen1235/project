using System;

namespace MyListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> ListofInt = new MyList<int>();
            ListofInt.Add(10);
            ListofInt.Add(15);
            ListofInt.Add(20);
            ListofInt.Add(30);
            ListofInt.Add(50);
            ListofInt.Add(10);
            ListofInt.Add(15);
            ListofInt.Add(20);
            ListofInt.Add(30);
            ListofInt.Add(50);
            ListofInt.Add(10);
            ListofInt.Add(15);
            ListofInt.Add(20);
            ListofInt.Add(30);
            ListofInt.Add(50);
            ListofInt.Add(10);
            ListofInt.Add(15);
            ListofInt.Add(20);
            ListofInt.Add(30);
            ListofInt.Add(50);
            ListofInt.Add(10);
            for (int i = 0; i < ListofInt.Length; i++)
            {
                Console.WriteLine($"item{i}: {ListofInt.GetData(i)}");
            }
            Console.WriteLine(ListofInt.Length);
            ListofInt.GetData(-1);
        }
    }
}
