using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._2.Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter A");
            double a = 1;
            double b = 1;
            double c = 1;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Console.WriteLine("Please, enter B");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Console.WriteLine("Please, enter C");
            while ((!double.TryParse(Console.ReadLine(), out c)) || (c >= a + b))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Triangle triangle = new Triangle(a, b, c);
            Console.WriteLine("A = {0}, B = {1}, C = {2}, Perimeter = {3}, Area = {4}", triangle.A, triangle.B, triangle.C, triangle.Perimeter, triangle.Area);
        }
    }
}
