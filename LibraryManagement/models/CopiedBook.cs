using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.models
{
    internal class CopiedBook
    {
        private int id;
        private int book_id;
        private bool available;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int BookId
        {
            get { return book_id; }
            set { book_id = value; }
        }

        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        public CopiedBook()
        {

        }
        public CopiedBook(int id, int book_id, bool available)
        {
            this.id = id;
            this.book_id = book_id;
            this.available = available;
        }
    }
}
