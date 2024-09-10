using System;
using System.Data.SqlClient;

namespace LibraryManagement.database
{
    public class DBConnection
    {
        private static readonly string connString = "Data Source=localhost;Initial Catalog=library;Persist Security Info=True;User ID=sa;Password=AYClqt1893@;Encrypt=True;TrustServerCertificate=True";
        private static DBConnection? _instance; // Declare as nullable
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