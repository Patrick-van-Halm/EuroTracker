using System.Windows.Forms;
using MySql.Data;
using Ets2SdkClient;
using System;
using System.Drawing;
using System.Diagnostics;
using Tools;

namespace Version_1
{
    public partial class frmEuroTracker : Form
    {

        Ets2SdkTelemetry client;
        SavegameReader save;
        frmProfileSelector mainThread;
        DatabaseHandler dbHandler;
        Graphics gDamage;
        int lastDamage = 0;
        //bool runned = false;

        public frmEuroTracker(frmProfileSelector profiles)
        {
            mainThread = profiles;
            save = profiles.GetSavegameReader();
            InitializeComponent();

            dbHandler = new DatabaseHandler();
            client = new Ets2SdkTelemetry();
            
            //Setup Syncing Voids
            client.Data += UpdateData;
            client.JobFinished += TelemetryOnJobFinished;
            client.JobStarted += TelemetryOnJobStarted;

            gDamage = imgDamage.CreateGraphics();

            //dbHandler.Insert("INSERT INTO jobs VALUES (NULL, '1', 'Koln', 'Poznan', 'Diesel', '32000', 'Posped', 'FCP', '742', '874', '59444', '1992', '0', '20:00:00', '06:00:00', 'Volvo FH16 2012', '47.8', '12', '2', '90', CURRENT_TIMESTAMP);");
        }

        private void TelemetryOnJobFinished(object sender, EventArgs args)
        {
            string from = save.GetDeliveryVariable(1).Split('.')[save.GetDeliveryVariable(1).Split('.').Length - 1];
            from = CapitalizeString(from);
            //MessageBox.Show("Job finished, or at least unloaded nearby cargo destination.");
        }

        private void TelemetryOnJobStarted(object sender, EventArgs e)
        {
            
        }

        private void UpdateData(Ets2Telemetry data, bool updated)
        {
            try
            {
                if (data != null)
                {

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new TelemetryData(UpdateData), new object[2] { data, updated });
                        return;
                    }

                    lblFuel.Text = $"Fuel: {Math.Round(data.Drivetrain.Fuel)}/{Math.Round(data.Drivetrain.FuelMax)}";
                    lblPosition.Text = $"Position: {data.Physics.CoordinateX}, {data.Physics.CoordinateY}, {data.Physics.CoordinateZ}";
                    lblTruck.Text = $"Truck: {data.TruckId} {data.Truck} {data.Job.TrailerId}";
                    lblCargo.Text = $"Cargo: {data.Job.Cargo}";
                    lblTarget.Text = $"Target: {data.Job.CompanyDestination} in {data.Job.CityDestination}";
                    lblDistance.Text = $"Distance: {Math.Round(data.Job.NavigationDistanceLeft / 1000, 1)} KM";
                    lblMoney.Text = $"Money: {save.GetPlayerMoney()}";
                    lblEXP.Text = $"Experience: {save.GetPlayerEXP()}";

                    UpdateDamage(data);
                    //if (!runned)
                    //{
                    //    dbHandler.Insert("INSERT INTO jobs VALUES (NULL, '1', 'Koln', 'Poznan', 'Diesel', '32000', 'Posped', 'FCP', '742', '874', '59444', '1992', '0', '20:00:00', '06:00:00', 'Volvo FH16 2012', '47.8', '12', '2', '90', CURRENT_TIMESTAMP);");
                    //    runned = true;
                    //}
                }

            }
            catch { }
        }

        private void UpdateDamage(Ets2Telemetry data)
        {
            
            int stepHeight = imgDamage.Height / 100;
            int chassisDamagePercentage = Convert.ToInt32(data.Damage.WearChassis * 100);
            //int chassisDamagePercentage = 60;
            int currentDamage = chassisDamagePercentage * stepHeight;


            SolidBrush brush = new SolidBrush(Color.White);

            if (chassisDamagePercentage < 25)
                brush = new SolidBrush(Color.FromArgb(255, 170, 43));
            else if (chassisDamagePercentage < 50)
                brush = new SolidBrush(Color.Orange);
            else if (chassisDamagePercentage < 75)
                brush = new SolidBrush(Color.OrangeRed);
            else if (chassisDamagePercentage < 100)
                brush = new SolidBrush(Color.Red);

            if (chassisDamagePercentage < 10)
                lblDamagePercentage.Location = new Point(546, lblDamagePercentage.Location.Y);
            else if (chassisDamagePercentage < 100)
                lblDamagePercentage.Location = new Point(542, lblDamagePercentage.Location.Y);
            else if (chassisDamagePercentage == 100)
                lblDamagePercentage.Location = new Point(538, lblDamagePercentage.Location.Y);

            

            if (currentDamage != lastDamage)
            {
                lblDamagePercentage.Text = $"{chassisDamagePercentage}%";
                gDamage.Clear(Color.White);
                gDamage.FillRectangle(brush, new Rectangle(0, imgDamage.Height - currentDamage, imgDamage.Width, currentDamage));
                lastDamage = currentDamage;
            }
            brush.Dispose();
            DamageLegend();
        }

        private void DamageLegend()
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen p = new Pen(Color.Black, 1);

            int tenPercent = imgDamage.Height / 10;

            gDamage.DrawRectangle(p, new Rectangle(0, 0, imgDamage.Width-1, imgDamage.Height-1));
            for (int i = 0; i < 10; i++)
            {
                gDamage.DrawLine(p, new Point(0, tenPercent * i), new Point(imgDamage.Width - 1, tenPercent * i));
            }
            brush.Dispose();
        }

        private void FrmEuroTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainThread.Close();
        }
        public string CapitalizeString(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }
}
