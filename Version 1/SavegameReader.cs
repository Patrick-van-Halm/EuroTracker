using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Version_1
{
    class SavegameReader
    {
        private string savegameLocation;

        public SavegameReader()
        {
            savegameLocation = ProfileLocator();
        }

        private string ProfileLocator()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "config.cfg"))
            {
                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "config.cfg");
                string savelocation = sr.ReadLine().Split('"')[1];
                if (Directory.Exists(savelocation))
                {
                    return savelocation;
                }
                else
                {
                    return ProfileSelector();
                }
            }
            else
            {
                return ProfileSelector();
            }
        }

        private string ProfileSelector()
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Select the ETS2/ATS Main Profile Location";
            do
            {
                fb.ShowDialog();
                if (!File.Exists(fb.SelectedPath + @"\profile.sii"))
                {
                    MessageBox.Show(new Form { TopMost = true }, "Wrong Path Selected!\nSelect The Path To Your Profile", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            while (!File.Exists(fb.SelectedPath + @"\profile.sii"));
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "config.cfg", false);
            sw.WriteLine($"SavegameLocation=\"{fb.SelectedPath}\"");
            sw.Close();
            return fb.SelectedPath;
        }


        //Form savegame location selector
        //Savegame decryt
        //Savegame read from line



    }
}
