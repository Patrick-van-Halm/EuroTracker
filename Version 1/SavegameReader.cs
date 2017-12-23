using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Version_1
{
    class SavegameReader
    {
        frmEuroTracker tracker;

        Form savegameSelectorForm;
        ListBox savegames;


        private string profilesLocation;
        private string currentSaveGameLocation = "";
        Timer loadInterval;        
        
        private int playerMoney;

        public SavegameReader(frmEuroTracker tracker)
        {
            this.tracker = tracker;
            profilesLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Euro Truck Simulator 2\profiles\";
            SaveGameLocator();
        }

        private void LoadProfileData(object sender, EventArgs e)
        {
            DecryptSii(currentSaveGameLocation + @"\profile.sii");
            GetEXP();

            DecryptSii(currentSaveGameLocation + @"\save\autosave\game.sii");
            playerMoney = GetMoney();
        }

        private void GetEXP()
        {

        }

        private int GetMoney()
        {
            string fileLocation = currentSaveGameLocation + @"\save\autosave\game.sii";
            if (File.Exists(fileLocation))
            {
                StreamReader sr = new StreamReader(fileLocation);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Contains("money_account: "))
                    {
                        int money = 0;
                        line = line.Replace("money_account: ", "");
                        line = line.Replace(" ", "");

                        int.TryParse(line, out money);
                        return money;
                    }
                }
            }
            return 0;
        }
        
        private void DecryptSii(string dir)
        {
            string path = dir;
            if (File.Exists("SII_Decrypt.exe"))
            {
                if (File.Exists(path))
                {
                    Process p = new Process();
                    p.StartInfo.FileName = "SII_Decrypt.exe";
                    p.StartInfo.Arguments = " \"" + path + "\"";
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.UseShellExecute = false;
                    p.Start();
                    p.WaitForExit();
                }
            }
        }

        









        //private string ProfileLocator()
        //{
        //    if (File.Exists(Directory.GetCurrentDirectory() + "config.cfg"))
        //    {
        //        StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "config.cfg");
        //        string profilesLocation = sr.ReadLine().Split('"')[1];
        //        if (Directory.Exists(profilesLocation))
        //        {
        //            return profilesLocation;
        //        }
        //        else
        //        {
        //            return ProfileSelector();
        //        }
        //    }
        //    else
        //    {
        //        return ProfileSelector();
        //    }
        //}

        //private string ProfileSelector()
        //{
        //    bool profilesFolderIsCorrect = false;
        //    FolderBrowserDialog fb = new FolderBrowserDialog();
        //    fb.Description = "Select the ETS2/ATS Profiles Folder";
        //    do
        //    {
        //        fb.ShowDialog();
        //        foreach (string dir in Directory.GetDirectories(fb.SelectedPath))
        //        {
        //            if(File.Exists(dir + @"\profile.sii"))
        //            {
        //                profilesFolderIsCorrect = true;
        //            }
        //        }
        //        if (!profilesFolderIsCorrect)
        //        {
        //            MessageBox.Show(new Form { TopMost = true }, "Wrong Path Selected!\nSelect The Path To The Profiles Folder", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }
        //    while (!profilesFolderIsCorrect);
        //    StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "config.cfg", false);
        //    sw.WriteLine($"SavegameLocation=\"{fb.SelectedPath}\"");
        //    sw.Close();
        //    return fb.SelectedPath;
        //}

        private void SaveGameLocator()
        {
            savegameSelectorForm = new Form();
            savegames = new ListBox();
            savegames.Width = savegameSelectorForm.Width;
            savegames.Height = savegameSelectorForm.Height;
            savegames.MouseDoubleClick += loadProfile;
            savegameSelectorForm.Controls.Add(savegames);
            savegameSelectorForm.Show();

            foreach(string dir in Directory.GetDirectories(profilesLocation))
            {
                DecryptSii(dir + @"\profile.sii");
                StreamReader sr = new StreamReader(dir + @"\profile.sii");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Contains(" profile_name: "))
                    {
                        line = line.Replace(" profile_name: ", "");
                        savegames.Items.Add(line);
                    }
                }
            }
        }

        private void loadProfile(object sender, MouseEventArgs e)
        {
            foreach (string dir in Directory.GetDirectories(profilesLocation))
            {
                if (currentSaveGameLocation != "")
                {
                    tracker.Show();
                    savegameSelectorForm.Close();
                    LoadProfileData(null, null);
                    loadInterval = new Timer();
                    loadInterval.Interval = 30000;
                    loadInterval.Enabled = true;
                    loadInterval.Tick += LoadProfileData;
                    break;
                }
                    
                DecryptSii(dir + @"\profile.sii");
                StreamReader sr = new StreamReader(dir + @"\profile.sii");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Contains(" profile_name: "))
                    {
                        line = line.Replace(" profile_name: ", "");
                        if(savegames.SelectedItem.ToString() == line)
                        {
                            currentSaveGameLocation = dir;
                            break;
                        }
                    }
                }
            }
        }

        public string GetSaveLocation()
        {
            return currentSaveGameLocation;
        }

        public int GetPlayerMoney()
        {
            return playerMoney;
        }
    }
}
