using LibraryManagement.controllers;
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
        MemberController controller = new MemberController();
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

        private void addBT_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text.Trim();
            string address = addressTB.Text.Trim();
            int phoneNo = int.Parse(phoneNoTB.Text.Trim());
            if (email.Equals("") || address.Equals("") || phoneNoTB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin!");
                return;
            }
            string result = controller.add(long.Parse(idNo), Name, phoneNo, email, address);
            MessageBox.Show(result);
        }
    }
}
