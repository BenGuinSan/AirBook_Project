using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data;

namespace DAL
{
    // Tao ket noi voi db
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=PENGUINSAN\SQLEXPRESS;Initial Catalog=AIRBOOK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // Khoi tao connect
            return conn;
        }
    }
    public class DatabaseAccess
    {
        public static string checkLoginDTO(User user)
        {
            string userlg = null;
            // Tao ket noi den db
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc__login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"Email", user.Email);
            cmd.Parameters.AddWithValue(@"Pwd", user.Pwd);
            // Kiem tra Role

            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    userlg = reader.GetString(0);
                    return userlg;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Email hoặc mật khẩu không chỉnh xác!";
            }
            return userlg;
        }
    }
}
