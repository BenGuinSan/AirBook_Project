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
    public class DatabaseAccess
    {
        static DatabaseConnection connection = new DatabaseConnection();
        SqlConnection conn;
        public DatabaseAccess()
        {
            conn = connection.Open();
        }
        //public T Execute<T>(string storedProcedureName, List<SqlParameter> parameters, Func<SqlDataReader, T> mapFunction)
        //{
        //    conn = connection.Open();
        //    SqlCommand cmd = new SqlCommand(storedProcedureName, conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Clear();
        //    if (parameters != null)
        //    {
        //        cmd.Parameters.AddRange(parameters.ToArray<SqlParameter>());
        //    }

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    return mapFunction(reader);
        //}
        public static T Execute<T>(string storedProcedureName, List<SqlParameter> parameters, Func<SqlDataReader, T> mapResult)
        {
            using (SqlConnection conn = connection.Open()) // Sử dụng using cho SqlConnection để đảm bảo rằng SqlConnection sẽ được đóng sau khi khối using kết thúc
            {
                using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray<SqlParameter>());
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return mapResult(reader);
                    }
                }
            }
        }

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

        //public static string checkSignUpDTO(UserCreate userCreate)
        //{
        //    SqlConnection conn = SqlConnectionData.Connect();
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand("proc__signup", conn);

        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue(@"Email", userCreate.Email);
        //    cmd.Parameters.AddWithValue(@"Pwd", userCreate.Pwd);
        //    cmd.Parameters.AddWithValue(@"Real_name", userCreate.Real_name);
        //    cmd.Parameters.AddWithValue(@"Username", userCreate.Real_name);
        //    cmd.Parameters.AddWithValue(@"DoB", userCreate.DoB);
        //    cmd.Parameters.AddWithValue(@"Gender", userCreate.Gender);
        //    cmd.Parameters.AddWithValue(@"CCCD", userCreate.CCCD);
        //    cmd.Parameters.AddWithValue(@"Nation", userCreate.Nation);
        //    cmd.Parameters.AddWithValue(@"User_address", userCreate.User_address);
        //    cmd.Parameters.AddWithValue(@"Phone_number", userCreate.Phone_number);
        //    cmd.Parameters.AddWithValue(@"Date_create", DateTime.Now);

        //    if (checkEmailExists(userCreate.Email))
        //    {
        //        return "Email đã tồn tại";
        //    }
        //    else
        //    {
        //        cmd.ExecuteNonQuery();
        //    }

        //    conn.Close();

        //    return null;

        //}

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

