using LibraryManagement.adapter;
using LibraryManagement.database;
using LibraryManagement.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.controllers
{
    internal class MemberController
    {
        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();
        public MemberController() {  
            
        }

        public DataTable getAll ()
        {
            conn.Open ();
            string sql = "SELECT * FROM member"; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable data = sqlExecute.executeQuery(cmd);
            conn.Close ();
            return data;
        }

        public bool add(long idNo, string name, int phoneNo, string email, string address)
        {
            try
            {
                conn.Open();
                string sql = "EXEC them_member @id_no, @name, @phone_no, @email, @address";
                SqlCommand cmd = new SqlCommand (sql, conn);
                cmd.Parameters.AddWithValue("id_no", idNo);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("phone_no", phoneNo);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("address", address);
                bool result = sqlExecute.executeNoneQuery(cmd);
                conn.Close ();
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool update(Member member) { 
           try
            {
                conn.Open();
                string sql = "EXEC sua_member @id_no, @phone_no, @email, @address";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("@id_no", member.IdNo);
                sqlCommand.Parameters.AddWithValue("@phone_no", member.PhoneNo);
                sqlCommand.Parameters.AddWithValue("@email", member.Email);
                sqlCommand.Parameters.AddWithValue("@address", member.Address);
                bool result = sqlExecute.executeNoneQuery(sqlCommand);
                conn.Close();
                return result;
            }
            catch (Exception e) { return false; }
        }
        public bool memberAvailable (long idNo)
        {
            bool result = false;
                conn.Open();
                string sql = "select count(*) as count from member inner join BorrowedDetails on member.id = BorrowedDetails.member_id WHERE id_no = @id_no AND BorrowedDetails.[return] = 0";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("@id_no", idNo);
                DataTable data = sqlExecute.executeQuery(sqlCommand);
                if (data.Rows.Count > 0)
                {
                    result =  (int)data.Rows[0]["count"] == 0;
                }
                conn.Close();
            return result;
        }

        public bool remove(long idNo) {
            conn.Open();
            string sql = "DELETE FROM member WHERE id_no = @idNo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idNo", idNo);
            bool result = sqlExecute.executeNoneQuery(cmd);
            conn.Close();
            return result;
        }

        public Member getById(int id) {
            conn.Open();
            string sql = "SELECT * FROM member WHERE id = @Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            DataTable data = sqlExecute.executeQuery(cmd);
            Member member = new Member();
            if (data.Rows.Count > 0) { 
                member.Id = (int)data.Rows[0]["id"];
                member.Name = (string)data.Rows[0]["name"];
                member.Email = (string)data.Rows[0]["email"];
                member.PhoneNo = (int)data.Rows[0]["phone_no"];
                member.IdNo = (long)data.Rows[0]["id_no"];
                member.Address = data.Rows[0]["address"].ToString();
            }
            conn.Close();
            return member;
        }

        public Member getByName(string name)
        {
            conn.Open();
            string sql = "SELECT * FROM member WHERE name = @name";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name",name);
            DataTable data = sqlExecute.executeQuery(cmd);
            Member member = new Member();
            if (data.Rows.Count > 0)
            {
                member.Id = (int)data.Rows[0]["id"];
                member.Name = (string)data.Rows[0]["name"];
                member.Email = (string)data.Rows[0]["email"];
                member.PhoneNo = (int)data.Rows[0]["phone_no"];
                member.IdNo = (long)data.Rows[0]["id_no"];
                member.Address = (string)data.Rows[0]["address"];
                return member;
            }
            conn.Close();
            return null;
        }

        public Member getByCopiesId(int copiesId) {
            conn.Open();
            string sql = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable data = sqlExecute.executeQuery(cmd);
            Member member = new Member();
            if (data.Rows.Count > 0)
            {
                member.Id = (int)data.Rows[0]["id"];
                member.Name = (string)data.Rows[0]["name"];
                member.Email = (string)data.Rows[0]["email"];
                member.PhoneNo = (int)data.Rows[0]["phone_no"];
                member.IdNo = (long)data.Rows[0]["id_no"];
            }
            conn.Close();
            return member;
        }

        public Member getByIdNo(long idNo) {
            try
            {
                conn.Open();
                string sql = "select * from tim_member_theo_cccd (@id)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", idNo);
                DataTable data = sqlExecute.executeQuery(cmd);
                Member member = null;
                if (data.Rows.Count > 0)
                {
                    member = new Member();
                    member.Id = (int)data.Rows[0]["id"];
                    member.Name = (string)data.Rows[0]["name"];
                    member.Email = (string)data.Rows[0]["email"];
                    member.PhoneNo = (int)data.Rows[0]["phone_no"];
                    member.IdNo = (long)data.Rows[0]["id_no"];
                    member.Address = (string)data.Rows[0]["address"];
                }
                conn.Close();
                return member;
            }
            catch (Exception ex) {
                return null;
            }

        }

        public DataTable getByKeyword(string keyword)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM member where name LIKE @keyword";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.Parameters.AddWithValue("keyword", '%' + keyword + '%');
                DataTable data = sqlExecute.executeQuery(sqlCommand);
                return data;
            }
            catch (Exception e)
            {
                return null;
            }
            finally { 
                conn.Close();
            }
        }
    }
}
