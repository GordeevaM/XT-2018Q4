using Epam.Task06.BLL.Interfaces;
using Epam.Task06.Common;
using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Epam.Task10.WebUI
{
    public class Global : System.Web.HttpApplication
    {
        protected static IUserLogic userLogic = DependencyResolver.UserLogic;
        protected static IAwardLogic awardLogic = DependencyResolver.AwardLogic;

        public static void AddUser(string name, string lastName, DateTime dateOfBirth)
        {
            var user = new User
            {
                FirstName = name,
                LastName = lastName,
                DateOfBirth = dateOfBirth
            };
            userLogic.Add(user);
        }

        public static void AddAward(string title)
        {
            var award = new Award
            {
                Title = title
            };
            awardLogic.Add(award);
        }

        public static void AddAwardToUser(int userId, int awardId)
        {
            userLogic.AddAward(userId, awardId);
        }

        public static List<Award> ShowAwards()
        {
            List<Award> awards = new List<Award>();
            foreach (var award in awardLogic.GetAll())
            {
                awards.Add(award);
            }
            return awards;
        }

        public static List<Award> ShowUsersAwards(int userId)
        {
            List<Award> awards = new List<Award>();
            foreach (var award in userLogic.GetAwards(userId))
            {
                awards.Add(award);
            }
            return awards;
        }

        public static List<User> ShowUsers()
        {
            List<User> users = new List<User>();
            foreach (var user in userLogic.GetAll())
            {
                users.Add(user);
            }
            return users;

        }

        protected void Application_Start(object sender, EventArgs e)
        {
            


        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}