using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._5.SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum = {0}", SumOfNums());
        }
        static int SumOfNums()
        {
            int sum = 0;
            for (int i = 3; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
