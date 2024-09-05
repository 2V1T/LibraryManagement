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
    internal class BorrowedDetailController
    {
        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();

        public bool add(BorrowedDetail borrowedDetail)
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
                string sql = "DELETE * FROM BorrowedDetails WHERE id = @Id";
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
        public BorrowedDetail getByIdMember(int memberId)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM BorrowedDetails WHERE member_id = @MemberId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberId", memberId);
                DataTable data = sqlExecute.executeQuery(cmd);
                BorrowedDetail borrowedDetail = new BorrowedDetail();
                if (data.Rows.Count > 0)
                {
                    borrowedDetail.Id = (int)data.Rows[0]["id"];
                    borrowedDetail.MemberId = (int)data.Rows[0]["member_id"];
                    borrowedDetail.CopiesId = (int)data.Rows[0]["copies_id"];
                    borrowedDetail.ReturnDate = (DateTime)data.Rows[0]["return_date"];
                }
                return borrowedDetail;
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
