using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._1.Round
{
    public class Round
    {
        private double r; 
        private double x;
        private double y;
        private double length;
        private double area;

        public Round()
        {
            this.X = this.Y = 0;
            this.Radius = 1;
            this.length = 2 * Math.PI * this.Radius;
            this.area = Math.PI * this.r * this.r;
        }

        public Round(double radius) : this()
        {
            this.Radius = radius;
            this.length = 2 * Math.PI * this.Radius;
            this.area = Math.PI * this.r * this.Radius;
        }

        public Round(double x, double y, double radius) : this()
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
            this.length = 2 * Math.PI * this.r;
            this.area = Math.PI * this.r * this.r;
        }

        public double Radius
        {
            get => this.r;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius should be positive", nameof(value));
                }

                this.r = value;
            }
        }

        public double X
        {
            get => this.x;
            set => this.x = value;
        }

        public double Y
        {
            get => this.y;
            set => this.y = value;
        }

        public double Length { get => this.length; }

        public double Area { get => this.area; }
    }
}
