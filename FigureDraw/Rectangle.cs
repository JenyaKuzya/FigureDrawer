﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Rectangle : Figure
    {
        protected int w;
        protected int h;
        public Rectangle(Point p1, int width, int height, Pen pen)
            : base(p1, pen)
        {
            w = width;
            h = height;
        }
        public Rectangle(Point p1, Point p2, Pen pen) : base(p1, pen)
        {
            h = Math.Abs(p1.Y - p2.Y);
            w = Math.Abs(p1.X - p2.X);
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(mypen, pt1.X, pt1.Y, w, h);
        }
    }
}
