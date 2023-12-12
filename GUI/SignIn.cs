using BLL;
using DTO;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SignIn : KryptonForm
    {
        
        UserBLL userBLL = new UserBLL();
        User user = new User();
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            user.Email = txtEmail.Text;
            user.Pwd = txtPassword.Text;

            string getuser = userBLL.checkLogin(user);
            switch (getuser)
            {
                case "requeid_Email":
                    MessageBox.Show("Email không được bỏ trống");
                    return;
                case "requeid_PW":
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                    return;
                case "Email hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Email hoặc mật khẩu không chỉnh xác");
                    return;          
                case "Pasword_has_space":
                    MessageBox.Show("Mật khẩu không được chứa ký tự khoảng trắng");
                    return;
                case "admin":
                    MessageBox.Show("Đăng nhập thành công");
                    AdminFrm adminFrm = new AdminFrm();
                    adminFrm.Show();
                    this.Hide();
                    return;
                case "user":
                    MessageBox.Show("Đăng nhập thành công");
                    ClientFrm clientFrm = new ClientFrm();
                    clientFrm.Show();
                    this.Hide();
                    return;
            }
    
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
