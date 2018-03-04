using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FigureDraw
{
    public class Figure
    {
        public int x1, y1;
        public Pen mypen;
        public Figure(int x, int y, Pen pen)
        {
            x1 = x;
            y1 = y;
            mypen = pen;
        }
        public virtual void Draw(Graphics g) { }
    }
}
