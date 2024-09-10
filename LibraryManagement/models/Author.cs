using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.models
{
    internal class Author
    {
        private int id;
        private string name = string.Empty; // Initialize to avoid CS8618

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Author() { }
        public Author(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}