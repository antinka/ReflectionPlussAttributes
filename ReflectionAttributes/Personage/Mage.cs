using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionAttributes
{
    public class Mage : Personage
    {
        public Mage(string name, int lvl, bool sex)
            : base(name, lvl, sex)
        {
        }
        [ColorAttribute(ConsoleColor.Blue)]
        public override string Name { get; set; }
    }
}
