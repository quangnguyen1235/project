using System;
using System.Collections.Generic;
using System.Text;

namespace Geogegraph
{
    abstract class Geometric
    {
        private double side1;
        private double side2;
        public double Side1
        {
            get => side1;
            set => side1 = value;
        }
        public double Side2
        {
            get => side2;
            set => side2 = value;
        }
        public Geometric (double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public abstract double CalculateArea();
        public virtual string ShowInfo()
        {
            return $"side1 is: {side1} side2 is: {side2}";
        }
    }
    class Rectangle: Geometric
    {
        public Rectangle(double lenght, double width) : base(lenght, width)
        {

        }
        public override double CalculateArea()
        {
            return Side1 * Side2;
        }
        public override string ShowInfo()
        {
            return$"length is: {Side1}\t width is: {Side2}";
        }
    }
    class Circle: Geometric
    {
        public Circle(double radius): base(radius, Math.PI)
        {

        }
        public override double CalculateArea()
        {
            return Side2*Math.Pow(Side1,2);
        }
        public override string ShowInfo()
        {
            return base.ShowInfo();
        }
    }
    class Square: Geometric
    {
        public Square(double width): base(width, width)
        {

        }
        public override double CalculateArea()
        {
            return 4 * Side1;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo();
        }
    }
}
