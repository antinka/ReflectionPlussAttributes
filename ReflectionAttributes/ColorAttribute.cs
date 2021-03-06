﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    class ColorAttribute : Attribute
    {
         public ConsoleColor Color { get; set; }

         public ColorAttribute(ConsoleColor color)
        {
            Color = color;
        }
    }
}
