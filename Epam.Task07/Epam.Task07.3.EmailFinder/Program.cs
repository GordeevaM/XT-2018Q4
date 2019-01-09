using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Epam.Task07._3.EmailFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text", Environment.NewLine);
            string text = Console.ReadLine();
            Console.WriteLine("Emails from your text: ");
            if (FindEmail(text).Count == 0)
            {
                Console.WriteLine("Your text does not contain emails");
            }
            else
            {
                foreach (var email in FindEmail(text))
                {
                    Console.WriteLine(email);
                }
            }
        }

        public static List<string> FindEmail(string text)
        {
            List<string> emails = new List<string>();
            string regExp = @"\b[A-Za-z0-9][A-Za-z0-9._-]+@[A-Za-z0-9.-]+(\.[A-Za-z]{2,})+\b";
            foreach (Match match in Regex.Matches(text, regExp))
            {
                emails.Add(match.ToString());
            }

            return emails;
        }
    }
}
