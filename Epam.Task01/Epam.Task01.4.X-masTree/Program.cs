using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._4.X_masTree
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTree();
        }
        static void DrawTree()
        {
            Console.WriteLine("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a = 0; a < n; a++)
            {
                int spaces = n - 1;
                for (int i = 1; i < a + 1; i++)
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
}
