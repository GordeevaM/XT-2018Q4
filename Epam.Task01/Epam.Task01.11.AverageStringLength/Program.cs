using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._11.AverageStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            int numberOfWords = words.Count();
            int sum = 0;
            foreach (var word in words)
            {
                int letters = 0;
                char[] chars = word.ToCharArray();
                foreach (var ch in chars)
                {
                    if (Char.IsLetter(ch))
                    {
                        letters++;
                    }
                }
                if (letters == 0)
                {
                    numberOfWords--;
                }
                else sum += letters;
            }

            Console.WriteLine("Average number of letters - {0}", sum / numberOfWords);
        }
    }
}

