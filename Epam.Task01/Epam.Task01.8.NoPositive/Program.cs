using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._8.NoPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 3, 4];
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int m = 0; m < arr.GetLength(2); m++)
                    {
                        arr[i, j, m] = r.Next(-100, 100);
                    }
                }
            }
            Console.WriteLine("Исходный массив:");
            ShowArray(arr);
            NoPositive(arr);
            Console.WriteLine("Массив без положительных чисел:");
            ShowArray(arr);
        }
        static void ShowArray(int[,,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int m = 0; m < a.GetLength(2); m++)
                    {
                        Console.Write("{0}  \t ", a[i, j, m]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
        static int[,,] NoPositive(int[,,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int m = 0; m < a.GetLength(2); m++)
                    {
                        if (a[i, j, m] > 0)
                        {
                            a[i, j, m] = 0;
                        }
                    }
                }
            }
            return a;
        }
    }
}
