using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task01._6.FontAdjustment
{
    class Program
    {
        [Flags]
        enum Fonts : byte
        {
            None,
            bold,
            italic,
            underline = 4,
        }
        static void Main(string[] args)
        {
            Fonts myFont = Fonts.None;
            while (true)
            {
                Console.WriteLine("Параметры надписи: {0}", myFont);
                myFont = ChangeFont(myFont);
            }

        }
        static Fonts ChangeFont(Fonts myFont)
        {
            Console.WriteLine("Введите: ");
            Console.WriteLine("1: {0}", Fonts.bold);
            Console.WriteLine("2: {0}", Fonts.italic);
            Console.WriteLine("3: {0}", Fonts.underline);
            int n = int.Parse(Console.ReadLine());
            if (n == 3) n = 4;
            if (myFont.HasFlag((Fonts)n))
            {
                myFont = (Fonts)n ^ myFont;
            }
            else if (myFont == Fonts.None)
            {
                myFont = (Fonts)n;
            }
            else myFont = (Fonts)n | myFont;

            return myFont;
        }
    }
}