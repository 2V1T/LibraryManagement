using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.GUIs
{
    public partial class RegisterMember : Form
    {
        public string Name;
        public string idNo;
        public RegisterMember()
        {
            InitializeComponent();
        }

        public RegisterMember(string name, int id_no)
        {
            InitializeComponent();
            phoneNoTB.Focus();
        }


        private void RegisterMember_Load(object sender, EventArgs e)
        {
            if (Name != null && idNo != null) 
            {
                nameTB.Text = Name;
                cccdTB.Text = idNo.ToString();
            }
        }
    }
}
