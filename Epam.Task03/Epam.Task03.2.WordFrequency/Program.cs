using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03._2.WordFrequency
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text ");
            string text = Console.ReadLine();
            foreach (var elem in CountFrequency(text))
            {
                Console.WriteLine(elem);
            }
        }

        public static Dictionary<string, int> CountFrequency(string txt)
        {
            Dictionary<string, int> frequency = new Dictionary<string, int>();
            string[] words = txt.Split('.', ' ');
            foreach (var word in words)
            {
                int count = 1;
                count = words.Count(w => (string.Compare(w, word, true)) == 0);
                if (!frequency.ContainsKey(word.ToLower()))
                {
                    frequency.Add(word.ToLower(), count);
                }
            }

            return frequency;
        }
    }
}
