using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Circle : Square
    {
        public Circle(Point p1, int height, Pen pen)
            : base(p1, height, pen)
        {
        }
        public Circle(Point p1, Point p2, Pen pen) : base(p1, p2, pen)
        {
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(mypen, pt1.x, pt1.y, h, h);
        }
    }
}
