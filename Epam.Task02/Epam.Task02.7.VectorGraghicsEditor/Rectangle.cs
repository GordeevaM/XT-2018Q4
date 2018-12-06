using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._7.VectorGraghicsEditor
{
    public class Rectangle : Figure
    {
        private double x;
        private double y;
        private double a;
        private double b;
        private double area;
        private double perimeter;

        public Rectangle(double x, double y, double a, double b)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            this.b = b;
            this.perimeter = (a + b) * 2;
            this.area = a * b;
        }

        public double Area
        {
            get => this.area;
            set
            {
                this.area = this.a * this.b;
            }
        }

        public double Perimeter
        {
            get => this.perimeter;
            set
            {
                this.perimeter = (this.a + this.b) * 2;
            }
        }

        public override double X { get => this.x; set => this.x = value; }

        public override double Y { get => this.y; set => this.y = value; }

        public double A
        {
            get => this.a;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rectangle side should be a positive numner");
                }
                else
                {
                    this.a = value;
                }
            }
        }

        public double B
        {
            get => this.b;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rectangle side should be a positive numner");
                }
                else
                {
                    this.b = value;
                }
            }
        }

        public override void Show()
        {
            Console.WriteLine("Line: x1 = {0}, y1 = {1}, a = {2}, b = {3}, perimeter = {4}, area = {5}", this.X, this.Y, this.A, this.B, Math.Round(this.Perimeter, 2), Math.Round(this.Area, 2));
        }
    }
}
