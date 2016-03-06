using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionAttributes
{
    public class Druid : Personage
    {
        public Druid(string name, int lvl, bool sex)
            : base(name, lvl, sex)
        {
        }
         [ColorAttribute(ConsoleColor.Green)]
        public override string Name { get; set; }
    }
}
