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
        UserSignUpAccess usSignUpAccess = new UserSignUpAccess();
        public string checkSignUP(UserSignUp userSignUp)
        {
            if (userSignUp.Email == "" )
            {
                return "requeid_Email";
            }
            if (userSignUp.Pwd == "")
            {
                return "requeid_Pwd";
            }
            if (userSignUp.Pwd.Contains(" "))
            {
                return "Pasword_has_space";
            }
            if (userSignUp.PwdAccess == "")
            {
                return "requeid_PwdAccess";
            }
            if(userSignUp.Real_name == "")
            {
                return "requeid_Realname";
            }
            if(userSignUp.Nation == "")
            {
                return "requeid_Nation";
            }
            if(userSignUp.CCCD == "")
            {
                return "requeid_CCCD";
            }
            if(userSignUp.User_address == "")
            {
                return "requeid_UserAddress";
            }
            if(userSignUp.Phone_number == "")
            {
                return "requeid_Phonenumber";
            }
            if(userSignUp.Pwd != userSignUp.PwdAccess)
            {
                return "Xác nhận mật khẩu không trùng với mật khẩu";
            }
            if(userSignUp.Email != "" && !IsValidEmail(userSignUp.Email))
            {
                return "Định dạng email không chính xác";
            }
            if(userSignUp.Real_name != "" && !IsValidName(userSignUp.Real_name))
            {
                return "Định dạng họ và tên không chính xác";
            }
            if(userSignUp.DoB > DateTime.Now)
            {
                return "Ngày sinh không thể là ngày mai";
            }
            if(userSignUp.Phone_number != "" && !IsValidPhone(userSignUp.Phone_number))
            {
                return "Số điện thoại không đúng định dạng";
            }
            if(userSignUp.CCCD != "" && !IsValidCCCD(userSignUp.CCCD))
            {
                return "CCCD không đúng định dạng";
            }
            

            string info = usSignUpAccess.CheckSignUp(userSignUp);
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
