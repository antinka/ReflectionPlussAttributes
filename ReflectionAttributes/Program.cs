using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Druid dru1 = new Druid("Felissiya", 50, true);
            ColourPrint.ColorPrint(dru1);
            Prist pri1 = new Prist("Ban", 100, true);
            ColourPrint.ColorPrint(pri1);
            Warrior war1 = new Warrior("Derir", 10, false);
            ColourPrint.ColorPrint(war1);
            Mage mag1 = new Mage("Anch", 8, true);
            ColourPrint.ColorPrint(mag1);
        }
    }
}
