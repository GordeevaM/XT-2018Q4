using System;
using System.Text.RegularExpressions;

namespace Epam.Task07._4.NumberValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number", Environment.NewLine);
            string n = Console.ReadLine();
            switch (NumberFormat(n))
            {
                case 0: Console.WriteLine("This is not a number");
                    break;
                case 1:
                    Console.WriteLine("This is a normal number");
                    break;
                case 2:
                    Console.WriteLine("This is a number in scientific format");
                    break;
            }
        }

        public static int NumberFormat(string text)
        {
            if (Regex.IsMatch(text, @"^-?\d+([,.]\d*)?$"))
            {
                return 1;
            }
            else if (Regex.IsMatch(text, @"^-?\d+([.,]?[\d*]+)?e?-?(\d+)?$"))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
