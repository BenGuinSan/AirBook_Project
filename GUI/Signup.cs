using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Signup : Form
    {
        private UserCreateBLL userCreateBLL = new UserCreateBLL();
        private UserSignUp userSignUp = new UserSignUp();

        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            userSignUp.Real_name = txtRealname.Text;
            userSignUp.Gender = selectedGender.Text;
            userSignUp.DoB = selectedDoB.Value;
            userSignUp.CCCD = txtCCCD.Text;
            userSignUp.Nation = txtNation.Text;
            userSignUp.User_address = txtAddress.Text;
            userSignUp.Phone_number = txtPhone.Text;
            userSignUp.Email = txtEmail.Text;
            userSignUp.Pwd = txtPwD.Text;
            userSignUp.PwdAccess = txtConfirmPwD.Text;
            userSignUp.Username = txtUsername.Text;

            string getUserSignUp = userCreateBLL.checkSignUP(userSignUp);
            switch (getUserSignUp)
            {
                case "requeid_Realname":
                    MessageBox.Show("Không được bỏ trống họ và tên");
                    return;
                case "requeid_CCCD":
                    MessageBox.Show("Không được bỏ trống CCCD");
                    return;
                case "requeid_Nation":
                    MessageBox.Show("Không được bỏ trống Quốc Gia");
                    return;
                case "requeid_UserAddress":
                    MessageBox.Show("Không được bỏ trống địa chỉ");
                    return;
                case "requeid_Phonenumber":
                    MessageBox.Show("Không được bỏ trống số điện thoại");
                    return;
                case "requeid_Email":
                    MessageBox.Show("Không được bỏ trống email");
                    return;
                case "requeid_Pwd":
                    MessageBox.Show("Không được bỏ trống mật khẩu");
                    return;
                case "Pasword_has_space":
                    MessageBox.Show("Mật khẩu dùng để đăng ký không được chứa khoảng trắng");
                    return;
                case "requeid_PwdAccess":
                    MessageBox.Show("Không được bỏ trống xác nhận mật khẩu");
                    return;
                case "Xác nhận mật khẩu không trùng với mật khẩu":
                    MessageBox.Show("Xác nhận mật khẩu không trùng với mật khẩu");
                    return;
                case "Định dạng email không chính xác":
                    MessageBox.Show("Định dạng email không chính xác");
                    return;
                case "Định dạng họ và tên không chính xác":
                    MessageBox.Show("Định dạng họ và tên không chính xác");
                    return;
                case "Ngày sinh không thể là ngày mai":
                    MessageBox.Show("Ngày sinh không thể là ngày mai");
                    return;
                case "Số điện thoại không đúng định dạng":
                    MessageBox.Show("Số điện thoai không đúng định dạng");
                    return;
                case "CCCD không đúng định dạng":
                    MessageBox.Show("CCCD không đúng định dạng");
                    return;

            }
            MessageBox.Show("Đăng ký thành công");
            txtRealname.Text = "";
            selectedGender.Text = "";
            txtCCCD.Text = "";
            txtNation.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtPwD.Text = "";
            txtConfirmPwD.Text = "";
            txtUsername.Text = "";
        }

        private void btnDNBack_Click(object sender, EventArgs e)
        {
           SignIn signIn = new SignIn();
           signIn.Show();
           this.Hide();
        }
    }
}
