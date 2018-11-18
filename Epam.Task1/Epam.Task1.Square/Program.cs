using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное нечётное число");
            int n = Convert.ToInt32(Console.ReadLine());
            DrawSquare(n);
        }
        public static void DrawSquare(int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i==j)&&(i==N/2))
                    {
                        Console.Write(" ");
                    }
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
