using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionAttributes
{
    public class Warrior : Personage
    {
        public Warrior(string name, int lvl, bool sex)
            : base(name, lvl, sex)
        {
        }
         [ColorAttribute(ConsoleColor.DarkRed)]
        public override string Name { get; set; }
    }
}
