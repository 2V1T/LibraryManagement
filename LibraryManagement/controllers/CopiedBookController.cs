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
    internal class CopiedBookController
    {
        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();

        public DataTable getByBookId(int bookId)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM copies WHERE book_id = @bookId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bookId", bookId);
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

        public DataTable getAvailable(int bookId)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM copies WHERE book_id = @bookId AND available = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bookId", bookId);
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
        public bool add(CopiedBook copiedBook)
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
                string sql = "DELETE copies WHERE id = @Id";
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
        public bool update(CopiedBook copiedBook)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE copies SET book_id=@bookId, available=@Available WHERE id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bookId", copiedBook.BookId);
                cmd.Parameters.AddWithValue("@available", copiedBook.Available);
                cmd.Parameters.AddWithValue("@Id", copiedBook.Id);
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
