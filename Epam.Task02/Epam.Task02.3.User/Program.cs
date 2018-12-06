using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._3.User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            string lastName;
            string patronym;
            DateTime birthDate;
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

            User user = new User(name, lastName, patronym, birthDate);
            Console.WriteLine("Your name: {0}, last name: {1}, patronym: {2}, birth date: {3}, age: {4}", user.FirstName, user.LastName, user.Patronym, user.BirthDate.Date, user.Age);
            Console.ReadLine();
        }
    }
}
