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
            string email = emailTB.Text.ToString();
            string address = addressTB.Text.ToString();
            string phoneNo = phoneNoTB.Text.ToString();
            if (email.Equals("") || address.Equals("") || phoneNoTB.Text.ToString().Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin!");
                return;
            }
            if (controller.add(long.Parse(idNo), Name, int.Parse(phoneNo), email, address))
            {
                MessageBox.Show("Đăng kí thành công!", "Thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng kí thất bại vui lòng thử lại!", "Thông báo");
                this.Close();  
            }
        }
    }
}
