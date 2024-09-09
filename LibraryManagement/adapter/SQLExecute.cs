using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace LibraryManagement.adapter
{
    internal class SQLExecute
    {
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        private DataTable table;
        public SQLExecute () {}

        public DataTable executeQuery (SqlCommand sqlCommand)
        {
            adapter = new SqlDataAdapter(sqlCommand);
            dataSet = new DataSet();
            adapter.Fill (dataSet);
            table = dataSet.Tables[0];
            return table;
        }

        public bool executeNoneQuery(SqlCommand sqlCommand) { 
            try
            {
                int rowAffected = sqlCommand.ExecuteNonQuery();
                return rowAffected > 0;

            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi: " +ex.Message);
                return false;
            }
        }

        public byte[] excuteGetImage(SqlCommand sqlCommand, string key) { 
            byte[] varbinaryData;
            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (dataReader.Read()) {
                    varbinaryData = (byte[])dataReader[key];
                return varbinaryData;
                }
            }
            return null;
        }
    }
}
