using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._3.AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle();
        }
        static void DrawTriangle()
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int spaces = n - 1;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                if (i == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    for (int j = 1; j < 2 * i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                spaces--;
            }
        }
    }
}
