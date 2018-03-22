using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    public class Point
    {
        private int x, y;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public Point(int x1, int y1)
        {
            x = x1;
            y = y1;
        }
    }
}
