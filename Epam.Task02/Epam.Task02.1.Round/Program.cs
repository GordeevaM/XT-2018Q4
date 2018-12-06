using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._1.Round
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter R");
            double r = 1;
            double x = 0;
            double y = 0;
            while (!double.TryParse(Console.ReadLine(), out r))
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

            Round round = new Round(x, y, r);
            Console.WriteLine("Radius = {0}, x = {1}, y = {2}, Length = {3}, Area = {4}", round.Radius, round.X, round.Y, Math.Round(round.Length, 2), Math.Round(round.Area, 2));
        }
    }
}
