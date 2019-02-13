using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task06.Entities
{
    public class AwardToUser
    {
        public int AwardId { get; set; }

        public int UserId { get; set; }

        public DateTime DateOfReception { get; set; }
    }
}
