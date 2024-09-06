using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.models
{
    internal class User
    {
        private int id;
        private string username;
        private byte[] password;
        private string name;
        private string email;
        private string address;
        private int phone_no;
        private bool admin;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Username
        {
            set { username = value; }
            get { return username; }
        }
        public byte[] Password
        {
            set { password = value; }
            get { return password; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        public int PhoneNo
        {
            set { phone_no = value; }
            get { return phone_no; }
        }
        public bool Admin
        {
            set { admin = value; }
            get { return admin; }
        }

        public User() { }
        public User(int id, string username, byte[] password, string name, string email, string address, int phone_no, bool admin)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
            this.address = address;
            this.phone_no = phone_no;
            this.admin = admin;
        }
    }
}
