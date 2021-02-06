using System;
using System.Collections.Generic;
using System.Text;

namespace Math.Geometry
{
    public abstract class Qadrilateral
    {
        public Point p;
        public abstract int Area();
        public abstract int Perimeter();
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
