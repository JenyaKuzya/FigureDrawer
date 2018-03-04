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
        public int x2, y2;
        public Line(int z, int q, int x, int y, Pen pen) : base(x, y, pen)
        {
            x2 = z;
            y2 = q;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(mypen, x1, y1, x2, y2);
        }
    }
}
