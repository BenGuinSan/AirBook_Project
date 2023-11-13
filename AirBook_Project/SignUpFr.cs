using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using BLL;

namespace AirBook_Project
{
    public partial class SignUpFr : KryptonForm
    {
        UserCreate userCreate = new UserCreate();
        UserCreateBLL userCreateBLL = new UserCreateBLL();
        int mov;
        int movX;
        int movY;

        public SignUpFr()
        {
            InitializeComponent();
        }

        private void SignUpFr_Load(object sender, EventArgs e)
        {

        }

        private void btnPrePage_MouseHover(object sender, EventArgs e)
        {
            btnPrePage.ForeColor = Color.DarkGray;
        }

        private void btnPrePage_MouseLeave(object sender, EventArgs e)
        {
            btnPrePage.ForeColor = Color.White;
        }

        private void kryptonPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void kryptonPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void kryptonPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMini_MouseHover(object sender, EventArgs e)
        {
            btnMini.ForeColor = Color.DarkGray;
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            btnMini.ForeColor = Color.White;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.DarkGray;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void btnCreateUsers_Click(object sender, EventArgs e)
        {
            userCreate.Email = txtEmail.Text;
            userCreate.Pwd = txtPW.Text;
            userCreate.PwdAccsess = txtPWCF.Text;
            userCreate.Real_name = txtName.Text;
            userCreate.DoB = timePick.Value;
            userCreate.Gender = genderSelect.Text;
            userCreate.CCCD = txtID.Text;
            userCreate.User_address = txtAddress.Text;
            userCreate.Nation = txtNation.Text;
            userCreate.Phone_number = txtPhone.Text;

            
            string getUserCreate = userCreateBLL.checkSignUP(userCreate);

            switch (getUserCreate)
            {
                case "requeid_Email":
                    MessageBox.Show("Email không được bỏ trống");
                    return;
                case "requeid_Pwd":
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                    return;
                case "Email hoặc mật khẩu không chỉnh xác!":
                    MessageBox.Show("Email hoặc mật khẩu không chính xác");
                    return;
                case "Pasword_has_space":
                    MessageBox.Show("Mật khẩu không được chứa ký tự khoảng trắng");
                    return;
                case "requeid_PwdAccess":
                    MessageBox.Show("Xác nhận mật khẩu không được bỏ trống");
                    return;
                case "requeid_Realname":
                    MessageBox.Show("Họ và tên không được bỏ trống");
                    return;
                case "requeid_CCCD":
                    MessageBox.Show("Căn cước công dân không được bỏ trống");
                    return;
                case "requeid_Nation":
                    MessageBox.Show("Quốc gia không được bỏ trống");
                    return;
                case "requeid_UserAddress":
                    MessageBox.Show("Địa chỉ không được bỏ trống");
                    return;
                case "requeid_Phonenumber":
                    MessageBox.Show("Số điện thoại không được bỏ trống");
                    return;
                case "Email đã tồn tại":
                    MessageBox.Show("Email đã tồn tại");
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
                    MessageBox.Show("Số điện thoại không đúng định dạng");
                    return;
                case "CCCD không đúng định dạng":
                    MessageBox.Show("CCCD không đúng định dạng");
                    return;
            }

            txtEmail.Text = "";
            txtPW.Text = "";
            txtPWCF.Text = "";
            txtName.Text = "";
            txtID.Text = "";
            txtAddress.Text = "";
            txtNation.Text = "";
            txtPhone.Text = "";

            MessageBox.Show("Đăng ký thành công");
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            new SignInFr().Show();
            this.Hide();
        }
    }
}
