﻿using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.BLL.Interfaces
{
    public interface IUserLogic
    {
        void Add(User user);

        void Delete(int id);

        User GetById(int id);

        IEnumerable<User> GetAll();

    }
}
