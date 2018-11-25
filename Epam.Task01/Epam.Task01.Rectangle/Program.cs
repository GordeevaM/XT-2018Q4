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
                Console.WriteLine("Введите сторону A: ");
                if (!Int32.TryParse(Console.ReadLine(), out int a)) Console.WriteLine("Некорректное значение. Введите число.");
                else if (a < 1) Console.WriteLine("Некорректное значение. Введите положительное число");
                else
                {
                    Console.WriteLine("Введите сторону B: ");
                    if (!Int32.TryParse(Console.ReadLine(), out int b)) Console.WriteLine("Некорректное значение. Введите число.");
                    else if (b < 1) Console.WriteLine("Некорректное значение. Введите положительное число");
                    else
                    {
                        correctInput = true;
                        Console.WriteLine("Площадь прямоугольника - {0}", Area(a, b));
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

