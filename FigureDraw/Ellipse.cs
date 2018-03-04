using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Ellipse : Rectangle
    {
        public Ellipse(int x, int y, int z, int q, Pen pen)
            : base(x, y, z, q, pen)
        { }
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(mypen, x1, y1, w, h);
        }
    }
}
