using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._7.VectorGraghicsEditor
{
    public class Line : Figure
    {
        private double x;
        private double y;

        private double x1;
        private double y1;

        public Line(double x, double y, double x1, double y1)
        {
            this.x = x;
            this.y = y;
            this.x1 = x1;
            this.y1 = y1;
        }

        public override double X { get => this.x; set => this.x = value; }

        public override double Y { get => this.y; set => this.y = value; }

        public double X1 { get => this.x1; set => this.x1 = value; }

        public double Y1 { get => this.y1; set => this.y1 = value; }

        public override void Show()
        {
            Console.WriteLine("Line: x1 = {0}, y1 = {1}, x2 = {2}, y2 = {3}", this.X, this.Y, this.X1, this.Y1); 
        }
    }
}
