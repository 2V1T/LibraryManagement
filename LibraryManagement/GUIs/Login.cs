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
        static Form1 mainForm = new Form1();
        static InfoForm infoForm = new InfoForm();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = loginUsername.Text;
            string pass = loginPass.Text;

            if (username.Equals("doankhacvi") && pass.Equals("khacvi2003"))
            {
                mainForm.Visible = true;
                this.Visible = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
