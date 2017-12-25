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

        public frmEuroTracker(frmProfileSelector profiles)
        {
            mainThread = profiles;
            save = profiles.GetSavegameReader();
            InitializeComponent();
            
            client = new Ets2SdkTelemetry();
            
            //Setup Syncing Voids
            client.Data += UpdateData;
            client.JobFinished += TelemetryOnJobFinished;
            client.JobStarted += TelemetryOnJobStarted;
        }

        private void TelemetryOnJobFinished(object sender, EventArgs args)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(TelemetryOnJobFinished));
                return;
            }
            Graphics g = imgDamage.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
            
            //MessageBox.Show("Job finished, or at least unloaded nearby cargo destination.");
        }

        private void TelemetryOnJobStarted(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(TelemetryOnJobStarted));
                return;
            }
            lblMoney.Text = $"Money: {save.GetPlayerMoney()}";
            lblEXP.Text = $"Experience: {save.GetPlayerEXP()}";
            //MessageBox.Show("Just started job OR loaded game with active.");
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
                
                lblFuel.Text = $"Fuel: {Math.Round(data.Drivetrain.Fuel)}/{Math.Round(data.Drivetrain.FuelMax)}";
                lblPosition.Text = $"Position: {data.Physics.CoordinateX}, {data.Physics.CoordinateY}, {data.Physics.CoordinateZ}";                
                lblTruck.Text = $"Truck: {data.TruckId} {data.Truck} {data.Job.TrailerId}";
                lblCargo.Text = $"Cargo: {data.Job.Cargo}";
                lblTarget.Text = $"Target: {data.Job.CompanyDestination} in {data.Job.CityDestination}";
                lblDistance.Text = $"Distance: {Math.Round(data.Job.NavigationDistanceLeft / 1000, 1)} KM";
                lblMoney.Text = $"Money: {save.GetPlayerMoney()}";
                lblEXP.Text = $"Experience: {save.GetPlayerEXP()}";

                UpdateDamage(data);

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
