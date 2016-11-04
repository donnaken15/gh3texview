using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gh3texview
{
    public partial class scoremeter : Form
    {
        public scoremeter()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            int combo = Convert.ToInt32(streak.Value);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();
        }

        private void multi_ValueChanged(object sender, EventArgs e)
        {
            object A = Properties.Resources.ResourceManager.GetObject("icon");
            object B = Properties.Resources.ResourceManager.GetObject("icon2");
            object C = Properties.Resources.ResourceManager.GetObject("icon3");
            object D = Properties.Resources.ResourceManager.GetObject("icon1");
            if (multi.Value == 1)
            { pictureBox1.BackgroundImage = (Image)A; }
            if (multi.Value == 2)
            { pictureBox1.BackgroundImage = (Image)B; }
            if (multi.Value == 3)
            { pictureBox1.BackgroundImage = (Image)C; }
            if (multi.Value == 4)
            { pictureBox1.BackgroundImage = (Image)D; }

        }

        private void streak_ValueChanged(object sender, EventArgs e)
        {
            int combo = Convert.ToInt32(streak.Value);
        }
    }
}
