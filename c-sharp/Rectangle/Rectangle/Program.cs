using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;
            Console.WriteLine("Please input width: ");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input height: ");
            height = int.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(width, height);
            rec.Dislay();
        }
    }
}
