using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number:");
            int n = int.Parse(Console.ReadLine());
            ShowNumbers(n);
        }
        static void ShowNumbers(int N)
        {
            for (int i = 1; i < N; i++)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine("{0}", N);
        }
    }
}
