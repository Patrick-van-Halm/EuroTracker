using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class SaveData : Data
    {
        protected int playerMoney;


        protected string lastJobSourceCity;
        protected string lastJobSourceCompany;

        protected string lastJobTargetCity;
        protected string lastJobTargetCompany;

        protected string lastJobCargo;
        protected string lastJobEXP;
        protected string lastJobProfit;
        protected string lastJobDrivenDistance;
        protected string lastJobAverageConsumption;
        protected string lastJobRemainingTime;
        protected string lastJobInitialEarnings;
        protected string lastJobVehicle;
        protected string lastJobPlannedDistance;
        protected string lastJobWeight;

        public SaveData()
        {
            playerMoney = 0;

            lastJobSourceCity = "";
            lastJobSourceCompany = "";
            lastJobTargetCity = "";
            lastJobTargetCompany = "";
        }

        public int GetPlayerMoney()
        {
            return playerMoney;
        }

        public string GetLastJobSourceCity()
        {
            return lastJobSourceCity;
        }

        public string GetLastJobSourceCompany()
        {
            return lastJobSourceCompany;
        }
    }
}
