using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task02._8.Game
{
    public class Field
    {
        private int width;
        private int height;

        public int Width { get => this.width; set => this.width = value; }

        public int Height { get => this.height; set => this.height = value; }
    }
}
