using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task04._3.SortingModule
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortingUnit<string> sortingModule = new SortingUnit<string>();
            string[] arr = new string[] { "bat", "cat", "act", "mat", "a", "b" };
            Console.WriteLine(Environment.NewLine + "Your array: ");
            foreach (var elem in arr)
            {
                Console.Write(" {0}  ", elem);
            }

            string[] newArr = new string[arr.Length];
            newArr = SortingUnit<string>.RunInNewThread(arr, SortingUnit<string>.CompareString);
            Console.WriteLine(Environment.NewLine + "Your array: ");
            foreach (var elem in newArr)
            {
                Console.Write(" {0}  ", elem);
            }

            Console.WriteLine();
        }
    }
}
