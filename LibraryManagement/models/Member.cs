using System;

namespace LibraryManagement.Models
{
    internal class Member
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id_no;
        public int IdNo
        {
            get { return id_no; }
            set { id_no = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int phone_no;
        public int PhoneNo
        {
            get { return phone_no; }
            set { phone_no = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private byte[] img_hash;
        public byte[] ImgHash
        {
            get { return img_hash; }
            set { img_hash = value; }
        }

        private byte[] face_hash;
        public byte[] FaceHash
        {
            get { return face_hash; }
            set { face_hash = value; }
        }

    }
}