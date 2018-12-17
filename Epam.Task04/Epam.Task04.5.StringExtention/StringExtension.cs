using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04._5.StringExtention
{
    public static class StringExtension
    {
        public static bool IsPositiveInt(this string str)
        {
            char[] charArr = str.ToCharArray();
            foreach (var letter in charArr)
            {
                if (!char.IsDigit(letter) || (letter == 'e') || (letter == 'E'))
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}
