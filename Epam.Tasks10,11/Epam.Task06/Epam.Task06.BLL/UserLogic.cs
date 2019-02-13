using Epam.Task06.BLL.Interfaces;
using Epam.Task06.DAL;
using Epam.Task06.DAL.Interface;
using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDAO _userDAO = new UserSQLDAO();
        private readonly ICacheLogic _cacheLogic;

        private const string ALL_USERS_CACHE_KEY = "GetAll";

        public UserLogic(IUserDAO userDAO, ICacheLogic cacheLogic)
        {
            _userDAO = userDAO;
            _cacheLogic = cacheLogic;
        }

        public void Add(User user)
        {
            _cacheLogic.Delete(key: ALL_USERS_CACHE_KEY);
            _userDAO.Add(user);
        }

        public void Delete(int id)
        {
            _userDAO.Delete(id);
        }

        public User GetById(int id)
        {
            User user = _userDAO.GetById(id);
            user.Age = DateTime.Now.Year - user.DateOfBirth.Year;
            DateTime now = DateTime.Now;
            if (now.Month < user.DateOfBirth.Month || (now.Month == user.DateOfBirth.Month && now.Day < user.DateOfBirth.Day))
            {
                user.Age--;
            }
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            var cacheResult = _cacheLogic.Get<IEnumerable<User>>(ALL_USERS_CACHE_KEY);

            if (cacheResult == null)
            {
                var result = _userDAO.GetAll();
                _cacheLogic.Add(ALL_USERS_CACHE_KEY, _userDAO.GetAll());
                return result;
            }
            return cacheResult;
        }

        public IEnumerable<Award> GetAwards(int userId)
        {
            return _userDAO.GetAwards(userId);
        }

        public void AddAward(int userId, int awardId)
        {
            _userDAO.AddAward(userId, awardId);
        }
    }
}
