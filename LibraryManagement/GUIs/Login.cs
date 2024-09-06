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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = loginUsername.Text;
            string pass = loginPass.Text;

            if (username.Equals("") && pass.Equals(""))
            {
                int id = 1;
                Form1 mainForm = new Form1(id);
                this.Hide();
                mainForm.ShowDialog();
                if (Application.OpenForms.Count != 0)
                {
                    this.Show();
                }
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
