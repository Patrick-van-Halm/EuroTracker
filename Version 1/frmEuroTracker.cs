using System.Windows.Forms;
using MySql.Data;
using Ets2SdkClient;
using System;
using System.Drawing;
using System.Diagnostics;
using UnidecodeSharpFork;

namespace Version_1
{
    public partial class frmEuroTracker : Form
    {
        //Timers
        Timer startup;





        Ets2SdkTelemetry client;
        SavegameReader save;
        //DevTool dev;
        float lastChassisDamagePercentage;

        public frmEuroTracker()
        {
            InitializeComponent();
            //dev = new DevTool("eurotrucks2");
            client = new Ets2SdkTelemetry();
            //client.Data += UpdateData;
            //client.JobFinished += TelemetryOnJobFinished;
            //client.JobStarted += TelemetryOnJobStarted;

            startup = new Timer();
            startup.Interval = 100;
            startup.Tick += CheckIfSetupCorrectly;
            startup.Enabled = true;
        }

        private void CheckIfSetupCorrectly(object sender, EventArgs e)
        {
            if(save.GetSaveLocation() != "")
            {
                startup.Enabled = false;
                client.Data += UpdateData;
                client.JobFinished += TelemetryOnJobFinished;
                client.JobStarted += TelemetryOnJobStarted;
            }
        }

        private void TelemetryOnJobFinished(object sender, EventArgs args)
        {
            MessageBox.Show("Job finished, or at least unloaded nearby cargo destination.");
        }

        private void TelemetryOnJobStarted(object sender, EventArgs e)
        {
            MessageBox.Show("Just started job OR loaded game with active.");
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
                }
                
                float fuel = data.Drivetrain.Fuel;
                float maxFuel = data.Drivetrain.FuelMax;
                lblFuel.Text = $"Fuel: {Math.Round(fuel)}/{Math.Round(maxFuel)}";

                float posX = data.Physics.CoordinateX;
                float posY = data.Physics.CoordinateY;
                float posZ = data.Physics.CoordinateZ;

                lblPosition.Text = $"Position: {posX}, {posY}, {posZ}";

                int stepHeight = imgDamage.Height / 100;
                float chassisDamage = data.Damage.WearChassis;

                float trailerDamage = data.Damage.WearTrailer;

                float chassisDamagePercentage = chassisDamage * 100;
                int currentDamagePercentage = 0;
                if (lastChassisDamagePercentage != chassisDamagePercentage)
                {
                    lastChassisDamagePercentage = chassisDamagePercentage;
                    for (int i = 0; i < Convert.ToInt32(chassisDamagePercentage); i++)
                    {
                        Application.DoEvents();
                        currentDamagePercentage += stepHeight;
                        Graphics g = imgDamage.CreateGraphics();
                        g.Clear(Color.White);
                        Pen p = new Pen(Color.Red, imgDamage.Width);
                        g.FillRectangle(new SolidBrush(Color.Red), 0, imgDamage.Height - 10, imgDamage.Width, -currentDamagePercentage);
                        p.Dispose();
                        g.Dispose();
                    }
                }
                string savegameTarget = (data.Job.CompanyDestination.Split(' ')[0] + "." + data.Job.CityDestination).ToLower().Unidecode();
                lblTruck.Text = $"Truck: {data.TruckId} {data.Truck} {data.Job.TrailerId}";
                lblCargo.Text = $"Cargo: {data.Job.Cargo}";
                lblTarget.Text = $"Target: {savegameTarget}";
                lblDistance.Text = $"Distance: {Convert.ToInt32(data.Job.NavigationDistanceLeft / 1000)} KM";
                lblMoney.Text = $"Money: {save.GetPlayerMoney()}";


                //lblMoney.Text = $"Money: {GetMoney()}";
            }
            catch { }
        }

        private void frmEuroTracker_Shown(object sender, EventArgs e)
        {
            this.Hide();
            save = new SavegameReader(this);
        }



        //64-Bit Memory Money Get

        //private int GetMoney()
        //{
        //    int returnedData;
        //    long baseAdress = Process.GetProcessesByName("eurotrucks2")[0].MainModule.BaseAddress.ToInt64();
        //    returnedData = dev.Read(baseAdress + 0x0126DC50);
        //    returnedData = dev.Read(returnedData + 0x1A8);
        //    returnedData = dev.Read(returnedData + 0x288);
        //    returnedData = dev.Read(returnedData + 0x1F0);
        //    return returnedData;
        //}
    }
}
