using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class ProfileData : Data
    {
        protected int playerEXP;
        
        public ProfileData()
        {
            playerEXP = 0;
        }

        public int GetPlayerEXP()
        {
            return playerEXP;
        }
    }
}
