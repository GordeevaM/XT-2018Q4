using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._7.VectorGraghicsEditor
{
    public class Ring : Figure
    {
        private Round inner;
        private Round outer;
        private double x;
        private double y;
        private double perimeter;
        private double area;

        public Ring(double x, double y, double innerR, double outerR)
        {
            if (innerR < outerR)
            {
                this.x = x;
                this.y = y;
                this.inner = new Round(0, 0, innerR);
                this.outer = new Round(0, 0, outerR);
            }
            else
            {
                throw new ArgumentException("Inner radius can not be more, than outer one");
            }
        }
        
        public override double X { get => this.x; set => this.x = value; }

        public override double Y { get => this.y; set => this.y = value; }

        public double Perimeter
        {
            get => this.perimeter = this.inner.Length + this.outer.Length;
        }

        public double Area
        {
            get => this.area = this.outer.Area - this.inner.Area;
        }

        public override void Show()
        {
            Console.WriteLine("Ring: x = {0}, y = {1}, inner radius = {2}, outer radius = {3}, area = {4}, length = {5}", this.X, this.Y, this.inner.R, this.outer.R, Math.Round(this.Area, 2), Math.Round(this.Perimeter, 2));
        }
    }
}
