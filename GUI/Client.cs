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
    public partial class ClientFrm : KryptonForm
    {
        private NavigationControl navigationControl;
        private void InitializeNavControl()
        {
            Dictionary<ConstantDefine.siteName, UserControl> navControls = new Dictionary<ConstantDefine.siteName, UserControl>()
            {
                {ConstantDefine.siteName.BUY_TICKET_EUC, new ClientGUI.BuyTicket()},
                {ConstantDefine.siteName.PROMO_EUC, new ClientGUI.Promo()},
                {ConstantDefine.siteName.ACCOUNT_EUC, new ClientGUI.Account()},
                {ConstantDefine.siteName.MYTICKET_EUC, new ClientGUI.MyTicket()}
            };

            navigationControl = new NavigationControl(navControls, panelMainBody); // create an instance of NavigationControl class
            navigationControl.Display(ConstantDefine.siteName.BUY_TICKET_EUC); // display UserControl1 as default
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.BUY_TICKET_EUC];
        }
        public ClientFrm()
        {
            InitializeComponent();
            InitializeNavControl();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void navBuyTicket_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.BUY_TICKET_EUC);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.BUY_TICKET_EUC];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.BUY_TICKET_EUC];
        }

        private void navMyTicket_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.MYTICKET_EUC);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.MYTICKET_EUC];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.MYTICKET_EUC];
        }

        private void navPromo_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.PROMO_EUC);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.PROMO_EUC];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.PROMO_EUC];
        }

        private void navAccount_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.ACCOUNT_EUC);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.ACCOUNT_EUC];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.ACCOUNT_EUC];
        }

        private void navSignout_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }
    }
}
