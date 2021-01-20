using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
   public static class MyExtensions
    {
        public static int KaresiniAl(this int value)
        {
            return (int)Math.Pow(value, 2);
        }

        public static string BosluklariKaldir(this string value)
        {
            return value.Replace(" ", string.Empty);
        }
    }
}
