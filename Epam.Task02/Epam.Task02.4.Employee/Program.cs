using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._4.Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            string lastName;
            string patronym;
            DateTime birthDate;
            string position;
            int workExperience;
            Console.WriteLine("Please, enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Please, enter your last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Please, enter your patronym");
            patronym = Console.ReadLine();
            Console.WriteLine("Please, enter your birth date (dd.MM.yyyy)");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out birthDate))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Console.WriteLine("Please, enter your work experience");
            while ((!int.TryParse(Console.ReadLine(), out workExperience)) || (workExperience > DateTime.Now.Year - birthDate.Year - 14))
            {
                Console.WriteLine("You entered invalid value, please, try again");
            }

            Console.WriteLine("Please, enter your position");
            position = Console.ReadLine();
            Employee emp = new Employee(name, lastName, patronym, birthDate, workExperience, position);
            Console.WriteLine("Your name: {0}, last name: {1}, patronym: {2}, birth date: {3}, age: {4}, work experience: {5}, position: {6}", emp.FirstName, emp.LastName, emp.Patronym, emp.BirthDate.Date, emp.Age, emp.WorkExperience, emp.Position);
            Console.ReadLine();
        }
    }
}
