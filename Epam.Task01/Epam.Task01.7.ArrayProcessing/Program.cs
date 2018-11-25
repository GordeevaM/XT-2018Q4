using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._7.ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(100);
            }
            Console.WriteLine("Ваш массив:");
            ShowArray(arr);
            Console.WriteLine("Максимальный элемент: {0}", FindMax(arr));
            Console.WriteLine("Минимальный элемент: {0}", FindMin(arr));
            Console.WriteLine("Отсортированный массив: ");
            SortArray(arr);
            ShowArray(arr);
        }
        static int FindMax(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i]) max = a[i];
            }
            return max;
        }
        static int[] SortArray(int[] a)
        {
            int tmp;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        tmp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = tmp;
                    }
                }
            }
            return a;
        }
        static int FindMin(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i]) min = a[i];
            }
            return min;
        }
        static void ShowArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.WriteLine();
        }
    }
}
