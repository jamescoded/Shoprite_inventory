using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryStock
{
    public class Navigator
    {
        List<UserControl>formUserControls=new List<UserControl>();
        Panel panel;

        public Navigator(List<UserControl> formUserControls, Panel panel)
        {
            this.formUserControls = formUserControls;
            this.panel = panel;
        }

        public void addcontrol()
        {
            for (int i = 0; i < formUserControls.Count; i++)
            {
                formUserControls[i].Dock=DockStyle.Fill;
                panel.Controls.Add(formUserControls[i]);

            }
        }

        public void Display(int index)
        {
            if (index < formUserControls.Count())
            {
                formUserControls[index].BringToFront();
            }
        }
    }
}
