using System;
using System.Drawing;
using System.Windows.Forms;

namespace gh3texview
{
    public partial class wifi : Form
    {
        public wifi()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            object A = Properties.Resources.ResourceManager.GetObject(trackBar1.Value.ToString()+"1");
            wifi_bar.Image = (Image)A;
        }
    }
}
