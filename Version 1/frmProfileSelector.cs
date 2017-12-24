using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace Version_1
{
    public partial class frmProfileSelector : Form
    {
        SavegameReader saves = new SavegameReader();
        public frmProfileSelector()
        {
            InitializeComponent();
        }

        private void FrmProfileSelector_Load(object sender, EventArgs e)
        {
            listboxProfiles.Items.AddRange(saves.GetProfiles().ToArray());
        }

        public SavegameReader GetSavegameReader()
        {
            return saves;
        }

        private void ListboxProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            saves.LoadProfile(listboxProfiles.SelectedItem.ToString());
            if(saves.GetSaveLocation() != "")
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
