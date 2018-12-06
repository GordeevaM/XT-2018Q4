using System;
using Epam.Task02._3.User;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._4.Employee
{
    public class Employee : User
    {
        private int workExperience;
        private string position;

        public Employee(string firstName, string lastName, DateTime birthDate) 
            : base(firstName, lastName, birthDate)
        {
        }

        public Employee(string firstName, string lastName, string patronym, DateTime birthDate) 
            : base(firstName, lastName, patronym, birthDate)
        {
        }

        public Employee(string firstName, string lastName, DateTime birthDate, int workExperience, string position)
            : base(firstName, lastName, birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.workExperience = workExperience;
            this.position = position;
        }

        public Employee(string firstName, string lastName, string patronym, DateTime birthDate, int workExperience, string position)
            : base(firstName, lastName, birthDate)
        {
            this.Patronym = patronym;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.workExperience = workExperience;
            this.position = position;
        }

        public int WorkExperience
        {
            get => this.workExperience;
            set
            {
                if (value <= this.Age - 14)
                {
                    this.workExperience = value;
                }
                else
                {
                    throw new ArgumentException("work experience can not be more, than age - 14");
                }
            }
        }

        public string Position { get => this.position; set => this.position = value; }
    }
}
