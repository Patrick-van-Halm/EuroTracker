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
        protected int lastJobEXP;
        protected int lastJobProfit;
        protected int lastJobDrivenDistance;
        protected float lastJobAverageConsumption;
        protected int lastJobRemainingTime;
        protected int lastJobInitialEarnings;
        protected string lastJobVehicle;
        protected int lastJobPlannedDistance;
        protected int lastJobWeight;

        protected int lastJobRefueledAmount;
        protected int lastJobRefueledAmountCost;

        protected int refueledAmountBeforeJob;
        protected int refueledAmountCostBeforeJob;

        public SaveData()
        {
            playerMoney = 0;

            lastJobSourceCity = "";
            lastJobSourceCompany = "";
            lastJobTargetCity = "";
            lastJobTargetCompany = "";
            lastJobCargo = "";
            lastJobEXP = 0;
            lastJobProfit = 0;
            lastJobDrivenDistance = 0;
            lastJobAverageConsumption = 0f;
            lastJobRemainingTime = 0;
            lastJobInitialEarnings = 0;
            lastJobVehicle = "";
            lastJobPlannedDistance = 0;
            lastJobWeight = 0;
            lastJobRefueledAmount = 0;
            lastJobRefueledAmountCost = 0;
            refueledAmountBeforeJob = 0;
            refueledAmountCostBeforeJob = 0;
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

        public string GetLastJobCargo()
        {
            return lastJobCargo;
        }

        public int GetLastJobEXP()
        {
            return lastJobEXP;
        }

        public int GetLastJobProfit()
        {
            return lastJobProfit;
        }

        public int GetLastJobDrivenDistance()
        {
            return lastJobDrivenDistance;
        }

        public float GetLastJobAverageConsumption()
        {
            return lastJobAverageConsumption;
        }

        public int GetLastJobRemainingTime()
        {
            return lastJobRemainingTime;
        }

        public int GetLastJobInitialEarnings()
        {
            return lastJobInitialEarnings;
        }

        public string GetLastJobVehicle()
        {
            return lastJobVehicle;
        }

        public int GetLastJobPlannedDistance()
        {
            return lastJobPlannedDistance;
        }

        public int GetLastJobWeight()
        {
            return lastJobWeight;
        }

        public int GetLastJobRefueledAmount()
        {
            return lastJobRefueledAmount;
        }

        public int GetLastJobRefueledAmountCost()
        {
            return lastJobRefueledAmountCost;
        }
    }
}
