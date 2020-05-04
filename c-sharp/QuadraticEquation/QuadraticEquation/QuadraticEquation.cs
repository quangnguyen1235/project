using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        //ax2+bx+c=0
        private double a;
        private double b;
        private double c;
        public double A
        {
            get => a;
            set => a = value;
        }
        public double B
        {
            get => b;
            set => b = value;
        }
        public double C
        {
            get => c;
            set => c = value;
        }
        public QuadraticEquation(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double GetDiscriminant()
        {
            return Math.Pow(B, 2) - 4 * B * C;
        }
        public double GetRoot1()
        {
            return ((-B + Math.Sqrt(GetDiscriminant())) / (2 * A));
        }
        public double GetRoot2()
        {
            return ((-B - Math.Sqrt(GetDiscriminant())) / (2 * A));
        }
        public void Dislay()
        {
            if (GetDiscriminant() < 0)
            {
                Console.WriteLine("The equation has no roots");
            }
            else if (GetDiscriminant() == 0)
            {
                Console.WriteLine($"The double root is{GetRoot1()}");
            }
            else
            {
                Console.WriteLine($"Root 1 is:{GetRoot1()}");
                Console.WriteLine($"Root 2 is:{GetRoot2()}");
            }
        }
    }
}
