using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public static class ConnectService
    {
        public static SqlConnection ConnectSql()
        {
            string conStr = "Server = .\\SQLEXPRESS; Database = Northwind; Trusted_Connection = True";

            SqlConnection conn = new SqlConnection(conStr);

            conn.Open();
            return conn;
        }
    }
}
// Server = myServerAddress; Database=myDataBase; Trusted_Connection=True;