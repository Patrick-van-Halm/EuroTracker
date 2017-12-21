using System.Windows.Forms;
using MySql.Data;
using Ets2SdkClient;
using System;

namespace Version_1
{
    public partial class frmEuroTracker : Form
    {
        Ets2SdkTelemetry telementry;

        public frmEuroTracker()
        {
            InitializeComponent();

            telementry = new Ets2SdkTelemetry();
            telementry.Data += UpdateData;
            telementry.JobFinished += TelemetryOnJobFinished;
            telementry.JobStarted += TelemetryOnJobStarted;
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
                if (this.InvokeRequired)
                {
                    this.Invoke(new TelemetryData(UpdateData), new object[2] { data, updated });
                    return;
                }

                float fuel = data.Drivetrain.Fuel;
                float maxFuel = data.Drivetrain.FuelMax;
                lblFuel.Text = $"Fuel: {Math.Round(fuel)}/{Math.Round(maxFuel)}";
            }
            catch
            {

            }
        }
    }
}
