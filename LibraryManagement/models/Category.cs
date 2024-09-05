﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.models
{
    internal class Category
    {
        private int id;
        private string name;
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

        public Category() { }
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}