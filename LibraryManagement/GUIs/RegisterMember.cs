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
        public new string Name { get; set; } = string.Empty; // Use 'new' keyword to hide inherited member
        public string idNo { get; set; } = string.Empty;
        public RegisterMember()
        {
            InitializeComponent();
        }

        public RegisterMember(string name, int id_no)
        {
            InitializeComponent();
            Name = name;
            idNo = id_no.ToString();
            phoneNoTB.Focus();
        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(idNo))
            {
                nameTB.Text = Name;
                cccdTB.Text = idNo;
            }
        }

        private void addBT_Click(object sender, EventArgs e)
        {
            string email = emailTB.Text.Trim();
            string address = addressTB.Text.Trim();
            int phoneNo = int.Parse(phoneNoTB.Text.Trim());
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phoneNoTB.Text.Trim()))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin!");
                return;
            }
            string result = controller.add(long.Parse(idNo), Name, phoneNo, email, address);
            MessageBox.Show(result);
        }
    }
}
