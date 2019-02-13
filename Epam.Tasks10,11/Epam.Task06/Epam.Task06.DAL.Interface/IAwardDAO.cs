using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.DAL.Interface
{
    public interface IAwardDAO
    {
        void Add(Award award);

        bool Delete(int id);

        Award GetById(int id);

        IEnumerable<Award> GetAll();
    }
}
