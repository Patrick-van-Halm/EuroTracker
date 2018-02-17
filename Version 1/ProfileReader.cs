using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Version_1;

namespace Tools
{
    public class ProfileReader : ProfileData
    {
        private string profilesLocation;

        public ProfileReader(frmProfileSelector frm) : base()
        {
            frmProfileSelector frmProfile = frm;
            profilesLocation = etsDataFolder + @"profiles\";

            if(File.Exists(etsDataFolder + @"config.cfg"))
            {
                int i = 0;
                bool valueChanged = false;
                bool valueExists = false;
                string[] lines = File.ReadAllLines(etsDataFolder + "config.cfg");

                foreach(string line in lines)
                {
                    if(line.Contains("uset g_save_format "))
                    {
                        valueExists = true;
                        if(line != "uset g_save_format \"2\"")
                        {
                            valueChanged = true;
                            lines[i] = "uset g_save_format \"2\"";
                        }
                    }
                    i++;
                }

                if (!valueExists && !valueChanged)
                {
                    string[] newconfig = new string[lines.Length + 1];
                    i = 0;
                    foreach(string line in lines)
                    {
                        newconfig[i] = line;
                        i++;
                    }
                    newconfig[newconfig.Length -1] = "uset g_save_format \"2\"";
                    File.Delete(etsDataFolder + "config.cfg");
                    StreamWriter sw = new StreamWriter(etsDataFolder + "config.cfg");
                    foreach(string cfgLine in newconfig)
                    {
                        sw.WriteLine(cfgLine);
                    }
                    sw.Close();
                    valueChanged = true;
                }
                else
                {
                    File.Delete(etsDataFolder + "config.cfg");
                    StreamWriter sw = new StreamWriter(etsDataFolder + "config.cfg");
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                }

                if (valueExists && valueChanged)
                {
                    MessageBox.Show(frmProfile, "Please Restart ETS 2 and relaunch EuroTracker!\nWe Initialized ETS 2 for first use!");
                    frmProfile.Close();
                }
            }
        }

        //GET PROFILES
        public List<string> GetProfiles()
        {
            List<string> profiles = new List<string>();
            List<string> profileFile = new List<string>();

            foreach (string dir in Directory.GetDirectories(profilesLocation))
            {
                bool profileInserted = false;
                string profile = dir + @"\profile.sii";
                if (File.Exists(profile))
                {
                    if(profileFile.Count > 0)
                    {
                        for(int i = 0; i < profileFile.Count; i++)
                        {
                            if(File.GetLastWriteTime(profileFile[i]) < File.GetLastWriteTime(profile))
                            {
                                profileFile.Insert(i, profile);
                                profileInserted = true;
                                break;
                            }
                        }
                        if (!profileInserted)
                            profileFile.Add(profile);
                    }
                    else
                    {
                        profileFile.Add(profile);
                    }
                }
            }

            foreach (string profile in profileFile)
            {
                if (File.Exists(profile))
                {
                    DecryptSii(profile);
                    StreamReader sr = new StreamReader(profile);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.Contains(" profile_name: "))
                        {
                            line = line.Replace(" profile_name: ", "").Replace("\"", "");
                            profiles.Add(line);
                        }
                    }
                }
            }
            return profiles;
        }

        public void LoadProfile(string profileName)
        {
            foreach (string dir in Directory.GetDirectories(profilesLocation))
            {

                DecryptSii(dir + @"\profile.sii");
                StreamReader sr = new StreamReader(dir + @"\profile.sii");
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Contains(" profile_name: "))
                    {
                        line = line.Replace(" profile_name: ", "").Replace("\"", "");
                        if (line == profileName)
                        {
                            currentProfileLocation = dir;
                            break;
                        }
                    }
                }
            }
            if (currentProfileLocation != "")
            {
                currentQuicksaveLocation = currentProfileLocation + @"\save\quicksave\";
                currentAutosaveLocation = currentProfileLocation + @"\save\autosave\game.sii";
                currentProfileLocation = currentProfileLocation + @"\profile.sii";
            }
        }

        //GET DATA
        private void GetEXP()
        {
            string expString = GetSavedValue(currentProfileLocation, " cached_experience: ");
            int exp = 0;
            int.TryParse(expString, out exp);
            playerEXP = exp;
        }
        
    }
}
