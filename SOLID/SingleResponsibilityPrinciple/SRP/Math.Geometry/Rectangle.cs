using System;
using System.Collections.Generic;
using System.Text;

namespace Math.Geometry
{
    public class Rectangle : Qadrilateral
    {
        private int _length;
        private int _width;
        public int Length {
            get => _length;
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = 1;
            }        
        }

        public int Width {
            get => _width;
            set 
            {
                if (value > 0)
                    _width = value;
                else
                    _width = 1;
            }
    }

        public Rectangle(int x, int y, int length, int width)
        {
            this.p = new Point(x, y);
            if(length != width)
            {
               Length = length;
               Width = width;
            }
            else
            {
                //don't allow the creation of a square
                throw new ArgumentException();
            }
        }

        public override int Area() => Length * Width;


        public override int Perimeter() => 2 * (Length + Width);

    }
}
