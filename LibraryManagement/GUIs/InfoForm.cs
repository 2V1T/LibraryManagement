using LibraryManagement.controllers;
using LibraryManagement.models;
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
    public partial class InfoForm : Form
    {
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
    }
}
