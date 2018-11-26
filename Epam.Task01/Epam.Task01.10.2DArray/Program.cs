using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._10._2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(-10, 10);
                }
            }
            Console.WriteLine("Your array:");
            ShowArray(arr);
            Console.WriteLine("Sum of the even elements: {0}", SumEvenElems(arr));
        }
        static void ShowArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0}  \t ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static int SumEvenElems(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
