using System;
using System.Text.RegularExpressions;

namespace Epam.Task07._1.DateExistance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text with dates in dd-mm-yyyy format: ", Environment.NewLine);
            string text = Console.ReadLine();
            string output = FindDate(text) ? "Your text contains dates in dd-mm-yyyy format" : "Your text does not contain dates in dd-mm-yyyy format";
            Console.WriteLine(output);
        }

        public static bool FindDate(string text)
        {
            string regExp = @"0[1-9]|[12][0-9]|3[01]-0[1-9]|1[0-2]-[012][0-9]{3}";
            return Regex.IsMatch(text, regExp);
        }
    }
}
