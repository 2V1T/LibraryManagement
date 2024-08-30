using LibraryManagement.adapter;
using LibraryManagement.database;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string sql = "SELECT * FROM member"; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable data = sqlExecute.executeQuery(cmd);
            return data;
        }

        public bool add (Member member)
        {
            string sql = "";
            SqlCommand cmd = new SqlCommand (sql, conn);
            bool result = sqlExecute.executeNoneQuery(cmd);
            return result;
        }

        public bool remove(int id) {
            string sql = "DELETE * FROM member WHERE id = @Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            bool result = sqlExecute.executeNoneQuery(cmd);
            return result;
        }

        public Member getById(int id) {
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
            }
            return member;
        }

        public Member getByCopiesId(int copiesId) {
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
                member.IdNo = (int)data.Rows[0]["id_no"];
            }
            return member;
        }
    }
}
