using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._7.VectorGraghicsEditor
{
    public class Circle : Figure
    {
        private double r;
        private double x;
        private double y;
        private double length;

        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.length = 2 * Math.PI * r;
        }

        public override double X { get => this.x; set => this.x = value; }

        public override double Y { get => this.y; set => this.y = value; }

        public double R
        {
            get => this.r;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius should be a positive numner");
                }
                else
                {
                    this.r = value;
                }
            }
        }

        public double Length
        {
            get => this.length;
            set
            {
                this.length = 2 * Math.PI * this.r;
            }
        }

        public override void Show()
        {
            Console.WriteLine("Circle: Radius = {0}, x = {1}, y = {2}, length = {3}", this.R, this.X, this.Y, this.Length);
        }
    }
}
