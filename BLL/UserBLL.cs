using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class UserBLL
    {
        private List<User> ListUser = new List<User>();
        private string procedure;
        private List<User> readUsersMapResult(SqlDataReader reader)
        {
            if (reader.HasRows)
            {
                User user;
                while (reader.Read())
                {
                    user = new User(
                        reader.GetString(0), //userID
                        reader.GetString(1), //roleID
                        reader.GetString(2), //username
                        reader.GetString(3), //pwd
                        reader.GetString(4), //realname
                        reader.GetDateTime(5), //doB
                        reader.GetString(6), //gender
                        reader.GetString(7), //nation
                        reader.GetString(8), //user_address
                        reader.GetString(9), //phonenum
                        reader.GetString(10), //cccd
                        reader.GetString(11), //email
                        reader.GetDateTime(12), //datecreate
                        reader.GetInt32(13) //isdelete
                        );
                    ListUser.Add(user);
                }
                reader.Close();
            }
            return ListUser;
        }

        public UserBLL()
        {
            List<SqlParameter> parameters = null;
            procedure = "usp_users_Read";
            DatabaseAccess.Execute(procedure, parameters, readUsersMapResult);
        }

        public List<User> getList()
        {
            return ListUser;
        }

        //CÁC XỬ LÝ NGHIỆP VỤ

        //public string checkLogin(User user)
        //{
        //    // Kiem tra nghiep vu

        //    if (user.Email == "")
        //    {
        //        return "requeid_Email";
        //    }

        //    if (user.Pwd == "")
        //    {
        //        return "requeid_PW";
        //    }

        //    if (user.Pwd.Contains(" "))
        //    {
        //        return "Pasword_has_space";
        //    }

        //    string info = usAccess.checkLogin(user);
        //    return info;
        //}

    }
}
