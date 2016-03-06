using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionAttributes
{
    class ColourPrint
    {
        public static void ColorPrint(object obj)
        {
            Type t = obj.GetType();
            Console.Write(t.Name + " \n");
            foreach (PropertyInfo propInfo in t.GetProperties())
            {
                ColorAttribute colourAtt = (ColorAttribute)Attribute.GetCustomAttribute(propInfo, typeof(ColorAttribute));
                Console.Write(propInfo.Name + " - ");
                if (colourAtt != null)
                {
                    ConsoleColor currentForeground = Console.ForegroundColor;
                    Console.ForegroundColor = colourAtt.Color;
                    Console.Write(propInfo.GetValue(obj)+"\n");
                    Console.ForegroundColor = currentForeground;
                }
                else
                {
                    Console.WriteLine(propInfo.GetValue(obj));
                }
            }
            Console.WriteLine();
        }
    }
}
