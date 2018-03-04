using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureDraw
{
    public partial class FigureDrawer : Form
    {
        public Graphics g;
        public PictureBox pb;
        public List<Figure> figures = new List<Figure>();
        public Figure fig;
        Pen pen;
        public FigureDrawer()
        {
            InitializeComponent();
            pb = pictureBox1;
        }

        private void BLine_Click(object sender, EventArgs e)
        {
            g = pb.CreateGraphics();
            pen = new Pen(Color.Black, 4);
            fig = new Line(100, 200, 300, 250, pen);
            fig.Draw(g);
            figures.Add(fig);
            pen.Dispose();
            g.Dispose();
        }

        private void BTriangle_Click(object sender, EventArgs e)
        {
            g = pb.CreateGraphics();
            pen = new Pen(Color.Green, 4);
            fig = new Triangle(200, 70, 340, 200, 100, 230, pen);
            fig.Draw(g);
            figures.Add(fig);
            pen.Dispose();
            g.Dispose();
        }

        private void BSquare_Click(object sender, EventArgs e)
        {
            g = pb.CreateGraphics();
            pen = new Pen(Color.Red, 4);
            fig = new Square(220, 300, 80, pen);
            fig.Draw(g);
            figures.Add(fig);
            pen.Dispose();
            g.Dispose();
        }

        private void BRectangle_Click(object sender, EventArgs e)
        {
            g = pb.CreateGraphics();
            pen = new Pen(Color.Black, 3);
            fig = new Rectangle(120, 100, 30, 30, pen);
            fig.Draw(g);
            figures.Add(fig);
            pen.Dispose();
            g.Dispose();
        }

        private void BCircle_Click(object sender, EventArgs e)
        {
            g = pb.CreateGraphics();
            pen = new Pen(Color.Brown, 4);
            fig = new Circle(200, 50, 60, pen);
            fig.Draw(g);
            figures.Add(fig);
            pen.Dispose();
            g.Dispose();
        }

        private void BEllipse_Click(object sender, EventArgs e)
        {
            g = pb.CreateGraphics();
            pen = new Pen(Color.Blue, 5);
            fig = new Ellipse(250, 80, 50, 200, pen);
            fig.Draw(g);
            figures.Add(fig);
            pen.Dispose();
            g.Dispose();
        }
    }
}
