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

        public void LogJob(string sourceCity, string targetCity, string cargo, int weight, string sourceCompany, string targetCompany, int plannedDistance, int drivenDistance, int initialEarnings, int earnings, int exp, int trailerDamage, int timeRemaining, int timeJobStarted, int timeJobEnded, string truckName, float avgFuelConsumption, int refueledAmount, int fuelCost, int maxSpeed)
        {
            int playerId = 1;

            int timeRemainingHours = timeRemaining / 60;
            int timeRemainingMinutes = timeRemaining - (timeRemainingHours * 60);

            int timeTaken = timeJobStarted - timeJobEnded;
            int timeTakenHours = timeTaken / 60;
            int timeTakenMinutes = timeTaken - (timeTakenHours * 60);

            db.Insert($"INSERT INTO user_jobs VALUES (NULL, {playerId}, '{sourceCity}', '{targetCity}', '{sourceCompany}', '{targetCompany}', '{truckName}', '{cargo}', '{weight}', '{plannedDistance}', '{drivenDistance}', '{initialEarnings}', '{earnings}', '{exp}', '{trailerDamage}', '{timeRemainingHours}:{timeRemainingMinutes}:00', '{timeTakenHours}:{timeTakenMinutes}:00', '{avgFuelConsumption}', '{refueledAmount}', '{fuelCost}', '{maxSpeed}', NULL, NULL);");
        }
    }
}
