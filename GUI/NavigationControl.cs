using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal class NavigationControl
    {
        Dictionary<ConstantDefine.siteName, UserControl> userControls = new Dictionary<ConstantDefine.siteName, UserControl>();
        Panel panelContext;

        public NavigationControl(Dictionary<ConstantDefine.siteName, UserControl> userControls, Panel panelContext)
        {
            this.userControls = userControls;
            this.panelContext = panelContext;
            AddUserControlsToPanel();
        }

        private void AddUserControlsToPanel()
        {
            foreach (var item in userControls)
            {
                item.Value.Dock = DockStyle.Fill;
                panelContext.Controls.Add(item.Value);
            }
        }

        public void Display(ConstantDefine.siteName userControl)
        {
            if (userControls.ContainsKey(userControl))
            {
                userControls[userControl].BringToFront(); // display only the selected UserControl using index
            }
        }

        public void Add(ConstantDefine.siteName userControlName, UserControl userControl)
        {
            userControls.Add(userControlName, userControl);
            userControl.Dock = DockStyle.Fill;
            panelContext.Controls.Add(userControl);
        }
    }
}
