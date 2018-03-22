using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Square : Rectangle
    {
        public Square(Point p1, int height, Pen pen) : base(p1, height, height, pen)
        {
        }
        public Square(Point p1, Point p2, Pen pen) : base(p1, p2, pen)
        {
            w = h;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(mypen, pt1.X, pt1.Y, h, h);
        }
    }
}
