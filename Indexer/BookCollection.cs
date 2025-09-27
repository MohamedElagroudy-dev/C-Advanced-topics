using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class BookCollection
    {
        public Book[] books = new Book[3];

        //indexer definition

        public Book this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

    }
}
