using System;
using System.Windows.Forms;

namespace gh3texview
{
    public partial class ddmeter : Form
    {
        public ddmeter()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Convert.ToInt32(pictureBox2.Location.Y.Equals(vScrollBar1.Value));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox2.Location.Y.Equals(vScrollBar1.Value);
        }
    }
}
