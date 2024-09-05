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
    internal class AuthorController
    {
        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();
        public DataTable getAll()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM author";
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable data = sqlExecute.executeQuery(cmd);
                return data;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool add(Author author)
        {
            try
            {
                conn.Open();
                string sql = "";
                SqlCommand cmd = new SqlCommand(sql, conn);
                bool result = sqlExecute.executeNoneQuery(cmd);
                return result;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool delete(int id)
        {
            try
            {
                conn.Open();
                string sql = "DELETE * FROM author WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                bool result = sqlExecute.executeNoneQuery(cmd);
                return result;             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool update(Author author)
        {
            try
            {
                conn.Open();
                string sql = "Update * FROM author SET name=@Name WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", author.Id);
                cmd.Parameters.AddWithValue("@Name", author.Name);
                bool result = sqlExecute.executeNoneQuery(cmd);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}
