using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data;
using System.Xml.Linq;

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
        //Check trên GUI vì còn phải check Role để xem nó có quyền gì rồi mới chuyển hướng cho vào AdminGUI hay ClientGUI
        //Tức là cần load listBUS trước sau đó tìm object nếu tìm không có thì đăng nhập thất bại
        //public static string checkLoginDTO(User user)
        //{
        //    string userlg = null;
        //    // Tao ket noi den db
        //    SqlConnection conn = SqlConnectionData.Connect();
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("proc__login", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue(@"Email", user.Email);
        //    cmd.Parameters.AddWithValue(@"Pwd", user.Pwd);
        //    cmd.Parameters.AddWithValue(@"IsDelete", user.IsDelete);
        //    cmd.Connection = conn;

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while(reader.Read())
        //        {
        //            userlg = reader.GetString(0);
        //            return userlg;
        //        }
        //        reader.Close();
        //        conn.Close();
        //    }
        //    else
        //    {
        //        return "Email hoặc mật khẩu không chính xác!";
        //    }
        //    return userlg;
        //}

        public static string checkSignUpDTO(UserCreate userCreate)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc__signup", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(@"Email", userCreate.Email);
            cmd.Parameters.AddWithValue(@"Pwd", userCreate.Pwd);
            cmd.Parameters.AddWithValue(@"Real_name", userCreate.Real_name);
            cmd.Parameters.AddWithValue(@"Username", userCreate.Real_name);
            cmd.Parameters.AddWithValue(@"DoB", userCreate.DoB);
            cmd.Parameters.AddWithValue(@"Gender", userCreate.Gender);
            cmd.Parameters.AddWithValue(@"CCCD", userCreate.CCCD);
            cmd.Parameters.AddWithValue(@"Nation", userCreate.Nation);
            cmd.Parameters.AddWithValue(@"User_address", userCreate.User_address);
            cmd.Parameters.AddWithValue(@"Phone_number", userCreate.Phone_number);
            cmd.Parameters.AddWithValue(@"Date_create", DateTime.Now);

            if (checkEmailExists(userCreate.Email))
            {
                return "Email đã tồn tại";
            } else {
                cmd.ExecuteNonQuery();
            }

            conn.Close();

            return null;

        }

        //Check trên GUI tương tự bên trên tối ưu hóa thời gian request server
        //private static bool checkEmailExists(string email)
        //{
        //    SqlConnection conn = SqlConnectionData.Connect();
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("SELECT Email FROM users WHERE Email = @Email", conn);
        //    cmd.Parameters.AddWithValue("@Email", email);

        //    SqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}

