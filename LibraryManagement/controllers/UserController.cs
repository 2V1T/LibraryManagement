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
    }
}
