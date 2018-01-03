namespace Version_1
{
    partial class frmEuroTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEuroTracker));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabsTracker = new System.Windows.Forms.TabControl();
            this.tabDamage = new System.Windows.Forms.TabPage();
            this.lblJobStatus = new System.Windows.Forms.Label();
            this.lblCurSpeed = new System.Windows.Forms.Label();
            this.lblTrailerDamageTitle = new System.Windows.Forms.Label();
            this.lblTrailerDamage = new System.Windows.Forms.Label();
            this.imgTrailerDamage = new System.Windows.Forms.PictureBox();
            this.lblTransmissionDamageTitle = new System.Windows.Forms.Label();
            this.lblTransmissionDamage = new System.Windows.Forms.Label();
            this.imgTransmissionDamage = new System.Windows.Forms.PictureBox();
            this.lblWheelsDamageTitle = new System.Windows.Forms.Label();
            this.lblWheelsDamage = new System.Windows.Forms.Label();
            this.imgWheelsDamage = new System.Windows.Forms.PictureBox();
            this.lblCabinDamageTitle = new System.Windows.Forms.Label();
            this.lblCabinDamage = new System.Windows.Forms.Label();
            this.imgCabinDamage = new System.Windows.Forms.PictureBox();
            this.lblEngineDamageTitle = new System.Windows.Forms.Label();
            this.lblEngineDamage = new System.Windows.Forms.Label();
            this.imgEngineDamage = new System.Windows.Forms.PictureBox();
            this.lblChassisDamageTitle = new System.Windows.Forms.Label();
            this.lblChassisDamage = new System.Windows.Forms.Label();
            this.imgChassisDamage = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlCustomJob = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlCustomJobCargo = new System.Windows.Forms.Panel();
            this.dropCargo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCustomJobTo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dropToCompany = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dropToLocation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCustomJobFrom = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dropFromCompany = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dropFromLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.lblIngameTime = new System.Windows.Forms.Label();
            this.tabsTracker.SuspendLayout();
            this.tabDamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrailerDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTransmissionDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWheelsDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCabinDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEngineDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChassisDamage)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnlCustomJob.SuspendLayout();
            this.pnlCustomJobCargo.SuspendLayout();
            this.pnlCustomJobTo.SuspendLayout();
            this.pnlCustomJobFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Euro Tracker";
            // 
            // tabsTracker
            // 
            this.tabsTracker.Controls.Add(this.tabDamage);
            this.tabsTracker.Controls.Add(this.tabPage2);
            this.tabsTracker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabsTracker.Location = new System.Drawing.Point(0, 37);
            this.tabsTracker.Name = "tabsTracker";
            this.tabsTracker.SelectedIndex = 0;
            this.tabsTracker.Size = new System.Drawing.Size(941, 704);
            this.tabsTracker.TabIndex = 2;
            // 
            // tabDamage
            // 
            this.tabDamage.Controls.Add(this.lblIngameTime);
            this.tabDamage.Controls.Add(this.lblJobStatus);
            this.tabDamage.Controls.Add(this.lblCurSpeed);
            this.tabDamage.Controls.Add(this.lblTrailerDamageTitle);
            this.tabDamage.Controls.Add(this.lblTrailerDamage);
            this.tabDamage.Controls.Add(this.imgTrailerDamage);
            this.tabDamage.Controls.Add(this.lblTransmissionDamageTitle);
            this.tabDamage.Controls.Add(this.lblTransmissionDamage);
            this.tabDamage.Controls.Add(this.imgTransmissionDamage);
            this.tabDamage.Controls.Add(this.lblWheelsDamageTitle);
            this.tabDamage.Controls.Add(this.lblWheelsDamage);
            this.tabDamage.Controls.Add(this.imgWheelsDamage);
            this.tabDamage.Controls.Add(this.lblCabinDamageTitle);
            this.tabDamage.Controls.Add(this.lblCabinDamage);
            this.tabDamage.Controls.Add(this.imgCabinDamage);
            this.tabDamage.Controls.Add(this.lblEngineDamageTitle);
            this.tabDamage.Controls.Add(this.lblEngineDamage);
            this.tabDamage.Controls.Add(this.imgEngineDamage);
            this.tabDamage.Controls.Add(this.lblChassisDamageTitle);
            this.tabDamage.Controls.Add(this.lblChassisDamage);
            this.tabDamage.Controls.Add(this.imgChassisDamage);
            this.tabDamage.Location = new System.Drawing.Point(4, 28);
            this.tabDamage.Name = "tabDamage";
            this.tabDamage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDamage.Size = new System.Drawing.Size(933, 672);
            this.tabDamage.TabIndex = 0;
            this.tabDamage.Text = "Damage";
            this.tabDamage.UseVisualStyleBackColor = true;
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.AutoSize = true;
            this.lblJobStatus.Location = new System.Drawing.Point(9, 467);
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(86, 19);
            this.lblJobStatus.TabIndex = 34;
            this.lblJobStatus.Text = "Job Status:";
            // 
            // lblCurSpeed
            // 
            this.lblCurSpeed.AutoSize = true;
            this.lblCurSpeed.Location = new System.Drawing.Point(9, 423);
            this.lblCurSpeed.Name = "lblCurSpeed";
            this.lblCurSpeed.Size = new System.Drawing.Size(123, 19);
            this.lblCurSpeed.TabIndex = 33;
            this.lblCurSpeed.Text = "Current Speed:";
            // 
            // lblTrailerDamageTitle
            // 
            this.lblTrailerDamageTitle.AutoSize = true;
            this.lblTrailerDamageTitle.Location = new System.Drawing.Point(793, 4);
            this.lblTrailerDamageTitle.Name = "lblTrailerDamageTitle";
            this.lblTrailerDamageTitle.Size = new System.Drawing.Size(125, 19);
            this.lblTrailerDamageTitle.TabIndex = 32;
            this.lblTrailerDamageTitle.Text = "Trailer Damage";
            // 
            // lblTrailerDamage
            // 
            this.lblTrailerDamage.AutoSize = true;
            this.lblTrailerDamage.Location = new System.Drawing.Point(842, 346);
            this.lblTrailerDamage.Name = "lblTrailerDamage";
            this.lblTrailerDamage.Size = new System.Drawing.Size(34, 19);
            this.lblTrailerDamage.TabIndex = 31;
            this.lblTrailerDamage.Text = "0%";
            // 
            // imgTrailerDamage
            // 
            this.imgTrailerDamage.BackColor = System.Drawing.Color.White;
            this.imgTrailerDamage.Location = new System.Drawing.Point(821, 26);
            this.imgTrailerDamage.Name = "imgTrailerDamage";
            this.imgTrailerDamage.Size = new System.Drawing.Size(72, 300);
            this.imgTrailerDamage.TabIndex = 30;
            this.imgTrailerDamage.TabStop = false;
            // 
            // lblTransmissionDamageTitle
            // 
            this.lblTransmissionDamageTitle.AutoSize = true;
            this.lblTransmissionDamageTitle.Location = new System.Drawing.Point(599, 4);
            this.lblTransmissionDamageTitle.Name = "lblTransmissionDamageTitle";
            this.lblTransmissionDamageTitle.Size = new System.Drawing.Size(171, 19);
            this.lblTransmissionDamageTitle.TabIndex = 29;
            this.lblTransmissionDamageTitle.Text = "Transmission Damage";
            // 
            // lblTransmissionDamage
            // 
            this.lblTransmissionDamage.AutoSize = true;
            this.lblTransmissionDamage.Location = new System.Drawing.Point(669, 346);
            this.lblTransmissionDamage.Name = "lblTransmissionDamage";
            this.lblTransmissionDamage.Size = new System.Drawing.Size(34, 19);
            this.lblTransmissionDamage.TabIndex = 28;
            this.lblTransmissionDamage.Text = "0%";
            // 
            // imgTransmissionDamage
            // 
            this.imgTransmissionDamage.BackColor = System.Drawing.Color.White;
            this.imgTransmissionDamage.Location = new System.Drawing.Point(648, 26);
            this.imgTransmissionDamage.Name = "imgTransmissionDamage";
            this.imgTransmissionDamage.Size = new System.Drawing.Size(72, 300);
            this.imgTransmissionDamage.TabIndex = 27;
            this.imgTransmissionDamage.TabStop = false;
            // 
            // lblWheelsDamageTitle
            // 
            this.lblWheelsDamageTitle.AutoSize = true;
            this.lblWheelsDamageTitle.Location = new System.Drawing.Point(453, 4);
            this.lblWheelsDamageTitle.Name = "lblWheelsDamageTitle";
            this.lblWheelsDamageTitle.Size = new System.Drawing.Size(130, 19);
            this.lblWheelsDamageTitle.TabIndex = 26;
            this.lblWheelsDamageTitle.Text = "Wheels Damage";
            // 
            // lblWheelsDamage
            // 
            this.lblWheelsDamage.AutoSize = true;
            this.lblWheelsDamage.Location = new System.Drawing.Point(507, 346);
            this.lblWheelsDamage.Name = "lblWheelsDamage";
            this.lblWheelsDamage.Size = new System.Drawing.Size(34, 19);
            this.lblWheelsDamage.TabIndex = 25;
            this.lblWheelsDamage.Text = "0%";
            // 
            // imgWheelsDamage
            // 
            this.imgWheelsDamage.BackColor = System.Drawing.Color.White;
            this.imgWheelsDamage.Location = new System.Drawing.Point(486, 26);
            this.imgWheelsDamage.Name = "imgWheelsDamage";
            this.imgWheelsDamage.Size = new System.Drawing.Size(72, 300);
            this.imgWheelsDamage.TabIndex = 24;
            this.imgWheelsDamage.TabStop = false;
            // 
            // lblCabinDamageTitle
            // 
            this.lblCabinDamageTitle.AutoSize = true;
            this.lblCabinDamageTitle.Location = new System.Drawing.Point(306, 4);
            this.lblCabinDamageTitle.Name = "lblCabinDamageTitle";
            this.lblCabinDamageTitle.Size = new System.Drawing.Size(120, 19);
            this.lblCabinDamageTitle.TabIndex = 23;
            this.lblCabinDamageTitle.Text = "Cabin Damage";
            // 
            // lblCabinDamage
            // 
            this.lblCabinDamage.AutoSize = true;
            this.lblCabinDamage.Location = new System.Drawing.Point(354, 346);
            this.lblCabinDamage.Name = "lblCabinDamage";
            this.lblCabinDamage.Size = new System.Drawing.Size(34, 19);
            this.lblCabinDamage.TabIndex = 22;
            this.lblCabinDamage.Text = "0%";
            // 
            // imgCabinDamage
            // 
            this.imgCabinDamage.BackColor = System.Drawing.Color.White;
            this.imgCabinDamage.Location = new System.Drawing.Point(333, 26);
            this.imgCabinDamage.Name = "imgCabinDamage";
            this.imgCabinDamage.Size = new System.Drawing.Size(72, 300);
            this.imgCabinDamage.TabIndex = 21;
            this.imgCabinDamage.TabStop = false;
            // 
            // lblEngineDamageTitle
            // 
            this.lblEngineDamageTitle.AutoSize = true;
            this.lblEngineDamageTitle.Location = new System.Drawing.Point(156, 4);
            this.lblEngineDamageTitle.Name = "lblEngineDamageTitle";
            this.lblEngineDamageTitle.Size = new System.Drawing.Size(127, 19);
            this.lblEngineDamageTitle.TabIndex = 20;
            this.lblEngineDamageTitle.Text = "Engine Damage";
            // 
            // lblEngineDamage
            // 
            this.lblEngineDamage.AutoSize = true;
            this.lblEngineDamage.Location = new System.Drawing.Point(204, 346);
            this.lblEngineDamage.Name = "lblEngineDamage";
            this.lblEngineDamage.Size = new System.Drawing.Size(34, 19);
            this.lblEngineDamage.TabIndex = 19;
            this.lblEngineDamage.Text = "0%";
            // 
            // imgEngineDamage
            // 
            this.imgEngineDamage.BackColor = System.Drawing.Color.White;
            this.imgEngineDamage.Location = new System.Drawing.Point(183, 26);
            this.imgEngineDamage.Name = "imgEngineDamage";
            this.imgEngineDamage.Size = new System.Drawing.Size(72, 300);
            this.imgEngineDamage.TabIndex = 18;
            this.imgEngineDamage.TabStop = false;
            // 
            // lblChassisDamageTitle
            // 
            this.lblChassisDamageTitle.AutoSize = true;
            this.lblChassisDamageTitle.Location = new System.Drawing.Point(4, 4);
            this.lblChassisDamageTitle.Name = "lblChassisDamageTitle";
            this.lblChassisDamageTitle.Size = new System.Drawing.Size(131, 19);
            this.lblChassisDamageTitle.TabIndex = 17;
            this.lblChassisDamageTitle.Text = "Chassis Damage";
            // 
            // lblChassisDamage
            // 
            this.lblChassisDamage.AutoSize = true;
            this.lblChassisDamage.Location = new System.Drawing.Point(49, 346);
            this.lblChassisDamage.Name = "lblChassisDamage";
            this.lblChassisDamage.Size = new System.Drawing.Size(34, 19);
            this.lblChassisDamage.TabIndex = 16;
            this.lblChassisDamage.Text = "0%";
            // 
            // imgChassisDamage
            // 
            this.imgChassisDamage.BackColor = System.Drawing.Color.White;
            this.imgChassisDamage.Location = new System.Drawing.Point(29, 26);
            this.imgChassisDamage.Name = "imgChassisDamage";
            this.imgChassisDamage.Size = new System.Drawing.Size(72, 300);
            this.imgChassisDamage.TabIndex = 15;
            this.imgChassisDamage.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlCustomJob);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 672);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Job";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlCustomJob
            // 
            this.pnlCustomJob.BackColor = System.Drawing.Color.Silver;
            this.pnlCustomJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomJob.Controls.Add(this.label8);
            this.pnlCustomJob.Controls.Add(this.pnlCustomJobCargo);
            this.pnlCustomJob.Controls.Add(this.pnlCustomJobTo);
            this.pnlCustomJob.Controls.Add(this.pnlCustomJobFrom);
            this.pnlCustomJob.Controls.Add(this.btnAddJob);
            this.pnlCustomJob.Location = new System.Drawing.Point(8, 6);
            this.pnlCustomJob.Name = "pnlCustomJob";
            this.pnlCustomJob.Size = new System.Drawing.Size(341, 374);
            this.pnlCustomJob.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "ADD CUSTOM JOB";
            // 
            // pnlCustomJobCargo
            // 
            this.pnlCustomJobCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomJobCargo.Controls.Add(this.dropCargo);
            this.pnlCustomJobCargo.Controls.Add(this.label3);
            this.pnlCustomJobCargo.Location = new System.Drawing.Point(2, 267);
            this.pnlCustomJobCargo.Name = "pnlCustomJobCargo";
            this.pnlCustomJobCargo.Size = new System.Drawing.Size(335, 70);
            this.pnlCustomJobCargo.TabIndex = 25;
            // 
            // dropCargo
            // 
            this.dropCargo.DropDownHeight = 240;
            this.dropCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropCargo.FormattingEnabled = true;
            this.dropCargo.IntegralHeight = false;
            this.dropCargo.Location = new System.Drawing.Point(12, 36);
            this.dropCargo.Name = "dropCargo";
            this.dropCargo.Size = new System.Drawing.Size(309, 27);
            this.dropCargo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "CARGO";
            // 
            // pnlCustomJobTo
            // 
            this.pnlCustomJobTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomJobTo.Controls.Add(this.label2);
            this.pnlCustomJobTo.Controls.Add(this.dropToCompany);
            this.pnlCustomJobTo.Controls.Add(this.label6);
            this.pnlCustomJobTo.Controls.Add(this.dropToLocation);
            this.pnlCustomJobTo.Controls.Add(this.label7);
            this.pnlCustomJobTo.Location = new System.Drawing.Point(2, 152);
            this.pnlCustomJobTo.Name = "pnlCustomJobTo";
            this.pnlCustomJobTo.Size = new System.Drawing.Size(335, 109);
            this.pnlCustomJobTo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Company";
            // 
            // dropToCompany
            // 
            this.dropToCompany.DropDownHeight = 240;
            this.dropToCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropToCompany.FormattingEnabled = true;
            this.dropToCompany.IntegralHeight = false;
            this.dropToCompany.Location = new System.Drawing.Point(11, 71);
            this.dropToCompany.Name = "dropToCompany";
            this.dropToCompany.Size = new System.Drawing.Size(192, 27);
            this.dropToCompany.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "TO";
            // 
            // dropToLocation
            // 
            this.dropToLocation.DropDownHeight = 240;
            this.dropToLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropToLocation.FormattingEnabled = true;
            this.dropToLocation.IntegralHeight = false;
            this.dropToLocation.Location = new System.Drawing.Point(11, 38);
            this.dropToLocation.Name = "dropToLocation";
            this.dropToLocation.Size = new System.Drawing.Size(192, 27);
            this.dropToLocation.TabIndex = 17;
            this.dropToLocation.SelectedIndexChanged += new System.EventHandler(this.ToLocationIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Location";
            // 
            // pnlCustomJobFrom
            // 
            this.pnlCustomJobFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomJobFrom.Controls.Add(this.label4);
            this.pnlCustomJobFrom.Controls.Add(this.dropFromCompany);
            this.pnlCustomJobFrom.Controls.Add(this.label5);
            this.pnlCustomJobFrom.Controls.Add(this.dropFromLocation);
            this.pnlCustomJobFrom.Controls.Add(this.label1);
            this.pnlCustomJobFrom.Location = new System.Drawing.Point(2, 37);
            this.pnlCustomJobFrom.Name = "pnlCustomJobFrom";
            this.pnlCustomJobFrom.Size = new System.Drawing.Size(335, 109);
            this.pnlCustomJobFrom.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Company";
            // 
            // dropFromCompany
            // 
            this.dropFromCompany.DropDownHeight = 240;
            this.dropFromCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropFromCompany.FormattingEnabled = true;
            this.dropFromCompany.IntegralHeight = false;
            this.dropFromCompany.Location = new System.Drawing.Point(11, 71);
            this.dropFromCompany.Name = "dropFromCompany";
            this.dropFromCompany.Size = new System.Drawing.Size(192, 27);
            this.dropFromCompany.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "FROM";
            // 
            // dropFromLocation
            // 
            this.dropFromLocation.DropDownHeight = 240;
            this.dropFromLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropFromLocation.FormattingEnabled = true;
            this.dropFromLocation.IntegralHeight = false;
            this.dropFromLocation.Location = new System.Drawing.Point(11, 38);
            this.dropFromLocation.Name = "dropFromLocation";
            this.dropFromLocation.Size = new System.Drawing.Size(192, 27);
            this.dropFromLocation.TabIndex = 17;
            this.dropFromLocation.SelectedIndexChanged += new System.EventHandler(this.FromLocationIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Location";
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(2, 344);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(335, 27);
            this.btnAddJob.TabIndex = 22;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.BtnAddJob_Click);
            // 
            // lblIngameTime
            // 
            this.lblIngameTime.AutoSize = true;
            this.lblIngameTime.Location = new System.Drawing.Point(9, 501);
            this.lblIngameTime.Name = "lblIngameTime";
            this.lblIngameTime.Size = new System.Drawing.Size(112, 19);
            this.lblIngameTime.TabIndex = 35;
            this.lblIngameTime.Text = "Current Time:";
            // 
            // frmEuroTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 741);
            this.Controls.Add(this.tabsTracker);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEuroTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EuroTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEuroTracker_FormClosing);
            this.Load += new System.EventHandler(this.SetupAddJob);
            this.tabsTracker.ResumeLayout(false);
            this.tabDamage.ResumeLayout(false);
            this.tabDamage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrailerDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTransmissionDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWheelsDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCabinDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEngineDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChassisDamage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.pnlCustomJob.ResumeLayout(false);
            this.pnlCustomJob.PerformLayout();
            this.pnlCustomJobCargo.ResumeLayout(false);
            this.pnlCustomJobCargo.PerformLayout();
            this.pnlCustomJobTo.ResumeLayout(false);
            this.pnlCustomJobTo.PerformLayout();
            this.pnlCustomJobFrom.ResumeLayout(false);
            this.pnlCustomJobFrom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabsTracker;
        private System.Windows.Forms.TabPage tabDamage;
        private System.Windows.Forms.Label lblChassisDamageTitle;
        private System.Windows.Forms.Label lblChassisDamage;
        private System.Windows.Forms.PictureBox imgChassisDamage;
        private System.Windows.Forms.Label lblEngineDamageTitle;
        private System.Windows.Forms.Label lblEngineDamage;
        private System.Windows.Forms.PictureBox imgEngineDamage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTransmissionDamageTitle;
        private System.Windows.Forms.Label lblTransmissionDamage;
        private System.Windows.Forms.PictureBox imgTransmissionDamage;
        private System.Windows.Forms.Label lblWheelsDamageTitle;
        private System.Windows.Forms.Label lblWheelsDamage;
        private System.Windows.Forms.PictureBox imgWheelsDamage;
        private System.Windows.Forms.Label lblCabinDamageTitle;
        private System.Windows.Forms.Label lblCabinDamage;
        private System.Windows.Forms.PictureBox imgCabinDamage;
        private System.Windows.Forms.Label lblTrailerDamageTitle;
        private System.Windows.Forms.Label lblTrailerDamage;
        private System.Windows.Forms.PictureBox imgTrailerDamage;
        private System.Windows.Forms.Panel pnlCustomJob;
        private System.Windows.Forms.Panel pnlCustomJobCargo;
        private System.Windows.Forms.ComboBox dropCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCustomJobTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropToCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dropToLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlCustomJobFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dropFromCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dropFromLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCurSpeed;
        private System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.Label lblIngameTime;
    }
}

