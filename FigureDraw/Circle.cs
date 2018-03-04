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
        public Circle(int x, int y, int height, Pen pen)
            : base(height, x, y, pen)
        {
        }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(mypen, x1, y1, h, h);
        }
    }
}
