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
            Console.WriteLine("Введите положительное число");
            int n = Convert.ToInt32(Console.ReadLine());
            if (IfSimple(n))
            {
                Console.WriteLine("Число {0} является простым", n);
            }
            else Console.WriteLine("Число {0} не является простым", n);
        }
        public static bool IfSimple(int N)
        {
            for (int i = 2; i < N; i++)
            {
                if (N%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
