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
        public int h;
        public Square(int x, int y, int height, Pen pen) : base(x, y, pen)
        {
            h = height;
        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(mypen, x1, y1, h, h);
        }
    }
}
