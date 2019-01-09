using System;
using System.Text.RegularExpressions;

namespace Epam.Task07._5.TimeCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text", Environment.NewLine);
            string text = Console.ReadLine();
            Console.WriteLine("Time is mentioned {0} times", TimeCounter(text));
        }

        public static int TimeCounter(string text)
        {
            return Regex.Matches(text, @"\b([01]?[0-9]|2[0-4]):[0-5][0-9]\b").Count;
        }
    }
}
