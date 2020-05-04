using System;

namespace CircleAndCyclin
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.5, "Blue");
            Console.WriteLine($"The circle area is: {circle.CalculateArea()}, This Color is: {circle.color}");
            Cyclin cyclin = new Cyclin(3.5, "Black", 4);
            Console.WriteLine($"The cyclin base area is: {cyclin.CalculateArea()}, This cyclin volume is: {cyclin.CalculateVolume()}, This color is: {cyclin.color}");
        }
    }
}

