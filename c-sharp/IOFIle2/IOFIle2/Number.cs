using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IOFIle2
{
    public class Number
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        private int sum;
        public Number Multi(int num)
        {
            return new Number
            {
                a = a * num,
                b = b * num,
                c = c * num,
            };
        }
        public int Sum()
        {
            return sum = a + b + c;
        }
        public override string ToString()
        {
            return $"a: {a}\t b: {b}\t c: {c}";
        }
    }
}
