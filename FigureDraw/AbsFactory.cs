using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw
{
    public abstract class AbsFactory
    {
        public abstract Figure CreateFig();
    }

    public class LineFactory : AbsFactory
    {
        public override Figure CreateFig()
        {
            return new Line();
        }
    }

    public class TriangleFactory : AbsFactory
    {
        public override Figure CreateFig()
        {
            return new Triangle();
        }
    }

    public class RectangleFactory : AbsFactory
    {
        public override Figure CreateFig()
        {
            return new Rectangle();
        }
    }

    public class SquareFactory : AbsFactory
    {
        public override Figure CreateFig()
        {
            return new Square();
        }
    }

    public class CircleFactory : AbsFactory
    {
        public override Figure CreateFig()
        {
            return new Circle();
        }
    }

    public class EllipseFactory : AbsFactory
    {
        public override Figure CreateFig()
        {
            return new Ellipse();
        }
    }
}
