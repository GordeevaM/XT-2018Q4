using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._6.FontAdjustment
{
    [Flags]
    enum Fonts : byte
    {
        None,
        bold,
        italic,
        underline = 4,
    }
}
