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
            //MessageBox.Show("Job finished, or at least unloaded nearby cargo destination.");
        }

        private void TelemetryOnJobStarted(object sender, EventArgs e)
        {
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
            }
            catch { }
        }

        private void FrmEuroTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainThread.Close();
        }
    }
}
