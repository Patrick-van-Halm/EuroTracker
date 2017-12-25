﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tools
{
    public class SavegameReader
    {
        private string profilesLocation;
        private string currentSaveGameLocation = "";
        Timer loadInterval;

        private int playerEXP;
        private int playerMoney;

        public SavegameReader()
        {
            profilesLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Euro Truck Simulator 2\profiles\";
        }

        private void LoadProfileData(object sender, EventArgs e)
        {
            playerEXP = GetEXP();
            playerMoney = GetMoneyFromSave();
        }

        private string GetSavedValue(string location, string key)
        {
            if (File.Exists(location))
            {
                DecryptSii(location);
                StreamReader sr = new StreamReader(location);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Contains(key))
                    {
                        line = line.Replace(key, "");
                        return line;
                    }
                }
            }
            return "";
        }

        private int GetEXP()
        {
            string fileLocation = currentSaveGameLocation + @"\profile.sii";
            string expString = GetSavedValue(fileLocation, " cached_experience: ");
            int exp = 0;
            int.TryParse(expString, out exp);
            return exp;
        }

        private int GetMoneyFromSave()
        {
            string fileLocation = currentSaveGameLocation + @"\save\autosave\game.sii";
            string moneyString = GetSavedValue(fileLocation, " money_account: ");
            int money = 0;
            int.TryParse(moneyString, out money);
            return money;
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
        
        public List<object> GetProfiles()
        {
            List<object> profiles = new List<object>();
            foreach (string dir in Directory.GetDirectories(profilesLocation))
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
            return profiles;
        }

        public void LoadProfile(string profileName)
        {
            foreach (string dir in Directory.GetDirectories(profilesLocation))
            {
                if (currentSaveGameLocation != "")
                {
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
                        if(line == profileName)
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

        public int GetPlayerEXP()
        {
            return playerEXP;
        }
    }
}