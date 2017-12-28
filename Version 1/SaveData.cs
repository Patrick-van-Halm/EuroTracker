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
