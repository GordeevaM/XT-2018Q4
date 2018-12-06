using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._7.VectorGraghicsEditor
{
    public class Round : Circle
    {
        private double area;

        public Round(double x, double y, double r) : base(x, y, r)
        {
            this.area = Math.PI * r * r;
        }

        public double Area
        {
            get => this.area;
            set
            {
                this.area = Math.PI * this.R * this.R;
            }
        }

        public override void Show()
        {
            Console.WriteLine("Round: x = {0}, y = {1}, radius = {2}, area = {3}, length = {4}", this.X, this.Y, this.R, Math.Round(this.Area, 2), Math.Round(this.Length, 2));
        }
    }
}
