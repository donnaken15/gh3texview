using System;
using System.Drawing;
using System.Windows.Forms;

namespace gh3texview
{
    public partial class gui_battery : Form
    {
        public gui_battery()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                object O = Properties.Resources.ResourceManager.GetObject("base_charging");
                spr_battery.Image = (Image)O;
            }
            else
            {
                object N = Properties.Resources.ResourceManager.GetObject("base");
                spr_battery.Image = (Image)N;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            object A = Properties.Resources.ResourceManager.GetObject(trackBar1.Value.ToString());
            spr_battery.BackgroundImage = (Image)A;
        }
    }
}
