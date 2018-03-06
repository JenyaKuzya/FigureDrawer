using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace FigureDraw
{
    public class Triangle : Line
    {
        protected Point pt3;
        public Triangle(Point p1, Point p2, Point p3, Pen pen) : base(p1, p2, pen)
        {
            pt3 = p3;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(mypen, pt1.x, pt1.y, pt2.x, pt2.y);
            g.DrawLine(mypen, pt2.x, pt2.y, pt3.x, pt3.y);
            g.DrawLine(mypen, pt3.x, pt3.y, pt1.x, pt1.y);
        }

    }
}
