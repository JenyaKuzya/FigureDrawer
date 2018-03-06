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
        public FigureList figures = new FigureList();
        public FigureDrawer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            figures.add(new Line(new Point(100, 100), new Point(200, 300), new Pen(Color.Black, 3)));
            figures.add(new Triangle(new Point(400, 150), new Point(450, 150), new Point(400, 200), new Pen(Color.Red, 3)));
            figures.add(new Square(new Point(400, 200), 100, new Pen(Color.Green, 3)));
            figures.add(new Rectangle(new Point(200, 300), 200, 100, new Pen(Color.Purple, 3)));
            figures.add(new Circle(new Point(470, 220), 20, new Pen(Color.Black, 3)));
            figures.add(new Ellipse(new Point(100, 50), 300, 100, new Pen(Color.Black, 3)));
            figures.draw(pictureBox1);
        }
    }
}
