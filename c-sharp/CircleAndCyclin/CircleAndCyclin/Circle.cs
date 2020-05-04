using System;
using System.Collections.Generic;
using System.Text;

namespace CircleAndCyclin
{
    class Circle
    {
        public double radius { get; set; }
        public string color { get; set; }
        public Circle(double r, string c)
        {
            radius = r;
            color = c;
        }
        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }
    }
    class Cyclin: Circle
    {
        public double height { get; set; }
        public Cyclin(double r, string c, double h): base(r, c)
        {
            height = h;
        }
        public double CalculateVolume()
        {
            return CalculateArea() * height;
        }
    }
}
