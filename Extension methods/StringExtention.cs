using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods
{
    internal static class StringExtention
    {
        public static string RemoveWhiteSpaces(this string str)
        {
            return str.Replace(" ", "");
        }
        public static string Reverse(this string str)
        {
            var val = str.ToCharArray();
            Array.Reverse(val);
            return new string(val);
        }
    }

}
