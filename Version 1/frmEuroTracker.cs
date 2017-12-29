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
        ProfileReader profile;
        SaveReader save;
        SaveWriter savewriter;
        frmProfileSelector mainThread;
        DatabaseHandler dbHandler;
        Graphics gDamage;
        int lastDamage = 0;
        //bool runned = false;

        public frmEuroTracker(frmProfileSelector profiles)
        {
            mainThread = profiles;
            profile = profiles.GetProfileReader();
            InitializeComponent();

            dbHandler = new DatabaseHandler();
            client = new Ets2SdkTelemetry();
            save = new SaveReader(profile.GetAutosaveLocation());
            savewriter = new SaveWriter(profile.GetAutosaveLocation());

            //Setup Syncing Voids
            client.Data += UpdateData;
            client.JobFinished += TelemetryOnJobFinished;
            client.JobStarted += TelemetryOnJobStarted;

            gDamage = imgChassisDamage.CreateGraphics();

            //dbHandler.Insert("INSERT INTO jobs VALUES (NULL, '1', 'Koln', 'Poznan', 'Diesel', '32000', 'Posped', 'FCP', '742', '874', '59444', '1992', '0', '20:00:00', '06:00:00', 'Volvo FH16 2012', '47.8', '12', '2', '90', CURRENT_TIMESTAMP);");
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
            DrawDamage(data.Damage.WearChassis, 50, lblChassisDamage, imgChassisDamage);
            DrawDamage(data.Damage.WearEnigne, 204, lblEngineDamage, imgEngineDamage);
            DamageLegend();
        }

        private void DamageLegend()
        {
            int legendPercentage = 10;
            Pen p = new Pen(Color.Black, 1);
            DrawDamageLegend(legendPercentage, p, imgChassisDamage);
            DrawDamageLegend(legendPercentage, p, imgEngineDamage);
        }

        private void DrawDamage(float damage, int lblStartPosX, Label lbl, PictureBox pic)
        {
            int stepHeight = imgChassisDamage.Height / 100;
            int DamagePercentage = Convert.ToInt32(damage * 100);
            //int chassisDamagePercentage = 60;
            int currentDamage = DamagePercentage * stepHeight;


            SolidBrush brush = new SolidBrush(Color.White);
            Graphics g = pic.CreateGraphics();

            if (DamagePercentage < 25)
                brush = new SolidBrush(Color.FromArgb(255, 170, 43));
            else if (DamagePercentage < 50)
                brush = new SolidBrush(Color.Orange);
            else if (DamagePercentage < 75)
                brush = new SolidBrush(Color.OrangeRed);
            else if (DamagePercentage < 100)
                brush = new SolidBrush(Color.Red);

            if (DamagePercentage < 10)
                lbl.Location = new Point(lblStartPosX, lbl.Location.Y);
            else if (DamagePercentage < 100)
                lbl.Location = new Point(lblStartPosX - 4, lbl.Location.Y);
            else if (DamagePercentage == 100)
                lbl.Location = new Point(lblStartPosX - 8, lbl.Location.Y);



            if (lbl.Text != DamagePercentage + "%")
            {
                lbl.Text = $"{DamagePercentage}%";
                g.Clear(Color.White);
                g.FillRectangle(brush, new Rectangle(0, imgChassisDamage.Height - currentDamage, imgChassisDamage.Width, currentDamage));
            }
            brush.Dispose();
        }

        private void DrawDamageLegend(int percentage, Pen p, PictureBox pic)
        {
            Graphics g = pic.CreateGraphics();
            int sizeOfSpace = pic.Height / percentage;

            g.DrawRectangle(p, new Rectangle(0, 0, imgChassisDamage.Width - 1, imgChassisDamage.Height - 1));
            for (int i = 0; i < percentage; i++)
            {
                g.DrawLine(p, new Point(0, sizeOfSpace * i), new Point(imgChassisDamage.Width - 1, sizeOfSpace * i));
            }
        }


        private void FrmEuroTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainThread.Close();
        }

        private void BtnAddJob_Click(object sender, EventArgs e)
        {
            savewriter.CreateJob(txtFrom.Text, txtCargo.Text, txtTruck.Text, txtTo.Text);
        }
    }
}
