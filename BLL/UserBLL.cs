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
        UserSignInAccess usAccess = new UserSignInAccess();
        public string checkLogin(User user)
        {
            
            if (user.Email == "")
            {
                return "requeid_Email";
            }

            if (user.Pwd == "")
            {
                return "requeid_PW";
            }

            if (user.Pwd.Contains(" "))
            {
                return "Pasword_has_space";
            }

            string info = usAccess.CheckLogin(user);
            return info;
        }

    }
}
