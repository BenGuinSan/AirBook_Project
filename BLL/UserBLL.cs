using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        UserAccess usAccess = new UserAccess();
        public string checkLogin(User user)
        {
            // Kiem tra nghiep vu


            if (user.Email == "")
            {
                return "requeid_Email";
            }

            if (user.Pwd == "")
            {
                return "requeid_PW";
            }

            string info = usAccess.checkLogin(user);
            return info;
        }
    }
}
