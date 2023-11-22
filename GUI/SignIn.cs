using BLL;
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
        private string email, password;
        private UserBLL userBLL;
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aIRBOOKDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.aIRBOOKDataSet.users);

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aIRBOOKDataSet);

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            password = txtPassword.Text;
        }
    }
}
