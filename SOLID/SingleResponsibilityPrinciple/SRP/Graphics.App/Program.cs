using Graphics.Geometry;
using Math.Geometry;
using System;

namespace Graphics.App
{
    class Program
    {
        private const int MAX_AREA = 1000;
        private const int MAX_PERIMETER = 1000;
        static void Main(string[] args)
        {
            Math.Geometry.Rectangle figure = (Math.Geometry.Rectangle)new Math.Geometry.Rectangle(1, -1, 2, 4);
            var area = figure.Area();
            var perimeter = figure.Perimeter();

            IFigure figureDrawer = new Graphics.Geometry.Rectangle();

            //BL can be further encapsulated in Graphics.App 'Core' section
            if((area <= MAX_AREA) && (perimeter <= MAX_PERIMETER))
            {
                figureDrawer.Draw(figure.p.X, figure.p.Y, figure.Length,figure.Width);
            }
            else
            {
                Console.WriteLine("Sorry, the figure is to large to be drawn on the canvas!");
            }

        }
    }
}
