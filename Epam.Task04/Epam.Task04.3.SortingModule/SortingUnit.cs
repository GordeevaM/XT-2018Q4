using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task04._3.SortingModule
{
    public class SortingUnit<T>
    {
        public static event EventHandler SortingFinished;

        public static int CompareInt(int a, int b)
        {
            if (a < b)
            {
                return -1;
            }
            else if (b < a)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public static int CompareString(string a, string b)
        {
            if (a == b)
            {
                return 0;
            }

            if (a == null)
            {
                return -1;
            }

            if (b == null)
            {
                return 1;
            }

            if (a.Length < b.Length)
            {
                return -1;
            }

            if (a.Length > b.Length)
            {
                return 1;
            }

            return a.CompareTo(b);
        }

        public static T[] Sort(T[] arr, Func<T, T, int> compare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    T tmp = arr[i];
                    if (compare?.Invoke(arr[i], arr[j]) < 0)
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            SortingFinished?.Invoke(arr, EventArgs.Empty);
            return arr;
        }

        public static T[] RunInNewThread(T[] arr, Func<T, T, int> sortingParameter)
        {
            T[] newArr = new T[arr.Length];
            ThreadStart thStart = new ThreadStart(() => newArr = Sort(arr, sortingParameter));
            Thread th = new Thread(thStart);
            th.Start();
            return newArr;
        }

        protected virtual void OnSortingFinished(EventArgs e)
        {
            SortingFinished?.Invoke(this, e);
        }
    }
}
