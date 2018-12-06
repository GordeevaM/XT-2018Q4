using System;
using Epam.Task02._1.Round;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._6.Ring
{
    public class Ring
    {
        private Round inner;
        private Round outer;
        private double x;
        private double y;
        private double perimeter;
        private double area;

        public Ring(double innerR, double outerR)
        {
            if (innerR < outerR)
            {
                this.inner = new Round(innerR);
                this.outer = new Round(outerR);
                this.area = this.outer.Area - this.inner.Area;
            }
            else
            {
                throw new ArgumentException("Inner radius can not be more, than outer one");
            }
        }

        public Ring(double x, double y, double innerR, double outerR)
        {
            if (innerR < outerR)
            {
                this.x = x;
                this.y = y;
                this.inner = new Round(innerR);
                this.outer = new Round(outerR);
            }
            else
            {
                throw new ArgumentException("Inner radius can not be more, than outer one");
            }
        }

        public double Perimeter
        {
            get => this.perimeter = this.inner.Length + this.outer.Length;
        }

        public double Area
        {
            get => this.area = this.outer.Area - this.inner.Area;
        }

        public double X { get => this.x; set => this.x = value; }

        public double Y { get => this.y; set => this.y = value; }
    }
}