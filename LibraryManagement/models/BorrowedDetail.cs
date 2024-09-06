using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.models
{
    internal class BorrowedDetail
    {
        private int id;
        private int member_id;
        private int copies_id;
        private DateTime return_date;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public int MemberId
        {
            set { member_id = value; }
            get { return member_id; }
        }
        public int CopiesId
        {
            set { copies_id = value; }
            get { return copies_id; }
        }

        public DateTime ReturnDate
        {
            set { return_date = value; }
            get { return return_date; }
        }

        public BorrowedDetail()
        {

        }
        public BorrowedDetail(int id, int member_id, int copies_id, DateTime return_date)
        {
            this.id = id;
            this.member_id = member_id;
            this.copies_id = copies_id;
            this.return_date = return_date;
        }
    }
}
