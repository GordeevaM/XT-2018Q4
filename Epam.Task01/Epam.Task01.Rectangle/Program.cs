using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._1.Rectangle

{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctInput = false;
            while (!correctInput)
            {
                Console.WriteLine("Enter A: ");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Invalid value. Enter a number.");
                }
                else if (a < 1)
                {
                    Console.WriteLine("Invalid value. Enter a positive number");
                }
                else
                {
                    Console.WriteLine("Enter B: ");
                    if (!Int32.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.WriteLine("Invalid value. Enter a number.");
                    }
                    else if (b < 1)
                    {
                        Console.WriteLine("Invalid value. Enter a positive number");
                    }
                    else
                    {
                        correctInput = true;
                        Console.WriteLine("Area = {0}", Area(a, b));
                    }
                }
            }
        }
        static int Area(int m, int n)
        {
            return m * n;
        }
    }
}

