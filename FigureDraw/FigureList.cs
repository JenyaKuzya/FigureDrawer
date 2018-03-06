using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FigureDraw
{
    public class FigureList
    {
        private List<Figure> figures = new List<Figure>();
        public void add(Figure f)
        {
            figures.Add(f);
        }
        public void draw(PictureBox pb)
        {
            Graphics g;
            foreach (Figure f in figures)
            {
                g = pb.CreateGraphics();
                f.Draw(g);
                g.Dispose();
            }
        }
    }
}
