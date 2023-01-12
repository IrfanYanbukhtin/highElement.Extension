using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Standart_
{
    internal static class Extension
    {
        public static int Square(this int a)
        {
            return a * a;
        }
    }
}
