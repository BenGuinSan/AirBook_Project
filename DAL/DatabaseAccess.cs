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
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=PENGUINSAN\SQLEXPRESS;Initial Catalog=AIRBOOK;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }

    public class DatabaseAccess
    {
   
        public static string CheckLoginDTO(User user)
        {

            string[] result = new string[2];

            // Tao ket noi den db
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc__login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"Email", user.Email);
            cmd.Parameters.AddWithValue(@"Pwd", user.Pwd);

            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    result[0] = reader.GetString(1);
                    result[1] = reader.GetString(0);

                    if (result[0] == "ROLE1")
                    {
                        return "admin";
                    } else
                    {
                        return "user";
                    }
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Email hoặc mật khẩu không chính xác!";
            }
            
            return result[1];
        }

        public static string CheckSignUpDTO(UserSignUp userSignUp)
        {
           SqlConnection conn = SqlConnectionData.Connect();
           conn.Open();

           SqlCommand cmd = new SqlCommand("proc__signup", conn);

           cmd.CommandType = CommandType.StoredProcedure;

           cmd.Parameters.AddWithValue(@"Email", userSignUp.Email);
           cmd.Parameters.AddWithValue(@"Pwd", userSignUp.Pwd);
           cmd.Parameters.AddWithValue(@"Real_name", userSignUp.Real_name);
           cmd.Parameters.AddWithValue(@"Username", userSignUp.Username);
           cmd.Parameters.AddWithValue(@"Gender", userSignUp.Gender);
           cmd.Parameters.AddWithValue(@"DoB", userSignUp.DoB);
           cmd.Parameters.AddWithValue(@"CCCD", userSignUp.CCCD);
           cmd.Parameters.AddWithValue(@"Nation", userSignUp.Nation);
           cmd.Parameters.AddWithValue(@"User_address", userSignUp.User_address);
           cmd.Parameters.AddWithValue(@"Phone_number", userSignUp.Phone_number);
           cmd.Parameters.AddWithValue(@"Date_create", DateTime.Now);
           cmd.Parameters.AddWithValue(@"IsDelete", false);

            if (checkEmailExists(userSignUp.Email))
            {
                return "Email đã tồn tại";
            }
            else
            {
               cmd.ExecuteNonQuery();
            }

            conn.Close();

            return null;
        }

        private static bool checkEmailExists(string email)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Email FROM users WHERE Email = @Email", conn);
            cmd.Parameters.AddWithValue("@Email", email);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }

            return false;
        }


    }
}

