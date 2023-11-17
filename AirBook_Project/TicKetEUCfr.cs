using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBook_Project
{
    public partial class TicKetEUCfr : Form
    {
        Button currentBtn = null;
        public TicKetEUCfr()
        {
            InitializeComponent();
        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            btnMyVe.BackColor = Color.FromArgb(1, 138, 165);
            btnKM.BackColor = Color.FromArgb(1, 138, 165);
            btnTK.BackColor = Color.FromArgb(1, 138, 165);

            btnMuaVe.BackColor = Color.FromArgb(1, 104, 124);
        }

        private void btnMyVe_Click(object sender, EventArgs e)
        {
            btnMuaVe.BackColor = Color.FromArgb(1, 138, 165);
            btnKM.BackColor = Color.FromArgb(1, 138, 165);
            btnTK.BackColor = Color.FromArgb(1, 138, 165);

            btnMyVe.BackColor = Color.FromArgb(1, 104, 124);
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            btnMuaVe.BackColor = Color.FromArgb(1, 138, 165);
            btnMyVe.BackColor = Color.FromArgb(1, 138, 165);
            btnTK.BackColor = Color.FromArgb(1, 138, 165);

            btnKM.BackColor = Color.FromArgb(1, 104, 124);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            btnMuaVe.BackColor = Color.FromArgb(1, 138, 165);
            btnMyVe.BackColor = Color.FromArgb(1, 138, 165);
            btnKM.BackColor = Color.FromArgb(1, 138, 165);

            btnTK.BackColor = Color.FromArgb(1, 104, 124);
        }
    }
}
