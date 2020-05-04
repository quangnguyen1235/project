using System;

namespace Geogegraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(3, 5);
            Console.WriteLine($"area is: {rec.CalculateArea()}");
            Console.WriteLine(rec.ShowInfo());
        }
    }
}
