using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.BLL.Interfaces
{
    public interface IAwardLogic
    {
        void Add(Award award);

        void Delete(int id);

        Award GetById(int id);

        IEnumerable<Award> GetAll();
    }
}
