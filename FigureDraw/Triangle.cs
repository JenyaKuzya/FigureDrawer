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

        public Point Pt3
        {
            set { pt3 = value; }
        }

        public Triangle() : base()
        {
            pt3 = new Point(0, 0);
        }

        public Triangle(Point p1, Point p2, Point p3, Pen pen) : base(p1, p2, pen)
        {
            pt3 = p3;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(mypen, pt1.X, pt1.Y, pt2.X, pt2.Y);
            g.DrawLine(mypen, pt2.X, pt2.Y, pt3.X, pt3.Y);
            g.DrawLine(mypen, pt3.X, pt3.Y, pt1.X, pt1.Y);
        }

    }
}
