using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.DAL.Interface
{
    public interface IUserDAO
    {
        void Add(User user);

        bool Delete(int id);

        User GetById(int id);

        IEnumerable<User> GetAll();
    }
}
