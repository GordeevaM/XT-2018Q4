using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task04._6.ISeekYou
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-10, 10);
            }

            Console.WriteLine("Your array: ");
            foreach (var elem in arr)
            {
                Console.Write(" {0}  ", elem);
            }

            int[] newArr = new int[10];

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            newArr = Search.SearchPositiveElements(arr);

            Console.WriteLine(Environment.NewLine + "Poritive numbers (SimpleSearch): ");
            foreach (var elem in newArr)
            {
                Console.Write(" {0}  ", elem);
            }

            Console.WriteLine();
            stopWatch.Stop();

            Console.WriteLine("Time:" + stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            newArr = Search.SearchWithDelegate(arr, Search.PositiveElements);

            Console.WriteLine(Environment.NewLine + "Poritive numbers (SearchWithDelegate): ");
            foreach (var elem in newArr)
            {
                Console.Write(" {0}  ", elem);
            }

            Console.WriteLine();
            stopWatch.Stop();

            Console.WriteLine("Time:" + stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            newArr = Search.SearchWithLINQ(arr);

            Console.WriteLine(Environment.NewLine + "Poritive numbers (SearchWithLINQ): ");
            foreach (var elem in newArr)
            {
                Console.Write(" {0}  ", elem);
            }

            Console.WriteLine();
            stopWatch.Stop();

            Console.WriteLine("Time:" + stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            newArr = AnonFunction.SearchWithLambda(arr, AnonFunction.positiveElementsLambda);

            Console.WriteLine(Environment.NewLine + "Poritive numbers (SearchWithLambda): ");
            foreach (var elem in newArr)
            {
                Console.Write(" {0}  ", elem);
            }

            Console.WriteLine();
            stopWatch.Stop();

            Console.WriteLine("Time:" + stopWatch.Elapsed);
            stopWatch.Reset();

            stopWatch.Start();
            newArr = AnonFunction.SearchWithAnonMethod(arr, AnonFunction.PositiveElements);

            Console.WriteLine(Environment.NewLine + "Poritive numbers (SearchWithAnonMethod): ");
            foreach (var elem in newArr)
            {
                Console.Write(" {0}  ", elem);
            }

            Console.WriteLine();
            stopWatch.Stop();

            Console.WriteLine("Time:" + stopWatch.Elapsed);
            stopWatch.Reset();
        }
    }
}
