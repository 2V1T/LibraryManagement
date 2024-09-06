using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.models
{
    internal class Book
    {
        private int id;
        private string name;
        private int author_id;
        private int category_id;
        private string description;
        private int quantity;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int AuthorId
        {
            get
            {
                return author_id;
            }
            set
            {
                author_id = value;
            }
        }
        public int CategoryId
        {
            get
            {
                return category_id;
            }
            set
            {
                category_id = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }

        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public Book()
        {
        }
        public Book(int id, string name, int author_id, int category_id, string description, int quantity)
        {
            this.id = id;
            this.name = name;
            this.author_id = author_id;
            this.category_id = category_id;
            this.description = description;
            this.quantity = quantity;
        }
    }
}