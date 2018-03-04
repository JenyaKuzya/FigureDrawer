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
        public int x3, y3;
        public Triangle(int n, int m, int z, int q, int x, int y, Pen pen) : base(z, q, x, y, pen)
        {
            x3 = n;
            y3 = m;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(mypen, x1, y1, x2, y2);
            g.DrawLine(mypen, x2, y2, x3, y3);
            g.DrawLine(mypen, x3, y3, x1, y1);
        }

    }
}
