using System.IO;
using System.Windows.Forms;

namespace gh3texview
{
    public partial class gh3 : Form
    {
        public gh3()
        {
            InitializeComponent();
        }

        private void menu_battery_Click(object sender, System.EventArgs e)
        {
            gui_battery batry = new gui_battery();
            batry.ShowDialog();
        }

        private void menu_wifi_Click(object sender, System.EventArgs e)
        {
            wifi wifimeter = new wifi();
            wifimeter.ShowDialog();
        }

        private void menu_rock_Click(object sender, System.EventArgs e)
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            System.Diagnostics.Process.Start(wanted_path+"/rockmeter.exe","");
        }

        private void menu_score_Click(object sender, System.EventArgs e)
        {
            scoremeter score = new scoremeter();
            score.ShowDialog();
        }

        private void menu_dd_Click(object sender, System.EventArgs e)
        {

        }

        private void menu_ddmeter_Click(object sender, System.EventArgs e)
        {
            ddmeter deathmeter = new ddmeter();
            deathmeter.Show();
        }
    }
}
