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
            Console.WriteLine("Введите положительное число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetNumbers(n));
        }
        static string GetNumbers(int N)
        {
            List<string> nums = new List<string>();
            for (int i = 1; i < N; i++)
            {
                nums.Add(Convert.ToString(i)+", ");
            }
            nums.Add(N.ToString());
            return String.Concat(nums);
        }

    }
}
