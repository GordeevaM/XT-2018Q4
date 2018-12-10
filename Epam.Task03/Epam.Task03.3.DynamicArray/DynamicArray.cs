using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03._3.DynamicArray
{
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable, ICloneable
    {
        public T[] arr;

        public DynamicArray()
        {
            T[] arr = new T[8];
        }

        public DynamicArray(int n)
        {
            T[] arr = new T[n];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            T[] arr = collection.ToArray<T>();
        }

        public int Length
        {
            get => this.arr.GetLength(0);
        }

        public int Capacity
        {
            get => this.arr.Length;
        }

        public T this[int index]
        {
            get
            {
                return this.arr[index];
            }

            set
            {
                try
                {
                    this.arr[index] = value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw;
                }
            }
        }

        public void Add(T newElem)
        {
            if ((this.arr != null) && this.arr.Any())
            {
                try
                {
                    int max = this.arr.GetUpperBound(0);
                    this.arr[max + 1] = newElem;
                }
                catch (IndexOutOfRangeException)
                {
                    T[] newArr = new T[this.arr.Length * 2];
                    newArr[this.arr.Length + 1] = newElem;
                }
            }
            else
            {
                T[] newArr = new T[this.arr.Length * 2];
                newArr[this.arr.Length + 1] = newElem;
            }
        }
        
        public void AddRange(IEnumerable<T> collection)
        {
            int max = this.arr.GetUpperBound(0);
            try
            {
                this.arr[max + collection.Count()] = collection.Last();
            }
            catch (IndexOutOfRangeException)
            {
                T[] newArr = new T[max + collection.Count() + 8];
                int i = max + 1;
                foreach (var item in collection)
                {
                    newArr[i] = item;
                }
            }
            catch (NullReferenceException)
            {
                if (this.arr.Length >= collection.Count())
                {
                    this.arr = collection.ToArray();
                }
                else
                {
                    T[] newArr = new T[collection.Count() + 8];
                    newArr = collection.ToArray();
                }
            }
        }

        public bool Remove(int n)
        {
            try
            {
                for (int i = n; i < this.arr.Length - 1; i++)
                {
                    this.arr[i] = this.arr[i + 1];
                }

                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        public bool Insert(int n, T newElem)
        {
            try
            {
                if (this.Capacity < this.Length + 1)
                {
                    T[] newArr = new T[n + 8];
                    for (int i = 0; i < n; i++)
                    {
                        newArr[i] = this.arr[i];
                    }

                    for (int i = this.arr.GetUpperBound(0); i > n + 1; i--)
                    {
                        newArr[i + 1] = this.arr[i];
                    }

                    newArr[n] = newElem;
                    return true;
                }
                else
                {
                    for (int i = this.arr.GetUpperBound(0); i > n; i--)
                    {
                        this.arr[i + 1] = this.arr[i];
                    }

                    this.arr[n] = newElem;
                    return true;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        public override string ToString()
        {
            if ((this.arr != null) && this.arr.Any())
            {
                List<string> str = new List<string>();
                foreach (var elem in this.arr)
                {
                    str.Add(elem.ToString());
                }

                return str.ToString();
            }
            else
            {
                return "Your Dinamic Array is empty";
            }
        }

        public T GetElement(int n)
        {
            try
            {
                if (n < 0)
                {
                    return this.arr[this.arr.Length + n];
                }
                else
                {
                    return this.arr[n];
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)this.arr).GetEnumerator();
        }

        public object Clone()
        {
            DynamicArray<T> clone = new DynamicArray<T>(this.arr.Length);
            for (int i = 0; i < this.Length; i++)
            {
                clone[i] = this[i];
            }

            return clone;
        }

        public T[] ToArray()
        {
            T[] newArr = new T[this.arr.Length];
            for (int i = 0; i < this.arr.Length; i++)
            {
                newArr[i] = this.arr[i];
            }

            return newArr;
        }
    }
}
