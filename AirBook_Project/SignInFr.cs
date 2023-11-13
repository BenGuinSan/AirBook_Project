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
    public partial class SignInFr : KryptonForm
    {
        User user = new User();
        UserBLL userBLL = new UserBLL();
        int mov;
        int movX;
        int movY;

        public SignInFr()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;

        }

        private void kryptonPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void kryptonPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.DarkGray;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void btnMini_MouseHover(object sender, EventArgs e)
        {
           btnMini.ForeColor = Color.DarkGray;
        }

        private void btnMini_MouseLeave(object sender, EventArgs e)
        {
            btnMini.ForeColor = Color.White;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            user.Email = txtEmail.Text;
            user.Pwd = txtPW.Text;

            string getUser = userBLL.checkLogin(user);

            // The hien tra lai ket qua neu dieu kien login khong dung;
            switch (getUser)
            {
                case "requeid_Email":
                    MessageBox.Show("Email không được bỏ trống");
                    return;
                case "requeid_PW":
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                    return;
                case "Email hoặc mật khẩu không chỉnh xác!":
                    MessageBox.Show("Email hoặc mật khẩu không chính xác");
                    return;
                case "Pasword_has_space":
                    MessageBox.Show("Email hoặc mật khẩu không chính xác");
                    return;
            }

            MessageBox.Show("Đăng nhập thành công");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            new SignUpFr().Show();
            this.Hide();

        }
    }
}
