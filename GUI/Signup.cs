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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aIRBOOKDataSet.actions' table. You can move, or remove it, as needed.
            this.actionsTableAdapter.Fill(this.aIRBOOKDataSet.actions);
            // TODO: This line of code loads data into the 'airbookDataSet1.airlines' table. You can move, or remove it, as needed.
            this.airlinesTableAdapter.Fill(this.airbookDataSet1.airlines);

        }
    }
}
