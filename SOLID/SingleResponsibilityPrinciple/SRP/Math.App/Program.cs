using Math.Geometry;
using System;
using System.Collections.Generic;

namespace Math.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Qadrilateral rect1 = new Rectangle(0, 0, 23, 43);
            Qadrilateral rect2 = new Rectangle(4, -2, 3, 1);
            Qadrilateral rect3 = new Rectangle(2, 2, 4, 9);
            Qadrilateral rect4 = new Rectangle(3, 22, 2, 5);
            Qadrilateral rect5 = new Rectangle(31, 23, 33, 23);

            IEnumerable<Qadrilateral> rectList = new List<Qadrilateral>
            {
                rect1,
                rect2,
                rect3,
                rect4,
                rect5
            };

            foreach(var rect in rectList)
            {
                Console.WriteLine("Calculating rectangle...");
                Console.WriteLine($"Area: {rect.Area()}");
                Console.WriteLine($"Perimeter: {rect.Perimeter()}");
                Console.WriteLine();
            }

        }
    }
}
