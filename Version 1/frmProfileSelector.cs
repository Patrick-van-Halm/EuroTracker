using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace Version_1
{
    public partial class frmProfileSelector : Form
    {
        ProfileReader profile = new ProfileReader();
        public frmProfileSelector()
        {
            InitializeComponent();
        }

        private void FrmProfileSelector_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("eurotrucks2.exe").Length == 0)
            {
                MessageBox.Show("Run Euro Truck Simulator 2 before opening Euro Tracker!", "ERROR!");
                this.Close();
            }

            listboxProfiles.Items.AddRange(profile.GetProfiles().ToArray());
        }

        public ProfileReader GetProfileReader()
        {
            return profile;
        }

        private void ListboxProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            profile.LoadProfile(listboxProfiles.SelectedItem.ToString());
            if(profile.GetProfileLocation() != "")
            {
                frmEuroTracker tracker = new frmEuroTracker(this);
                tracker.Show();
                this.Hide();
            }
        }

        private void ListboxProfiles_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ListboxProfiles_MouseDoubleClick(sender, null);
            }
        }
    }
}
