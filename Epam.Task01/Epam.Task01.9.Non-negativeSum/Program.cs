using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._9.Non_negativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10, 10);
            }
            Console.WriteLine("Ваш массив:");
            ShowArray(arr);
            Console.WriteLine("Сумма неотрицательных элементов: {0}", PositiveSum(arr));
        }
        static void ShowArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.WriteLine();
        }
        static int PositiveSum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0) sum += a[i];
            }
            return sum;
        }
    }
}
