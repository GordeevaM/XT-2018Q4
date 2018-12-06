using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._2.Triangle
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;
        private double perimeter;
        private double area;

        public Triangle()
        {
            this.A = this.B = this.C = 1;
            this.perimeter = this.A + this.B + this.C;
            double halfPerimeter = this.perimeter / 2;
            this.area = Math.Sqrt(halfPerimeter * (halfPerimeter - this.A) * (halfPerimeter - this.B) * (halfPerimeter - this.C));
        }

        public Triangle(double a, double b, double c) 
            : this()
        {
            if (((a + b) > c) && ((a + c) > b) && ((b + c) > a) && (a > 0) && (b > 0) && (c > 0))
            {
                this.A = a;
                this.B = b;
                this.C = c;
                this.perimeter = a + b + c;
                double halfPerimeter = this.perimeter / 2;
                this.area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            }
            else
            {
                throw new ArgumentException("Wrong triangle sides", "a, b, c");
            }
        }

        public double A
        {
            get => this.a;
            set
            {
                if (this.a > 0)
                {
                    this.a = value;
                }
                else
                {
                    throw new ArgumentException("A triangle side should be a positive number", nameof(value));
                }
            }
        }

        public double B
        {
            get => this.b;
            set
            {
                if (this.b > 0)
                {
                    this.b = value;
                }
                else
                {
                    throw new ArgumentException("A triangle side should be a positive number", nameof(value));
                }
            }
        }

        public double C
        {
            get => this.c;
            set
            {
                if (this.c > 0)
                {
                    this.c = value;
                }
                else
                {
                    throw new ArgumentException("A triangle side should be a positive number", nameof(value));
                }
            }
        }

        public double Perimeter { get => this.perimeter; }

        public double Area { get => this.area; }
    }
}
