using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        private int width;
        private int height;
        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public int getArea()
        {
            return Width * Height;
        }
        public int getPerimeter()
        {
            return (Width + Height) * 2;
        }
        public void Dislay()
        {
            Console.WriteLine($"Area is: {getArea()}");
            Console.WriteLine($"Perimeter: {getPerimeter()}");
        }
    }
}
