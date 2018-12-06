using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._7.VectorGraghicsEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the type of your figure:");
            Console.WriteLine("1 - line");
            Console.WriteLine("2 - circle");
            Console.WriteLine("3 - rectangle");
            Console.WriteLine("4 - round");
            Console.WriteLine("5 - ring");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 1) || (n > 5))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            switch (n)
            {
                case 1:
                    {
                        double x1;
                        double y1;
                        double x2;
                        double y2;
                        Console.WriteLine("Please, enter x1");
                        while (!double.TryParse(Console.ReadLine(), out x1))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter y1");
                        while (!double.TryParse(Console.ReadLine(), out y1))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter x2");
                        while (!double.TryParse(Console.ReadLine(), out x2))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter y2");
                        while (!double.TryParse(Console.ReadLine(), out y2))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Line line = new Line(x1, y1, x2, y2);
                        line.Show();
                        break;
                    }

                case 2:
                    {
                        double x;
                        double y;
                        double radius;
                        Console.WriteLine("Please, enter x");
                        while (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter y");
                        while (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter radius");
                        while ((!double.TryParse(Console.ReadLine(), out radius)) || (radius <= 0))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Circle circle = new Circle(x, y, radius);
                        circle.Show();
                        break;
                    }

                case 3:
                    {
                        double x;
                        double y;
                        double a;
                        double b;
                        Console.WriteLine("Please, enter x");
                        while (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter y");
                        while (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter a");
                        while ((!double.TryParse(Console.ReadLine(), out a)) || (a <= 0))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter b");
                        while ((!double.TryParse(Console.ReadLine(), out b)) || (b <= 0))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Rectangle rect = new Rectangle(x, y, a, b);
                        rect.Show();
                        break;
                    }

                case 4:
                    {
                        double x;
                        double y;
                        double radius;
                        Console.WriteLine("Please, enter x");
                        while (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter y");
                        while (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter radius");
                        while ((!double.TryParse(Console.ReadLine(), out radius)) || (radius <= 0))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Round round = new Round(x, y, radius);
                        round.Show();
                        break;
                    }

                case 5:
                    {
                        double x;
                        double y;
                        double innerR;
                        double outerR;
                        Console.WriteLine("Please, enter x");
                        while (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter y");
                        while (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter inner radius");
                        while ((!double.TryParse(Console.ReadLine(), out innerR)) || (innerR <= 0))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Console.WriteLine("Please, enter outer radius");
                        while ((!double.TryParse(Console.ReadLine(), out outerR)) || (outerR <= 0))
                        {
                            Console.WriteLine("You entered invalid value, please, try again");
                        }

                        Ring ring = new Ring(x, y, innerR, outerR);
                        ring.Show();
                        break;
                    }
            }
        }
    }
}
