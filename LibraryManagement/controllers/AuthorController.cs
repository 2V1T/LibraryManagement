using LibraryManagement.adapter;
using LibraryManagement.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.controllers
{
    internal class AuthorController
    {
        SqlConnection conn = DBConnection.GetInstance().GetConnection();
        SQLExecute sqlExecute = new SQLExecute();

        public AuthorController() { 
        }

        public DataTable getAll ()
        {
            string sql = "SELECT TOP (1000) [id]\r\n      ,[name]\r\n  FROM [library].[dbo].[Author];";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = sqlExecute.executeQuery(cmd);
            return dt;  
        }
    }
}
