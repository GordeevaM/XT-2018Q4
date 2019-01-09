using Epam.Task06.BLL;
using Epam.Task06.BLL.Interfaces;
using Epam.Task06.DAL;
using Epam.Task06.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Common
{
    public class DependencyResolver
    {
        private static IUserDAO _userDao;

        private static IAwardDAO _awardDao;

        public static IUserDAO UserDao => _userDao ?? (_userDao = new UserDAO());

        public static IAwardDAO AwardDAO => _awardDao ?? (_awardDao = new AwardDAO());
        
        private static IUserLogic _userLogic;

        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao, CacheLogic));

        private static ICacheLogic _cacheLogic;

        public static ICacheLogic CacheLogic => _cacheLogic ?? (_cacheLogic = new CacheLogic());

        private static IAwardLogic _awardLogic;

        public static IAwardLogic AwardLogic => _awardLogic ?? (_awardLogic = new AwardLogic(AwardDAO));
    }
    }
