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
    public partial class AdminFrm : KryptonForm
    {
        private NavigationControl navigationControl;
        private void InitializeNavControl()
        {
            Dictionary<ConstantDefine.siteName, UserControl> navControls = new Dictionary<ConstantDefine.siteName, UserControl>()
            {
                {ConstantDefine.siteName.STATISTIC_AD, new AdminGUI.Statistic()},
                {ConstantDefine.siteName.TICKET_AD, new AdminGUI.Ticket()},
                {ConstantDefine.siteName.PROMO_AD, new AdminGUI.Promo()},
                {ConstantDefine.siteName.FLIGHT_AD, new AdminGUI.Flight()},
                {ConstantDefine.siteName.AIRLINE_AD, new AdminGUI.Airline()},
                {ConstantDefine.siteName.AIRLINE_PLANE_AD, new AdminGUI.AirlinePlane()},
                {ConstantDefine.siteName.AIRPORT_AD, new AdminGUI.Airport()},
                {ConstantDefine.siteName.ACCOUNT_AD, new AdminGUI.Account()},
                {ConstantDefine.siteName.ACCOUNT_AUTH_AD, new AdminGUI.AccountAuth()},
                {ConstantDefine.siteName.FEATURE_AD, new AdminGUI.Feature()}
            };

            navigationControl = new NavigationControl(navControls, panelMainBody); // create an instance of NavigationControl class
            navigationControl.Display(ConstantDefine.siteName.STATISTIC_AD); // display UserControl1 as default
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.STATISTIC_AD];
        }
        public AdminFrm()
        {
            InitializeComponent();
            InitializeNavControl();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void navStatistic_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.STATISTIC_AD);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.STATISTIC_AD];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.STATISTIC_AD];
        }

        private void navTicket_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.TICKET_AD);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.TICKET_AD];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.TICKET_AD];
        }

        private void navPromo_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.PROMO_AD);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.PROMO_AD];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.PROMO_AD];
        }

        private void navFlight_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.FLIGHT_AD);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.FLIGHT_AD];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.FLIGHT_AD];
        }

        private void navAirline_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.AIRLINE_AD);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.AIRLINE_AD];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.AIRLINE_AD];
        }

        private void navAirport_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.AIRPORT_AD);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.AIRPORT_AD];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.AIRPORT_AD];
        }

        private void navAccount_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.ACCOUNT_AD);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.ACCOUNT_AD];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.ACCOUNT_AD];
        }

        private void navFeature_Click(object sender, EventArgs e)
        {
            navigationControl.Display(ConstantDefine.siteName.FEATURE_AD);
            this.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.FEATURE_AD];
            txtFormTitle.Text = ConstantDefine.siteNameDict[ConstantDefine.siteName.FEATURE_AD];
        }
    }
}
