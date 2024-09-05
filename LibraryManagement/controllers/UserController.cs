using LibraryManagement.adapter;
using LibraryManagement.models;
using LibraryManagement.database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.controllers
{
    internal class UserController
    {

        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();
        public UserController()
        {

        }

        public void Login(string username, string password)
        {
            try {
                conn.Open();
                string query = "SELECT * FROM Taikhoan WHERE Taikhoan = @username AND Matkhau = @password";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    MessageBox.Show("Đăng nhập thành công!");
          
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
                }
                reader.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update(User user)
        {
            try {
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            bool result = sqlExecute.executeNoneQuery(cmd);
            
            }
            catch (Exception ex) { 
            
            }
        }
    }
}
