using DAL.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DatabaseConnection
    {
        public static SqlConnection conn;
        private string server_name = Resources.SERVER_NAME;
        private string database_name = Resources.DATABASE_NAME;
        public DatabaseConnection()
        {
            string strcon = $@"Data Source={server_name};Initial Catalog={database_name};Integrated Security=True";
            conn = new SqlConnection(strcon);
        }
        public SqlConnection Open()
        {
            conn.Open();
            return conn;
        }
        public SqlConnection Open<T>(T context)
        {
            conn.Open();
            Console.WriteLine($"{context.ToString()} da ket noi database!");
            return conn;
        }

        public void Close() { conn.Close(); }
        public void Close<T>(T context)
        {
            conn.Close();
            Console.WriteLine($"{context.ToString()} da ngat ket noi database!");
        }
    }
}
