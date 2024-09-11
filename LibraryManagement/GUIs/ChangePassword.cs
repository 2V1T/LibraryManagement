using LibraryManagement.adapter;
using LibraryManagement.database;
using LibraryManagement.controllers;
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

    public partial class ChangePassword : Form
    {
        public static Form1 mainForm = new Form1();
        public static Login login = new Login();
        UserController controller = new UserController();
        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();
        int id;
        public bool isExit = false;
        public ChangePassword(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPassTB.Text.Trim();
            string newPassword = newPassTB.Text.Trim();
            string confirmPassword = retypePassTB.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại không khớp!");
                return;
            }
            string result = controller.UpdatePassword(this.id, oldPassword, newPassword, confirmPassword);
            mainForm.isLogout = true;
            if (!result.Equals(""))
            {
                isExit = true;
            }
            MessageBox.Show(result);
           this.Close();
        }
    }
}
