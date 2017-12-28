using System.IO;
using System.Windows.Forms;

namespace Tools
{
    class SavegameReader : SaveData
    {      
        //CONSTRUCTOR
        public SavegameReader(string autosave) : base()
        {
            currentAutosaveLocation = autosave;
        }
        
        //METHODS
        private string GetLastJobVariable(int paramKey)
        {
            string jobId = GetLastJob();
            if (File.Exists(currentAutosaveLocation))
            {
                DecryptSii(currentAutosaveLocation);
                StreamReader sr = new StreamReader(currentAutosaveLocation);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(line.Contains($"delivery_log_entry : {jobId}"))
                    {
                        sr.ReadLine();
                        while(line != "}")
                        {
                            line = sr.ReadLine();
                            if (line.Contains($" params[{paramKey}]:"))
                            {
                                line = line.Replace($" params[{paramKey}]: ", "");
                                line = line.Replace("\"", "");
                                return line;
                            }
                        }
                    }
                }
            }
            return "";
        }

        private string GetLastJob()
        {
            if (File.Exists(currentAutosaveLocation))
            {
                DecryptSii(currentAutosaveLocation);
                StreamReader sr = new StreamReader(currentAutosaveLocation);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(line.Contains("delivery_log : "))
                    {
                        int jobsLength = 0;
                        sr.ReadLine();
                        line = sr.ReadLine();
                        line = line.Replace(" entries: ", "");
                        int.TryParse(line, out jobsLength);
                        int i = 0;
                        for (; i < jobsLength; i++)
                        {
                            line = sr.ReadLine();
                        }
                        line = line.Replace($" entries[{i - 1}]: ", "");
                        return line;
                    }
                }
            }
            return "";
        }

        private void GetMoney()
        {
            string moneyString = GetSavedValue(currentAutosaveLocation, " money_account: ");
            int money = 0;
            int.TryParse(moneyString, out money);
            playerMoney = money;
        }        

        private void GetLastJobSource()
        {
            string[] fromVariable = GetLastJobVariable(1).Split('.');
            lastJobSourceCity = fromVariable[fromVariable.Length - 1];
            lastJobSourceCity = CapitalizeString(lastJobSourceCity.Split('_'));

            lastJobSourceCompany = fromVariable[fromVariable.Length - 2];
            lastJobSourceCompany = CapitalizeString(lastJobSourceCompany.Split('_'));
        }


    }
}
