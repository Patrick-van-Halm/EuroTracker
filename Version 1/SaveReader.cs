using System.IO;
using System.Windows.Forms;

namespace Tools
{
    class SaveReader : SaveData
    {      
        //CONSTRUCTOR
        public SaveReader(string autosave, string quicksave) : base()
        {
            currentAutosaveLocation = autosave;
            currentQuicksaveLocation = quicksave;
        }
        
        //METHODS

        public void UpdateAllSavedValues()
        {
            GetLastJobSource();
            GetLastJobAverageConsumptionFromFile();
            GetLastJobCargoFromFile();
            GetLastJobDrivenDistanceFromFile();
            GetLastJobEXPFromFile();
            GetLastJobInitialEarningsFromFile();
            GetLastJobPlannedDistanceFromFile();
            GetLastJobProfitFromFile();
            GetLastJobRemainingTimeFromFile();
            GetLastJobTarget();
            GetLastJobWeightFromFile();
            GetLastJobVehicleFromFile();
        }

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

        private void GetLastJobTarget()
        {
            string[] toVariable = GetLastJobVariable(2).Split('.');

            lastJobTargetCity = toVariable[toVariable.Length - 1];
            lastJobTargetCity = CapitalizeString(lastJobTargetCity.Split('_'));

            lastJobTargetCompany = toVariable[toVariable.Length - 2];
            lastJobTargetCompany = CapitalizeString(lastJobTargetCompany.Split('_'));
        }

        private void GetLastJobCargoFromFile()
        {
            string[] cargoVariable = GetLastJobVariable(3).Split('.');

            lastJobCargo = cargoVariable[cargoVariable.Length - 1];
            lastJobCargo = CapitalizeString(lastJobCargo.Split('_'));
        }

        private void GetLastJobEXPFromFile()
        {
            string exp = GetLastJobVariable(4);

            int.TryParse(exp, out lastJobEXP);
        }

        private void GetLastJobProfitFromFile()
        {
            string money = GetLastJobVariable(5);

            int.TryParse(money, out lastJobProfit);
        }

        private void GetLastJobDrivenDistanceFromFile()
        {
            string drivenDistance = GetLastJobVariable(6);

            int.TryParse(drivenDistance, out lastJobDrivenDistance);
        }

        private void GetLastJobAverageConsumptionFromFile()
        {
            string avgConsumption = GetLastJobVariable(7);

            float.TryParse(avgConsumption, out lastJobAverageConsumption);
        }

        private void GetLastJobRemainingTimeFromFile()
        {
            string remTime = GetLastJobVariable(8);

            int.TryParse(remTime, out lastJobRemainingTime);
        }

        private void GetLastJobInitialEarningsFromFile()
        {
            string initialEarnings = GetLastJobVariable(13);

            int.TryParse(initialEarnings, out lastJobInitialEarnings);
        }

        private void GetLastJobVehicleFromFile()
        {
            string[] vehicleCut = GetLastJobVariable(16).Split('.');

            vehicleCut[vehicleCut.Length - 1] = vehicleCut[vehicleCut.Length - 1].ToUpper().Replace("_", " ");
            vehicleCut[vehicleCut.Length - 2] = CapitalizeString(vehicleCut[vehicleCut.Length - 2]);
            
            string vehicle = vehicleCut[vehicleCut.Length - 2] + " " + vehicleCut[vehicleCut.Length - 1];

            lastJobVehicle = vehicle;
        }

        private void GetLastJobPlannedDistanceFromFile()
        {
            string plannedDistance = GetLastJobVariable(17);

            int.TryParse(plannedDistance, out lastJobPlannedDistance);
        }

        private void GetLastJobWeightFromFile()
        {
            string weight = GetLastJobVariable(22);

            int.TryParse(weight, out lastJobWeight);
        }
    }
}
