using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03._3.DynamicArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>();
            arr.Add(6);

            Console.WriteLine(arr);
        }
    }
}
