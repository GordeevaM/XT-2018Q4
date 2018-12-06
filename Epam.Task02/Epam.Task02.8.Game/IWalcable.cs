using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._8.Game
{
    public interface IWalcable
    {
        void GoUp();
        
        void GoDown();

        void GoToTheRight();

        void GoToTheLeft();
    }
}
