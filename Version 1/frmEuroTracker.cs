using System.Windows.Forms;
using MySql.Data;
using Ets2SdkClient;
using System;

namespace Version_1
{
    public partial class frmEuroTracker : Form
    {
        Ets2SdkTelemetry client;

        public frmEuroTracker()
        {
            InitializeComponent();
            
            client = new Ets2SdkTelemetry();
            client.Data += UpdateData;
            client.JobFinished += TelemetryOnJobFinished;
            client.JobStarted += TelemetryOnJobStarted;
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
            if(data != null)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new TelemetryData(UpdateData), new object[2] { data, updated });
                    return;
                }

                float fuel = data.Drivetrain.Fuel;
                float maxFuel = data.Drivetrain.FuelMax;
                lblFuel.Text = $"Fuel: {Math.Round(fuel)}/{Math.Round(maxFuel)}";

                float posX = data.Physics.CoordinateX;
                float posY = data.Physics.CoordinateY;
                float posZ = data.Physics.CoordinateZ;

                lblPosition.Text = $"Position: {posX}, {posY}, {posZ}";
            }
        }
    }
}
