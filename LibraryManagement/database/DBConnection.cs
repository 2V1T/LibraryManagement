using System;
using System.Data.SqlClient;

namespace LibraryManagement.database
{
    public class DBConnection
    {
        private static readonly string connString = "Data Source=DESKTOP-9UT1BR7;Initial Catalog=library;Integrated Security=True";
        private static DBConnection _instance;
        private SqlConnection conn;

        // Private constructor to prevent instantiation
        private DBConnection()
        {
            conn = new SqlConnection(connString);
        }

        // Public method to get the single instance
        public static DBConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        // Method to get the SqlConnection
        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}