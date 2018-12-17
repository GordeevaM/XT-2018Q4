using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04._1.CustomSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sorting for string array");
            string[] strArr = new string[] { "bat", "cat", "act", "mat", "a", "b" };
            Console.WriteLine("Your array: ");
            foreach (var elem in strArr)
            {
                Console.Write(" {0}  ", elem);
            }

            string[] newStrArr = new string[strArr.Length];
            newStrArr = Sorting.Sort<string>(strArr, Sorting.CompareString);
            Console.WriteLine(Environment.NewLine + "Sorted array: ");
            foreach (var elem in strArr)
            {
                Console.Write(" {0}  ", elem);
            }

            Console.WriteLine(Environment.NewLine + "Sorting for int array");
            Console.WriteLine("Enter the length of your array: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n) && (n > 0)))
            {
                Console.WriteLine("Enter positive number");
            }

            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(100);
            }

            Console.WriteLine("Your array: ");
            foreach (var elem in arr)
            {
                Console.Write(" {0}  ", elem);
            }

            int[] newArr = new int[n];
            newArr = Sorting.Sort<int>(arr, Sorting.CompareInt);

            Console.WriteLine(Environment.NewLine + "Your sorted array: ");
            foreach (var elem in arr)
            {
                Console.Write(" {0}  ", elem);
            }

            Console.WriteLine();
        }
    }
}
