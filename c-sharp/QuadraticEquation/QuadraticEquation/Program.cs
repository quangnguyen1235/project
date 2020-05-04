using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Please input A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please input C");
            c = double.Parse(Console.ReadLine());
            QuadraticEquation quadra = new QuadraticEquation(a, b, c);
            quadra.Dislay();
        }
    }
}
