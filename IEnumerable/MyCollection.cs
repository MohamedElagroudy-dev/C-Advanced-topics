using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerabl
{
    internal class ShoppingList : IEnumerable
    {
        string[] items = new string[3] {"Bread","Eeg","Milk"};
        public IEnumerator GetEnumerator()
        {
            return new ShoppingListEnumrator(items);
        }

      
    }
}
