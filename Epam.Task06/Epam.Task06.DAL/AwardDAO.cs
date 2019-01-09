using Epam.Task06.DAL.Interface;
using Epam.Task06.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.DAL
{
    public class AwardDAO : IAwardDAO
    {
        private static readonly Dictionary<int, Award> _repoAwards = new Dictionary<int, Award>();
        public void Add(Award award)
        {
            var lastId = _repoAwards.Any()
                ? _repoAwards.Keys.Max()
                : 0;
            award.Id = ++lastId;

            _repoAwards.Add(award.Id, award);
        }

        public bool Delete(int id)
        {
            return _repoAwards.Remove(id);
        }

        public Award GetById(int id)
        {
            return _repoAwards.TryGetValue(id, out var award)
                ? award
                : null;
        }

        public IEnumerable<Award> GetAll()
        {
            return _repoAwards.Values;
        }
    }
}
