﻿using Epam.Task06.DAL.Interface;
using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.DAL
{
    public class UserDAO: IUserDAO
    {
        private static readonly Dictionary<int, User> _repoUsers = new Dictionary<int, User>();
        public void Add(User user)
        {
            var lastId = _repoUsers.Any()
                ? _repoUsers.Keys.Max()
                : 0;
            user.Id = ++lastId;
            DateTime now = DateTime.Now;
            user.Age = DateTime.Now.Year - user.DateOfBirth.Year;
            if (now.Month < user.DateOfBirth.Month || (now.Month == user.DateOfBirth.Month && now.Day < user.DateOfBirth.Day))
            {
                user.Age--;
            }

            _repoUsers.Add(user.Id, user);
        }

        public bool Delete(int id)
        {
            return _repoUsers.Remove(id);
        }

        public User GetById(int id)
        {
            return _repoUsers.TryGetValue(id, out var user)
                ? user
                : null;
        }

        public IEnumerable<User> GetAll()
        {
            return _repoUsers.Values;
        }
    }
}
