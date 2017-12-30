using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class ProfileReader : ProfileData
    {
        private string profilesLocation;

        public ProfileReader() : base()
        {
            profilesLocation = etsDataFolder + @"profiles\";
        }

        //GET PROFILES
        public List<object> GetProfiles()
        {
            List<object> profiles = new List<object>();
            foreach (string dir in Directory.GetDirectories(profilesLocation))
            {
                if (File.Exists(dir + @"\profile.sii"))
                {
                    DecryptSii(dir + @"\profile.sii");
                    StreamReader sr = new StreamReader(dir + @"\profile.sii");
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.Contains(" profile_name: "))
                        {
                            line = line.Replace(" profile_name: ", "");
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
                if (currentProfileLocation != "")
                {
                    currentQuicksaveLocation = currentProfileLocation + @"\save\quicksave\";
                    currentAutosaveLocation = currentProfileLocation + @"\save\autosave\game.sii";
                    currentProfileLocation = currentProfileLocation + @"\profile.sii";
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
                        if (line == profileName)
                        {
                            currentProfileLocation = dir;
                            break;
                        }
                    }
                }
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
