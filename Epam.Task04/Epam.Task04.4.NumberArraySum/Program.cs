using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04._4.NumberArraySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
                arr[i] = r.Next(10);
            }

            Console.WriteLine("Your array: ");
            foreach (var elem in arr)
            {
                Console.Write(" {0}  ", elem);
            }

            int sum = arr.Sum();
            Console.WriteLine(Environment.NewLine + "Sum of the elements: " + sum);
            Console.WriteLine();
        }
    }
}
