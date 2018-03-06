using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Square : Figure
    {
        protected int h;
        public Square(Point p1, int height, Pen pen) : base(p1, pen)
        {
            h = height;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(mypen, pt1.x, pt1.y, h, h);
        }
    }
}
