using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._7.VectorGraghicsEditor
{
    public abstract class Figure
    {
        public abstract double X { get; set; }

        public abstract double Y { get; set; }

        public abstract void Show();
    }
}
