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
        protected Point pt1, pt2;
        protected Pen mypen;

        public Point Pt1
        {
            set { pt1 = value; }
        }

        public Point Pt2
        {
            set { pt2 = value; }
        }

        public Pen Mypen
        {
            set { mypen = value; }
        }

        public Figure()
        {
            pt1 = new Point(0, 0);
            pt2 = new Point(0, 0);
            mypen = new Pen(Color.Black, 3);
        }

        public Figure(Point p1, Point p2, Pen pen)
        {
            pt1 = p1;
            pt2 = p2;
            mypen = pen;
        }

        public abstract void Draw(Graphics g);
    }
}
