using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._6.Ring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter inner radius");
            double innerR;
            double outerR;
            double x = 0;
            double y = 0;
            while (!double.TryParse(Console.ReadLine(), out innerR))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Console.WriteLine("Please, enter outer radius");
            while ((!double.TryParse(Console.ReadLine(), out outerR)) || (outerR <= innerR))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Console.WriteLine("Please, enter X");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Console.WriteLine("Please, enter Y");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Ring ring = new Ring(x, y, innerR, outerR);
            Console.WriteLine("Inner radius = {0}, outer radius = {1}, x = {2}, y = {3}, Area = {4}, Perimeter = {5}", innerR, outerR, ring.X, ring.Y, Math.Round(ring.Area, 2), Math.Round(ring.Perimeter, 2));
        }
    }
}
