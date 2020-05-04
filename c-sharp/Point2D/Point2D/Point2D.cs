using System;
using System.Collections.Generic;
using System.Text;

namespace Point2D
{
    class Point2D
    {
        public float x { get; set; }
        public float y { get; set; }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{x},{y}";
        }
    }
}
