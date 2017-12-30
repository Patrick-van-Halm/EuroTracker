using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class SaveWriter : SaveData
    {
        public SaveWriter(string autosave)
        {
            currentAutosaveLocation = autosave;
        }

        public void CreateJob(string source, string cargo, string company_truck, string target, int distance = 1500)
        {
            string location = CreateNewSave(cargo + " to " + target);
            DecryptSii(location + "game.sii");
            List<string> lines = File.ReadAllLines(location + "game.sii").ToList();
            StreamWriter sw = new StreamWriter(location + "game.sii");
            for (int i = 0; i < lines.Count; i++)
            {
                if(lines[i].Contains("company : company.volatile." + source))
                {
                    string offerId = lines[i + 5].Replace(" job_offer[0]: ", "");
                    int j = i;
                    while(!lines[j].Contains(" discovered: "))
                    {
                        j++;
                    }
                    lines[j] = " discovered: true";


                    while (lines[j] != "job_offer_data : " + offerId + " {")
                    {
                        j++;
                    }

                    lines[j + 1] = " cargo: " + cargo;
                    lines[j + 2] = " company_truck: " + company_truck;
                    lines[j + 3] = " variant: 0";
                    lines[j + 4] = " target: \"" + target + "\"";
                    //lines[j + 5] = " expiration_time: 6913416765";
                    lines[j + 6] = " urgency: 0";
                    lines[j + 7] = " shortest_distance_km: " + distance;
                    lines[j + 8] = " ferry_time: 0";
                    lines[j + 9] = " ferry_price: 0";
                    lines[j + 10] = " trailer_place: 0";
                }
            }

            foreach(string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();
        }

        private string CreateNewSave(string savename)
        {
            string newSave = currentAutosaveLocation.Replace(@"autosave\game.sii", "") + $"customJob\\";
            Directory.CreateDirectory(newSave);
            File.Copy("preview.mat", newSave + "preview.mat", true);
            File.Copy(currentAutosaveLocation, newSave + "game.sii", true);
            File.Copy(currentAutosaveLocation.Replace("game.sii", "info.sii"), newSave + "info.sii", true);

            //CHANGE SAVEGAME NAME
            DecryptSii(newSave + "info.sii");
            string[] lines = File.ReadAllLines(newSave + "info.sii");
            StreamWriter sw = new StreamWriter(newSave + "info.sii");
            for(int i = 0; i < lines.Length; i++)
            {
                if(lines[i].Contains(" name: "))
                {
                    lines[i] = " name: \"[EuroTracker] Custom Job (" + DateTime.Now.ToShortTimeString() + ")" + "\"";
                }
                sw.WriteLine(lines[i]);
            }
            sw.Close();

            return newSave;
        }
    }
}
