using Epam.Task06.BLL;
using Epam.Task06.BLL.Interfaces;
using Epam.Task06.Common;
using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.ConsolePL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUserLogic userLogic = DependencyResolver.UserLogic;
            IAwardLogic awardLogic = DependencyResolver.AwardLogic;
            Console.WriteLine("Users: id, name, date of birth, age");
            ShowUsers(userLogic);
            AddUser(userLogic);
            ShowUsers(userLogic);
            AddAward(awardLogic);
            Console.WriteLine("Awards: id, title");
            ShowAwards(awardLogic);
        }

        private static void AddUser(IUserLogic userLogic)
        {
            var user = new User
            {
                Name = "David",
                DateOfBirth = DateTime.Now
            };
        userLogic.Add(user);
        }

        private static void ShowUsers(IUserLogic userLogic)
        {
            Console.WriteLine();
            foreach (var user in userLogic.GetAll())
            {
                Console.WriteLine(user);
            }
        }

        private static void AddAward(IAwardLogic awardLogic)
        {
            var award = new Award
            {
                Title = "First Award"
            };
            awardLogic.Add(award);
        }

        private static void ShowAwards(IAwardLogic awardLogic)
        {
            Console.WriteLine();
            foreach (var award in awardLogic.GetAll())
            {
                Console.WriteLine(award);
            }
        }
    }
}
