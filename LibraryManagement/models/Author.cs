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
        public int Id { set { Id = value; } get { return id; } }
        

        public string Name { set { Name = value; } get { return Name; } }
    }
}
