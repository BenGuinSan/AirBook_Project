using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserAccess: DatabaseAccess
    {
        public string checkLogin(User user)
        {
            string info = checkLoginDTO(user);
            return info; 
        }
    }
}
