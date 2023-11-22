using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class UserCreateBLL
    {
        UserCreateAccess usCreateAccess = new UserCreateAccess();
        public string checkSignUP(UserCreate userCreate)
        {
            if (userCreate.Email == "" )
            {
                return "requeid_Email";
            }
            if(userCreate.Pwd == "")
            {
                return "requeid_Pwd";
            }
            if (userCreate.Pwd.Contains(" "))
            {
                return "Pasword_has_space";
            }
            if (userCreate.PwdAccsess == "")
            {
                return "requeid_PwdAccess";
            }
            if(userCreate.Real_name == "")
            {
                return "requeid_Realname";
            }
            if( userCreate.Nation == "")
            {
                return "requeid_Nation";
            }
            if(userCreate.CCCD == "")
            {
                return "requeid_CCCD";
            }
            if(userCreate.User_address == "")
            {
                return "requeid_UserAddress";
            }
            if(userCreate.Phone_number == "")
            {
                return "requeid_Phonenumber";
            }
            if(userCreate.Pwd != userCreate.PwdAccsess)
            {
                return "Xác nhận mật khẩu không trùng với mật khẩu";
            }
            if(userCreate.Email != "" && !IsValidEmail(userCreate.Email))
            {
                return "Định dạng email không chính xác";
            }
            if(userCreate.Real_name != "" && !IsValidName(userCreate.Real_name))
            {
                return "Định dạng họ và tên không chính xác";
            }
            if(userCreate.DoB > DateTime.Now)
            {
                return "Ngày sinh không thể là ngày mai";
            }
            if(userCreate.Phone_number != "" && !IsValidPhone(userCreate.Phone_number))
            {
                return "Số điện thoại không đúng định dạng";
            }
            if(userCreate.CCCD != "" && !IsValidCCCD(userCreate.CCCD))
            {
                return "CCCD không đúng định dạng";
            }
            

            string info = usCreateAccess.checkSignUp(userCreate);
            return info;
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]) && !Char.IsWhiteSpace(name[i]))
                {
                    return false;
                }
            }

            return true;
        }
        private bool IsValidPhone(string phone)
        {
            // Kiểm tra độ dài của số điện thoại
            if (phone.Length > 10 && phone.Length < 8)
            {
                return false;
            }

            // Kiểm tra xem số điện thoại có chứa ký tự đặc biệt hay không
            for (int i = 0; i < phone.Length; i++)
            {
                if (!Char.IsDigit(phone[i]))
                {
                    return false;
                }
            }

            return true;
        }
        private bool IsValidCCCD(string phone)
        {

            for (int i = 0; i < phone.Length; i++)
            {
                if (!Char.IsDigit(phone[i]))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
