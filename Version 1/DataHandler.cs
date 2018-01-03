using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class DataHandler
    {
        DatabaseHandler db;

        public DataHandler()
        {
            db = new DatabaseHandler();
        }

        public void LogJob(string sourceCity, string targetCity, string cargo, int weight, string sourceCompany, string targetCompany, int plannedDistance, int drivenDistance, int earnings, int exp, int trailerDamage, int timeRemaining, int timeJobStarted, int timeJobEnded, string truckName, float avgFuelConsumption, int refueledAmount, int fuelCost, int maxSpeed)
        {
            int playerId = 4;

            int timeRemainingHours = timeRemaining / 60;
            int timeRemainingMinutes = timeRemaining - (timeRemainingHours * 60);

            int timeTaken = timeJobStarted - timeJobEnded;
            int timeTakenHours = timeTaken / 60;
            int timeTakenMinutes = timeTaken - (timeTakenHours * 60);

            db.Insert($"INSERT INTO jobs VALUES (NULL, {playerId}, '{sourceCity}', '{targetCity}', '{cargo}', '{weight}', '{sourceCompany}', '{targetCompany}', '{plannedDistance}', '{drivenDistance}', '{earnings}', '{exp}', '{trailerDamage}', '{timeRemainingHours}:{timeRemainingMinutes}:00', '{timeTakenHours}:{timeTakenMinutes}:00', '{truckName}', '{avgFuelConsumption}', '{refueledAmount}', '{fuelCost}', '{maxSpeed}', CURRENT_TIMESTAMP);");
        }
    }
}
