using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._3.User
{
    public class User
    {
        private string firstName;
        private string lastName;
        private string patronym = null;
        private int age;
        private DateTime birthDate;

        public User(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.age = DateTime.Now.Year - birthDate.Year;
        }

        public User(string firstName, string lastName, string patronym, DateTime birthDate) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronym = patronym;
            this.BirthDate = birthDate;
            this.age = DateTime.Now.Year - birthDate.Year;
        }

        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (value.Length < 20)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("Too long first name");
                }
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                if (value.Length < 20)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Too long last name");
                }
            }
        }

        public string Patronym
        {
            get => this.patronym;
            set
            {
                if (value.Length < 20)
                {
                    this.patronym = value;
                }
                else
                {
                    throw new ArgumentException("Too long patronym");
                }
            }
        }

        public int Age { get => this.age; }

        public DateTime BirthDate
        {
            get => this.birthDate;
            set
            {
                if (DateTime.Now.Year - this.birthDate.Year > 0)
                {
                    this.birthDate = value;
                }
                else
                {
                    throw new ArgumentException("Wrong birth date");
                }
            }
        }
    }
}
