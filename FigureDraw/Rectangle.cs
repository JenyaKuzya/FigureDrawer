using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Rectangle : Square
    {
        protected int w;
        public Rectangle(Point p1, int width, int height, Pen pen)
            : base(p1, height, pen)
        {
            w = width;

        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(mypen, pt1.x, pt1.y, w, h);
        }
    }
}
