using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Graphics.Geometry
{
    public interface IFigure
    {
        void Draw(int x, int y, params int[] paramList);
    }
}
