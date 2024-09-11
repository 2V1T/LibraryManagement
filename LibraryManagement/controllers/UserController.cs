using LibraryManagement.adapter;
using LibraryManagement.database;
using LibraryManagement.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagement.controllers
{
    internal class UserController
    {

        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();
        public UserController()
        {

        }

        public User getById(int id) {
            string sql = "SELECT * from vwUser WHERE id = @id";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.Parameters.AddWithValue("id", id);
            DataTable data = sqlExecute.executeQuery(sqlCommand);
            User user = new User();
            if (data.Rows.Count > 0) {
                user.Username = data.Rows[0]["username"].ToString();
                user.Name = data.Rows[0]["name"].ToString();
                user.Address = data.Rows[0]["address"].ToString();
                user.Email = data.Rows[0]["email"].ToString();
                user.PhoneNo = int.Parse(data.Rows[0]["phone_no"].ToString());
            }
            return user;
        }
        public int Login(string username, string password)
        {
            int id = 0;
            try
            {
                string sql = "EXEC login @username, @password";
                SqlCommand sqlCommand = new SqlCommand (sql, conn);
                sqlCommand.Parameters.AddWithValue ("username", username);
                sqlCommand.Parameters.AddWithValue ("password", password);
                DataTable data = sqlExecute.executeQuery (sqlCommand);
                if (data.Rows.Count > 0) {
                    id = int.Parse(data.Rows[0]["id"].ToString());
                }
                else
                {
                    id = 0;
                }
            }
            catch (Exception ex) {
                id = 0;
            }
            return id;
        }

        public void Update(User user)
        {
            try
            {
                string sql = "";
                SqlCommand cmd = new SqlCommand(sql, conn);
                bool result = sqlExecute.executeNoneQuery(cmd);
               
            }
            catch (Exception ex)
            {

            }
        }

        public string UpdatePassword(int id, string oldPassword, string newPassword, string retypePassword)
        {
            try
            {
                string sql = "EXEC doi_mat_khau @id, @old_password, @new_password, @retype_password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("old_password", oldPassword);
                cmd.Parameters.AddWithValue("new_password", newPassword);
                cmd.Parameters.AddWithValue("retype_password", retypePassword);
                DataTable data = sqlExecute.executeQuery(cmd);
                return data.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
                return "";
            }
        }

        public DataTable getAll()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM member";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                DataTable data = sqlExecute.executeQuery(sqlCommand);
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public bool UpdateInfo(int id, string name, string email, string address, int phoneNo) 
        {
            try
            {   
                conn.Open();
                string sql = "EXEC sua_thong_tin @id, @name, @email, @address, @phone_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone_no", phoneNo);
                bool result = sqlExecute.executeNoneQuery(cmd);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
