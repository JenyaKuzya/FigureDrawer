﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Ellipse : Rectangle
    {
        public Ellipse() : base()
        {
        }

        public Ellipse(Point p1, Point p2, Pen pen) : base(p1, p2, pen)
        {
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(mypen, Math.Min(pt1.X, pt2.X), Math.Min(pt1.Y, pt2.Y), Math.Abs(pt1.X - pt2.X), Math.Abs(pt1.Y - pt2.Y));
        }
    }
}
