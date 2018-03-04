using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Rectangle : Square
    {
        public int w;
        public Rectangle(int x, int y, int width, int height, Pen pen)
            : base(height, x, y, pen)
        {
            w = width;

        }
        public override void Draw(Graphics g)
        {
            g.DrawRectangle(mypen, x1, y1, w, h);
        }
    }
}
