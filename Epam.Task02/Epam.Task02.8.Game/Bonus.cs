using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._8.Game
{
    public abstract class Bonus
    {
        private int x;
        private int y;

        public int X { get => this.x; set => this.x = value; }

        public int Y { get => this.y; set => this.y = value; }

        public abstract void Action();
    }
}
