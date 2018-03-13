using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public abstract class Figure
    {
        protected Point pt1;
        protected Pen mypen;
        public Figure(Point p1, Pen pen)
        {
            pt1 = p1;
            mypen = pen;
        }
        public abstract void Draw(Graphics g);
    }
}
