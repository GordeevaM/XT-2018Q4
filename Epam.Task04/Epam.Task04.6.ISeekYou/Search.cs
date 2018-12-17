using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04._6.ISeekYou
{
    public static class Search
    {
        public static bool PositiveElements(int a)
        {
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int[] SearchPositiveElements(this int[] arr)
        {
            List<int> positiveElems = new List<int>();
            foreach (var elem in arr)
            {
                if (elem > 0)
                {
                    positiveElems.Add(elem);
                }
            }

            return positiveElems.ToArray();
        }

        public static int[] SearchWithDelegate(this int[] arr, Predicate<int> PositiveElements)
        {
            List<int> positiveElems = new List<int>();
            foreach (var elem in arr)
            {
                if (PositiveElements(elem))
                {
                    positiveElems.Add(elem);
                }
            }

            return positiveElems.ToArray();
        }
       
        public static int[] SearchWithLINQ(this int[] arr)
        {
            var query = from item in arr
                        where item > 0
                        select item;
            return query.ToArray();
        }
    }
}
