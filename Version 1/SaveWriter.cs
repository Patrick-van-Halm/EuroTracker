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

        public void CreateJob(string source, string cargo, string company_truck, string target, int distance)
        {
            string location = CreateNewSave(cargo + " to " + target);
            DecryptSii(location + "game.sii");
            List<string> lines = File.ReadAllLines(location + "game.sii").ToList();
            StreamWriter sw = new StreamWriter(location + "game.sii");
            for (int i = 0; i < lines.Count; i++)
            {
                if(lines[i].Contains("company : company.volatile." + source))
                {
                    //Change Offers +1
                    string offers_available_str = lines[i + 4].Replace(" job_offer: ", "");
                    int offers_available = 0;
                    int.TryParse(offers_available_str, out offers_available);
                    offers_available++;
                    lines[i + 4] = " job_offer: " + offers_available;

                    //Add Offer
                    string[] jobIdSplit = lines[i + 5].Replace(" job_offer[0]: ", "").Split('.');
                    string jobId = "";
                    for(int j = 0; j < jobIdSplit.Length -1; j++)
                    {
                        jobId += jobIdSplit[j] + ".";
                    }
                    Random rnd = new Random();
                    jobId += rnd.Next(0, 100) + "b" + rnd.Next(0, 10);
                    lines.Insert(i + (4 + offers_available), $" job_offer[{offers_available - 1}]: " + jobId);

                    //Set source to discovered
                    int tempi = i;
                    while(lines[tempi] != "}")
                    {
                        tempi++;
                    }
                    lines[tempi - 1] = " discovered: true";

                    //Add Job
                    tempi++;
                    for(int j = 0; j < offers_available - 1; j++)
                    {
                        tempi += 13;
                    }

                    string expire;
                    int tempj = tempi;
                    while(!lines[tempj].Contains(" expiration_time: "))
                    {
                        tempj++;
                    }
                    expire = lines[tempj].Replace(" expiration_time: ", "");

                    string[] offerInfo = {
                        "job_offer_data : " + jobId + " {",
                        " cargo: " + cargo,
                        " company_truck: " + company_truck,
                        " variant: 0",
                        " target: \"" + target + "\"",
                        " expiration_time: " + expire,
                        " urgency: 0",
                        " shortest_distance_km: " + distance,
                        " ferry_time: 35",
                        " ferry_price: 300",
                        " trailer_place: 0",
                        "}",
                        ""
                    };
                    lines.InsertRange(tempi + 1, offerInfo);
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
                    lines[i] = " name: \"Custom Job: " + DateTime.Now.ToShortDateString() + "\"";
                }
                sw.WriteLine(lines[i]);
            }
            sw.Close();

            return newSave;
        }
    }
}
