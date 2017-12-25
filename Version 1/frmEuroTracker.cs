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

            dbHandler.Insert("INSERT INTO jobs VALUES (NULL, '1', 'Koln', 'Poznan', 'Diesel', '32000', 'Posped', 'FCP', '742', '874', '59444', '1992', '0', '20:00:00', '06:00:00', 'Volvo FH16 2012', '47.8', '12', '2', '90', CURRENT_TIMESTAMP);");
        }

        private void TelemetryOnJobFinished(object sender, EventArgs args)
        {
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

                    //UpdateDamage(data);
                }

            }
            catch { }
        }

        private void UpdateDamage(Ets2Telemetry data)
        {
            Graphics g = imgDamage.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Red);
            int stepHeight = imgDamage.Height / 100;
            int chassisDamagePercentage = Convert.ToInt32(data.Damage.WearChassis * 100);
            int currentDamage = chassisDamagePercentage * stepHeight;

            if (chassisDamagePercentage < 10)
                lblDamagePercentage.Location = new Point(546, 257);
            else if (chassisDamagePercentage < 100)
                lblDamagePercentage.Location = new Point(542, 257);
            else if (chassisDamagePercentage == 100)
                lblDamagePercentage.Location = new Point(538, 257);

            lblDamagePercentage.Text = $"{chassisDamagePercentage}%";
            
            g.FillRectangle(brush, new Rectangle(0, imgDamage.Height - currentDamage, imgDamage.Width, currentDamage));
            g.Dispose();
            brush.Dispose();
        }

        private void FrmEuroTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainThread.Close();
        }
    }
}
