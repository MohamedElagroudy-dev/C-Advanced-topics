using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods
{
    internal static class NumExtention
    {
        public static bool GreaterThanTen(this int str)
        {
            return str >10;
        }
        
    }

}
