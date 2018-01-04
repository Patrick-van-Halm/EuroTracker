using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public class Data
    {
        protected string etsDataFolder;
        protected string currentProfileLocation;
        protected string currentAutosaveLocation;
        protected string currentQuicksaveLocation;

        //CONSTRUCTOR
        public Data()
        {
            etsDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Euro Truck Simulator 2\";
            currentProfileLocation = "";
            currentAutosaveLocation = "";
        }

        //METHODS
        protected void DecryptSii(string dir)
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
            else
            {
                MessageBox.Show(new Form { TopMost = true }, "'SII_Decrypt.exe' Does not exist.\nPlease try reinstalling this software!", "ERROR!");
            }
        }

        public string CapitalizeString(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        public string CapitalizeString(string[] str)
        {
            if (str == null)
                return null;

            string returnString = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > 1)
                    returnString = returnString + char.ToUpper(str[i][0]) + str[i].Substring(1) + " ";
            }

            return returnString;
        }

        protected string GetSavedValue(string location, string key)
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

        //GETTERS
        public string GetEtsDataFolder()
        {
            return etsDataFolder;
        }

        public string GetProfileLocation()
        {
            return currentProfileLocation;
        }

        public string GetAutosaveLocation()
        {
            return currentAutosaveLocation;
        }

        public string GetQuicksaveLocation()
        {
            return currentQuicksaveLocation;
        }
    }
}
