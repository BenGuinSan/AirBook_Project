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
        User user = new User();
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
    }
}
