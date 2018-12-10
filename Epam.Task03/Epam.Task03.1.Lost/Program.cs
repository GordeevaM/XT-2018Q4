using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03._1.Lost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n;
            while (!(int.TryParse(Console.ReadLine(), out n)))
            {
                Console.WriteLine("Invalid number; try again");
            }

            Round round = new Round(n);

            Console.WriteLine("Only the person number {0} has left", round.ShowLastPerson());
        }
    }
}
