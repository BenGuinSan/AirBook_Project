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
    public partial class TicKetEUCfr : KryptonForm
    {
   
        public TicKetEUCfr()
        {
            InitializeComponent();
            btnMuaVe.BackColor = Color.FromArgb(1, 104, 124);
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

        private void TicKetEUCfr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aIRBOOKDataSet.airports' table. You can move, or remove it, as needed.
            this.airportsTableAdapter.Fill(this.aIRBOOKDataSet.airports);
            // TODO: This line of code loads data into the 'aIRBOOKDataSet.flights' table. You can move, or remove it, as needed.
            this.flightsTableAdapter.Fill(this.aIRBOOKDataSet.flights);

        }

        private void flightsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.flightsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aIRBOOKDataSet);

        }
    }
}
