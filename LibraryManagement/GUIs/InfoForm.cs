using LibraryManagement.adapter;
using LibraryManagement.controllers;
using LibraryManagement.models;
using LibraryManagement.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.GUIs
{
    public partial class InfoForm : Form
    {
        UserController controller = new UserController();
        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();
        int id;
        public InfoForm(int id)
        {
            this.id = id;
            UserController userController = new UserController();
            User user = userController.getById(id);
            InitializeComponent();
            usernameLB.Text = user.Username.ToString();
            nameTB.Text = user.Name.ToString();
            emailTB.Text = user.Email.ToString();
            phoneNoTB.Text = user.PhoneNo.ToString();
            addressTB.Text = user.Address.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text.Trim();
            string email = emailTB.Text.Trim();
            string address = addressTB.Text.Trim();
            string phoneNo = phoneNoTB.Text.Trim();

            if (name.Equals("") || email.Equals("") || address.Equals("") || phoneNo.Equals(""))
            {
                MessageBox.Show("Cần điền đầy đủ thông tin");
                return;
            }
            bool result = controller.UpdateInfo(this.id, name, email, address, int.Parse(phoneNo));
  
            if(result)
            {
                MessageBox.Show("Cập nhật thông tin thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại");

            }
        }
    }
}
