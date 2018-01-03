using System.Windows.Forms;
using MySql.Data;
using Ets2SdkClient;
using System;
using System.Drawing;
using System.Diagnostics;
using Tools;
using System.IO;
using System.Collections.Generic;

namespace Version_1
{
    public partial class frmEuroTracker : Form
    {

        Ets2SdkTelemetry client;
        ProfileReader profile;
        SaveReader save;
        SaveWriter savewriter;
        frmProfileSelector mainThread;
        DataHandler data;

        public frmEuroTracker(frmProfileSelector profiles)
        {
            mainThread = profiles;
            profile = profiles.GetProfileReader();
            InitializeComponent();

            data = new DataHandler();
            client = new Ets2SdkTelemetry();
            save = new SaveReader(profile.GetAutosaveLocation(), profile.GetQuicksaveLocation());
            savewriter = new SaveWriter(profile.GetAutosaveLocation(), profile.GetQuicksaveLocation());

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
            DamageLegend();
            DrawDamage(data.Damage.WearChassis, 50, lblChassisDamage, imgChassisDamage);
            DrawDamage(data.Damage.WearEnigne, 204, lblEngineDamage, imgEngineDamage);
            DrawDamage(data.Damage.WearCabin, 354, lblCabinDamage, imgCabinDamage);
            DrawDamage(data.Damage.WearWheels, 507, lblWheelsDamage, imgWheelsDamage);
            DrawDamage(data.Damage.WearTransmission, 669, lblTransmissionDamage, imgTransmissionDamage);
            DrawDamage(data.Damage.WearTrailer, 842, lblTrailerDamage, imgTrailerDamage);
        }

        private void DamageLegend()
        {
            int legendPercentage = 10;
            Pen p = new Pen(Color.Black, 1);
            DrawDamageLegend(legendPercentage, p, imgChassisDamage);
            DrawDamageLegend(legendPercentage, p, imgEngineDamage);
            DrawDamageLegend(legendPercentage, p, imgCabinDamage);
            DrawDamageLegend(legendPercentage, p, imgWheelsDamage);
            DrawDamageLegend(legendPercentage, p, imgTransmissionDamage);
            DrawDamageLegend(legendPercentage, p, imgTrailerDamage);        
        }

        private void DrawDamage(float damage, int lblStartPosX, Label lbl, PictureBox pic)
        {
            int stepHeight = pic.Height / 100;
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
            else if (DamagePercentage <= 100)
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
                g.FillRectangle(brush, new Rectangle(0, pic.Height - currentDamage, pic.Width, currentDamage));
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
            if(dropFromCompany.SelectedItem.ToString() != "" && dropFromLocation.SelectedItem.ToString() != "" && dropToCompany.SelectedItem.ToString() != "" && dropToLocation.SelectedItem.ToString() != "" && dropCargo.SelectedItem.ToString() != "")
            {
                string from = dropFromCompany.SelectedItem.ToString().ToLower().Replace(" ", "_") + "." + dropFromLocation.SelectedItem.ToString().ToLower().Replace(" ", "_");
                string to = dropToCompany.SelectedItem.ToString().ToLower().Replace(" ", "_") + "." + dropToLocation.SelectedItem.ToString().ToLower().Replace(" ", "_");
                string cargo = "cargo." + dropCargo.SelectedItem.ToString().ToLower().Replace(" ", "_");
                savewriter.CreateJob(from, cargo, "man_4x2_a", to);
            }
            else
            {
                MessageBox.Show("Fill in all the dropdown boxes!", "ERROR!");
            }            
        }

        private void SetupAddJob(object sender, EventArgs e)
        {
            string companiesFile = "companies.txt";
            string cargoFile = "cargo.txt";

            string[] companies = LoadCompanies(companiesFile);
            List<string> locations = new List<string>();

            for(int i = 0; i < companies.Length; i++)
            {
                bool locationInArray = false;
                string location = CapitalizeString(companies[i].Split('.')[companies[i].Split('.').Length - 1]).Replace("_", " ");
                foreach(string loc in locations)
                {
                    if (loc == location)
                    {
                        locationInArray = true;
                        break;
                    }
                }
                if (!locationInArray)
                    locations.Add(location);
            }

            string[] cargo = LoadCargo(cargoFile);

            for(int i = 0; i < cargo.Length; i++)
            {
                cargo[i] = CapitalizeString(cargo[i].Split('.')[cargo[i].Split('.').Length - 1]).Replace("_", " ");
            }

            dropFromLocation.Items.AddRange(locations.ToArray());
            dropToLocation.Items.AddRange(locations.ToArray());
            dropFromCompany.Items.Add("SELECT LOCATION!");
            dropToCompany.Items.Add("SELECT LOCATION!");
            dropCargo.Items.AddRange(cargo);
        }

        private string[] LoadCompanies(string file)
        {
            string[] companies = File.ReadAllLines(file);
            return companies;
        }

        private string[] LoadCargo(string file)
        {
            string[] cargo = File.ReadAllLines(file);
            return cargo;
        }

        private void FromLocationIndexChanged(object sender, EventArgs e)
        {
            string location = dropFromLocation.SelectedItem.ToString();

            string[] companiesInSelectedLocation = GetCompaniesByLocation(location).ToArray();

            dropFromCompany.Items.Clear();
            dropFromCompany.Items.AddRange(companiesInSelectedLocation);
        }

        private List<string> GetCompaniesByLocation(string locationName)
        {
            string[] allLocations = File.ReadAllLines("companies.txt");
            List<string> companiesInLocation = new List<string>();

            foreach(string line in allLocations)
            {
                if (line.Contains(locationName.ToLower()))
                {
                    companiesInLocation.Add(CapitalizeString(line.Split('.')[line.Split('.').Length - 2]).Replace("_", " "));
                }
            }
            return companiesInLocation;
        }
        public string CapitalizeString(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        private void ToLocationIndexChanged(object sender, EventArgs e)
        {
            string location = dropToLocation.SelectedItem.ToString();

            string[] companiesInSelectedLocation = GetCompaniesByLocation(location).ToArray();

            dropToCompany.Items.Clear();
            dropToCompany.Items.AddRange(companiesInSelectedLocation);
        }
    }
}
