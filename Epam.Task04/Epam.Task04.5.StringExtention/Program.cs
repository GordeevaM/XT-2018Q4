using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04._5.StringExtention
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();
            Console.WriteLine("You entered a positive integer - it is " + str.IsPositiveInt());
        }
    }
}
