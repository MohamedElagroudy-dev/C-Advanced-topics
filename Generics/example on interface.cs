using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface Container<T> where T : struct //not accept refrence type // keyword (class) not accept value types
    {
        public void add(T name);
    }
    public class Box<T> : Container<T> where T : struct
    {
        public void add(T name)
        {
            Console.WriteLine(name);
        }
    }
}
