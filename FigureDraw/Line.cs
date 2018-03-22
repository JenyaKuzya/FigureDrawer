using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Line : Figure
    {
        protected Point pt2;
        public Line(Point p1, Point p2, Pen pen) : base(p1, pen)
        {
            pt2 = p2;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(mypen, pt1.X, pt1.Y, pt2.X, pt2.Y);
        }
    }
}
