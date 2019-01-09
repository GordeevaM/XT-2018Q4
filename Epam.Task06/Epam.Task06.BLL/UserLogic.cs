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
        private readonly IUserDAO _userDAO = new UserDAO();
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
            return _userDAO.GetById(id);
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
    }
}
