using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._12.CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter your second string: ");
            string str2 = Console.ReadLine();
            char[] chars1 = str1.ToCharArray();
            char[] newString = new char[str1.Length * 2];
            int j = 0;
            for (int i = 0; i < chars1.Length; i++)
            {
                newString[j] = chars1[i];
                j++;
                if (str2.Contains(chars1[i]))
                {
                    newString[j] = chars1[i];
                    j++;
                }
            }
            Console.WriteLine(newString);
        }
    }
}
