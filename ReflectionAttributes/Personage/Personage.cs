using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionAttributes
{
    public abstract class Personage
    {
        int lvl;
        public virtual string Name { get; set; }

        [ColorAttribute(ConsoleColor.Red)]
        public bool PVP { get; set; }
         [ColorAttribute(ConsoleColor.Cyan)]
        public int Lvl
        {
            get { return lvl; }
            set
            {
                if (value > 100 || value < 1)
                {
                    throw new ApplicationException("Значение должно быть в диапазоне от 1 до 100");
                }
                lvl = value;
            }
        }
        public Personage(string name, int lvl, bool pvp)
        {
            Name = name;
            Lvl = lvl;
            PVP = pvp;
        }
    }
}
