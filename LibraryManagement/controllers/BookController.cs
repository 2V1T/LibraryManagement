using LibraryManagement.adapter;
using LibraryManagement.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.database;

namespace LibraryManagement.controllers
{
    internal class BookController
    {
        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();
        public DataTable getAll()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM vwBook";
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

        public DataTable getByAuthorId(int AuthorId)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Book WHERE author_id = @AuthorId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@AuthorId", AuthorId);
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

        public DataTable getByCategoryId(int CategoryId)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Book WHERE author_id = @CategoryId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
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
        public bool add(Book book)
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

        public bool update(Book book)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE Book SET name=@Name, author_id=@AuthorId, category_id=@CategoryId, description=@Description, quantity=@Quantity WHERE id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", book.Name);
                cmd.Parameters.AddWithValue("@AuthorId", book.AuthorId);
                cmd.Parameters.AddWithValue("@CategoryId", book.CategoryId);
                cmd.Parameters.AddWithValue("@Description", book.Description);
                cmd.Parameters.AddWithValue("@Quantity", book.Quantity);
                cmd.Parameters.AddWithValue("@Id", book.Id);
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
                string sql = "DELETE * FROM Book WHERE id = @Id";
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
        public Book getById(int id)
        {
            try
            {
                string sql = "SELECT * FROM Book WHERE id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                DataTable data = sqlExecute.executeQuery(cmd);
                Book book = new Book();
                if (data.Rows.Count > 0)
                {
                    book.Id = (int)data.Rows[0]["id"];
                    book.Name = (string)data.Rows[0]["name"];
                    book.AuthorId = (int)data.Rows[0]["author_id"];
                    book.CategoryId = (int)data.Rows[0]["category_id"];
                    book.Description = (string)data.Rows[0]["description"];
                    book.Quantity = (int)data.Rows[0]["quantity"];

                }
                return book;
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
        public DataTable search(string name, int categoryId, int publisherId)
        {
            try
            {
                conn.Open();
                string sql = "Select * FROM Book where name=@Name, category_id=@categoryId, publisher_id=@publisherId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.Parameters.AddWithValue("@publisherId", publisherId);
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
    }
}
