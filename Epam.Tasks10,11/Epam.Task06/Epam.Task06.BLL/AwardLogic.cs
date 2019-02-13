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
    public class AwardLogic: IAwardLogic
    {
        private readonly IAwardDAO _awardDAO = new AwardDAO();

        private const string ALL_AWARDS_CACHE_KEY = "GetAll";

        public AwardLogic(IAwardDAO awardDAO)
        {
            _awardDAO = awardDAO;
        }

        public void Add(Award award)
        {
            _awardDAO.Add(award);
        }

        public void Delete(int id)
        {
            _awardDAO.Delete(id);
        }
        
        public Award GetById(int id)
        {
            return _awardDAO.GetById(id);
        }

        public IEnumerable<Award> GetAll()
        {
            var result = _awardDAO.GetAll();
            return result;
        }
    }
}
