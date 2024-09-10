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
                return data ?? new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return new DataTable();
            }
            finally
            {
                conn.Close();
            }
        }

        public bool returnBook (int idCopies)
        {
            try
            {
                conn.Open();
                string sql = "EXEC tra_sach @id";
                SqlCommand sqlCommand  = new SqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("id", idCopies);
                return sqlExecute.executeNoneQuery(sqlCommand);
            }
            catch (Exception)
            {
                return false;
            }
            finally { 
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
                return data ?? new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return new DataTable();
            }
            finally
            {
                conn.Close();
            }
        }

        public int getQuantity(int bookId)
        {
            int quantity = 0;
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) AS quantity FROM Copies WHERE book_id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", bookId);
                DataTable data = sqlExecute.executeQuery(cmd);
                if (data.Rows.Count > 0)
                {
                    quantity = int.Parse(data.Rows[0]["quantity"].ToString());
                }
                conn.Close();
            }
            catch (Exception)
            {
                    return 0;
            }
            return quantity;
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
                return data ?? new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return new DataTable();
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
                string sql = "UPDATE Book SET name=@Name, author_id=@AuthorId, category_id=@CategoryId, description=@Description WHERE id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", book.Name);
                cmd.Parameters.AddWithValue("@AuthorId", book.AuthorId);
                cmd.Parameters.AddWithValue("@CategoryId", book.CategoryId);
                cmd.Parameters.AddWithValue("@Description", book.Description);
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
                conn.Open();
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
                }
                conn.Close();
                return book;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return new Book();
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

                // Build dynamic SQL with parameter checks
                StringBuilder sql = new StringBuilder("SELECT book.id, book.name, author.name as 'author' , category.name as 'category', description,book_img FROM book full join author on author.id = Book.author_id full join Category on Category.id = Book.category_id WHERE ");
                bool whereClauseAdded = false;

                if (name != null)
                {
                    sql.Append("book.name LIKE @Name");
                    whereClauseAdded = true;
                }

                if (categoryId != 0)
                {
                    if (whereClauseAdded)
                    {
                        sql.Append(" AND ");
                    }
                    sql.Append("category_id = @categoryId");
                    whereClauseAdded = true;
                }

                if (publisherId != 0)
                {
                    if (whereClauseAdded)
                    {
                        sql.Append(" AND ");
                    }
                    sql.Append("author_id = @publisherId");
                    whereClauseAdded = true;
                }

                // Check if any WHERE clause was built
                if (!whereClauseAdded)
                {
                    // No search criteria, return empty DataTable
                    return new DataTable();
                }

                string finalSql = sql.ToString();
                SqlCommand cmd = new SqlCommand(finalSql, conn);

                // Add parameters with appropriate values (including null checks)
                cmd.Parameters.AddWithValue("@Name", name != null ? "%" + name + "%" : null);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.Parameters.AddWithValue("@publisherId", publisherId);

                DataTable data = sqlExecute.executeQuery(cmd);
                conn.Close();
                return data ?? new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return new DataTable();
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
