using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.CheckSimplicity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number:");
            int n = int.Parse(Console.ReadLine());
            if (IfSimple(n))
            {
                Console.WriteLine("{0} is a prime number", n);
            }
            else Console.WriteLine("{0} is NOT a prime number", n);
        }
        public static bool IfSimple(int N)
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
