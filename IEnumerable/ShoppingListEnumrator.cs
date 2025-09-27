using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerabl
{
    public class ShoppingListEnumrator : IEnumerator
    {
        
        private string[] Items;
        private int position = -1;
        public ShoppingListEnumrator(string[] items)
        {
            Items = items;
        }
        
        public object Current
        {
            get
            {
                return Items[position];
            }      
        }

        public bool MoveNext()
        {
            position++;
            return position <= Items.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
