using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task03._1.Lost
{
    public class Round
    {
        private LinkedList<int> people = new LinkedList<int>();

        public Round(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                this.people.AddLast(i);
            }
        }

        public LinkedList<int> People { get => this.people; set => this.people = value; }

        public int ShowLastPerson()
        {
            var currentPerson = this.people.First;
            while (this.people.Count > 1)
            {
                if (currentPerson.Next != null)
                {
                    this.people.Remove(currentPerson.Next.Value);
                    if (currentPerson.Next != null)
                    {
                        currentPerson = currentPerson.Next;
                    }
                    else
                    {
                        currentPerson = this.people.First;
                    }
                }
                else
                {
                    this.people.Remove(this.people.First);
                    currentPerson = this.people.First;
                }
            }

            return this.people.First.Value;
        }
}
}
