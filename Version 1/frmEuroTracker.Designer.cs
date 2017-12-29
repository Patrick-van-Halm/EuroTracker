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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabsTracker = new System.Windows.Forms.TabControl();
            this.tabDamage = new System.Windows.Forms.TabPage();
            this.lblEngineDamageTitle = new System.Windows.Forms.Label();
            this.lblEngineDamage = new System.Windows.Forms.Label();
            this.imgEngineDamage = new System.Windows.Forms.PictureBox();
            this.lblChassisDamageTitle = new System.Windows.Forms.Label();
            this.lblChassisDamage = new System.Windows.Forms.Label();
            this.imgChassisDamage = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dropCargo = new System.Windows.Forms.ComboBox();
            this.dropTo = new System.Windows.Forms.ComboBox();
            this.dropFrom = new System.Windows.Forms.ComboBox();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTruck = new System.Windows.Forms.TextBox();
            this.lblCabinDamageTitle = new System.Windows.Forms.Label();
            this.lblCabinDamage = new System.Windows.Forms.Label();
            this.imgCabinDamage = new System.Windows.Forms.PictureBox();
            this.lblWheelsDamageTitle = new System.Windows.Forms.Label();
            this.lblWheelsDamage = new System.Windows.Forms.Label();
            this.imgWheelsDamage = new System.Windows.Forms.PictureBox();
            this.lblTransmissionDamageTitle = new System.Windows.Forms.Label();
            this.lblTransmissionDamage = new System.Windows.Forms.Label();
            this.imgTransmissionDamage = new System.Windows.Forms.PictureBox();
            this.lblTrailerDamageTitle = new System.Windows.Forms.Label();
            this.lblTrailerDamage = new System.Windows.Forms.Label();
            this.imgTrailerDamage = new System.Windows.Forms.PictureBox();
            this.tabsTracker.SuspendLayout();
            this.tabDamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEngineDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChassisDamage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCabinDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWheelsDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTransmissionDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrailerDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
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
            this.tabsTracker.Location = new System.Drawing.Point(0, 43);
            this.tabsTracker.Name = "tabsTracker";
            this.tabsTracker.SelectedIndex = 0;
            this.tabsTracker.Size = new System.Drawing.Size(941, 420);
            this.tabsTracker.TabIndex = 2;
            // 
            // tabDamage
            // 
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
            this.tabDamage.Size = new System.Drawing.Size(933, 388);
            this.tabDamage.TabIndex = 0;
            this.tabDamage.Text = "Damage";
            this.tabDamage.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.dropCargo);
            this.tabPage2.Controls.Add(this.dropTo);
            this.tabPage2.Controls.Add(this.dropFrom);
            this.tabPage2.Controls.Add(this.btnAddJob);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtTruck);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Job";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dropCargo
            // 
            this.dropCargo.DropDownHeight = 240;
            this.dropCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropCargo.FormattingEnabled = true;
            this.dropCargo.IntegralHeight = false;
            this.dropCargo.Location = new System.Drawing.Point(15, 126);
            this.dropCargo.Name = "dropCargo";
            this.dropCargo.Size = new System.Drawing.Size(192, 27);
            this.dropCargo.TabIndex = 13;
            // 
            // dropTo
            // 
            this.dropTo.DropDownHeight = 240;
            this.dropTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropTo.FormattingEnabled = true;
            this.dropTo.IntegralHeight = false;
            this.dropTo.Location = new System.Drawing.Point(15, 72);
            this.dropTo.Name = "dropTo";
            this.dropTo.Size = new System.Drawing.Size(192, 27);
            this.dropTo.TabIndex = 12;
            // 
            // dropFrom
            // 
            this.dropFrom.DropDownHeight = 240;
            this.dropFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropFrom.FormattingEnabled = true;
            this.dropFrom.IntegralHeight = false;
            this.dropFrom.Location = new System.Drawing.Point(15, 18);
            this.dropFrom.Name = "dropFrom";
            this.dropFrom.Size = new System.Drawing.Size(192, 27);
            this.dropFrom.TabIndex = 11;
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(15, 222);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(285, 34);
            this.btnAddJob.TabIndex = 10;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.BtnAddJob_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Truck";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // txtTruck
            // 
            this.txtTruck.Location = new System.Drawing.Point(15, 176);
            this.txtTruck.Name = "txtTruck";
            this.txtTruck.Size = new System.Drawing.Size(192, 26);
            this.txtTruck.TabIndex = 4;
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
            // frmEuroTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 463);
            this.Controls.Add(this.tabsTracker);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            ((System.ComponentModel.ISupportInitialize)(this.imgEngineDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChassisDamage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCabinDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWheelsDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTransmissionDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrailerDamage)).EndInit();
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
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTruck;
        private System.Windows.Forms.ComboBox dropCargo;
        private System.Windows.Forms.ComboBox dropTo;
        private System.Windows.Forms.ComboBox dropFrom;
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
    }
}

