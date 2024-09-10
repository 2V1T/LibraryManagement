using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.models
{
    internal class Member
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private long id_no;
        public long IdNo
        {
            get { return id_no; }
            set { id_no = value; }
        }

        private string name = string.Empty;
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

        private string email = string.Empty;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string address = string.Empty;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private byte[] img_hash = Array.Empty<byte>();
        public byte[] ImgHash
        {
            get { return img_hash; }
            set { img_hash = value; }
        }

        private byte[] face_hash = Array.Empty<byte>();
        public byte[] FaceHash
        {
            get { return face_hash; }
            set { face_hash = value; }
        }
    }
}