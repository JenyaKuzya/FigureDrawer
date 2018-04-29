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
        Dictionary<string, AbsFactory> figures = new Dictionary<string, AbsFactory>();
        Figure figure;
        FigureList figList = new FigureList();
        Pen pen = new Pen(Color.Black, 3);
        bool isDrawing = false;
        Point pos1, pos2, pos3;
        Button curButton;
        Color curColor = Color.Black;
        Bitmap bmp;

        public FigureDrawer()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            curButton = BLine;
            figures.Add("BLine", new LineFactory());
            figures.Add("BTriangle", new TriangleFactory());
            figures.Add("BRectangle", new RectangleFactory());
            figures.Add("BSquare", new SquareFactory());
            figures.Add("BCircle", new CircleFactory());
            figures.Add("BEllipse", new EllipseFactory());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (isDrawing)
            {
                if (curButton.Name != "BTriangle") // it's not triangle
                {
                    pos2 = new Point(me.Location.X, me.Location.Y);
                    figure.Pt2 = pos2;                  
                    drawFigure();
                    isDrawing = false;
                }
                else
                {
                    if (pos2 != null)
                    {
                        pos3 = new Point(me.Location.X, me.Location.Y);
                        ((Triangle)figure).Pt3 = pos3;
                        drawFigure();
                        isDrawing = false;
                    }
                    else
                    {
                        pos2 = new Point(me.Location.X, me.Location.Y);
                        figure.Pt2 = pos2;
                    }
                }
            }
            else
            {
                figure = (figures[curButton.Name]).CreateFig();
                pos1 = new Point(me.Location.X, me.Location.Y);
                figure.Pt1 = pos1;
                isDrawing = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            pictureBox1.Refresh();
            figList.deleteAll();
            comboBox.Items.Clear();
        }

        private void BLine_Click(object sender, EventArgs e)
        {
            if (curButton != null)
            {
                curButton.BackColor = SystemColors.Control;
            }
            ((Button)sender).BackColor = Color.Tomato;
            curButton = (Button)sender;           
        }

        private void BColor_Click(object sender, EventArgs e)
        {
            if (cdDraw.ShowDialog() == DialogResult.Cancel)
                return;
            curColor = cdDraw.Color;
            pen.Color = curColor;
        }

        public void drawFigure()
        {            
            pen.Width = (float)numericUpDown.Value;
            figure.Mypen = pen;
            figList.add(figure);
            Graphics gr = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            figure.Draw(gr);
            pictureBox1.Refresh();
            comboBox.Items.Add(figure);
            pos1 = pos2 = pos3 = null;
        }
    }
}
