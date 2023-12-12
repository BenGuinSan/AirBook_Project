using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserSignInAccess: DatabaseAccess
    {
        public string CheckLogin(User user)
        {
            string info = CheckLoginDTO(user);
            return info;
        }
    }
}
