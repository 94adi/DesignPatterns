using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Graphics.Geometry
{
    public class Rectangle : IFigure
    {       
        public void Draw(int x, int y, params int[] paramList)
        {
            Console.WriteLine("Drawing Rectangle.....");
            Console.WriteLine($"X:{x} Y:{y}");
            Console.WriteLine($"Length:{paramList[0]}");
            Console.WriteLine($"Width:{paramList[1]}");
            Console.WriteLine("Rendering image...");
            Console.WriteLine("Finished!");
        }
    }
}
