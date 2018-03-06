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
            g.DrawLine(mypen, pt1.x, pt1.y, pt2.x, pt2.y);
        }
    }
}
