using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
   public class UserCreateAccess: DatabaseAccess
   {
        public string checkSignUp(UserCreate userCreate)
        {
            string info = checkSignUpDTO(userCreate);
            return info;
        }
   }
}
