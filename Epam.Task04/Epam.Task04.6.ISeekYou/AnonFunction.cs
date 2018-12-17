using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task04._6.ISeekYou
{
    public class AnonFunction
    {
        public static Predicate<int> PositiveElements = delegate(int x) 
        {
            return (x > 0) ? true : false;
        };

        public static Predicate<int> positiveElementsLambda = (int x) => { return (x > 0) ? true : false; };

        public static int[] SearchWithAnonMethod(int[] arr, Predicate<int> PositiveElements)
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

        public static int[] SearchWithLambda(int[] arr, Predicate<int> positiveElementsLambda)
        {
            List<int> positiveElems = new List<int>();
            foreach (var elem in arr)
            {
                if (positiveElementsLambda(elem))
                {
                    positiveElems.Add(elem);
                }
            }

            return positiveElems.ToArray();
        }
    }
}
