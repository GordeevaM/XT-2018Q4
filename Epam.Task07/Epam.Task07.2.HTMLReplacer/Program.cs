using System;
using System.Text.RegularExpressions;

namespace Epam.Task07._2.HTMLReplacer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text", Environment.NewLine);
            string text = Console.ReadLine();
            Console.WriteLine("Your text without tags: ");
            Console.WriteLine(ReplaceTags(text));
        }

        public static string ReplaceTags(string text)
        {
            string regExp = @"<.+?>";
            return Regex.Replace(text, regExp, "_");
        }
    }
}
