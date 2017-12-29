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
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTruck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabsTracker.SuspendLayout();
            this.tabDamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEngineDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChassisDamage)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabsTracker.Location = new System.Drawing.Point(0, 48);
            this.tabsTracker.Name = "tabsTracker";
            this.tabsTracker.SelectedIndex = 0;
            this.tabsTracker.Size = new System.Drawing.Size(728, 420);
            this.tabsTracker.TabIndex = 2;
            // 
            // tabDamage
            // 
            this.tabDamage.Controls.Add(this.lblEngineDamageTitle);
            this.tabDamage.Controls.Add(this.lblEngineDamage);
            this.tabDamage.Controls.Add(this.imgEngineDamage);
            this.tabDamage.Controls.Add(this.lblChassisDamageTitle);
            this.tabDamage.Controls.Add(this.lblChassisDamage);
            this.tabDamage.Controls.Add(this.imgChassisDamage);
            this.tabDamage.Location = new System.Drawing.Point(4, 28);
            this.tabDamage.Name = "tabDamage";
            this.tabDamage.Padding = new System.Windows.Forms.Padding(3);
            this.tabDamage.Size = new System.Drawing.Size(720, 388);
            this.tabDamage.TabIndex = 0;
            this.tabDamage.Text = "Damage";
            this.tabDamage.UseVisualStyleBackColor = true;
            // 
            // lblEngineDamageTitle
            // 
            this.lblEngineDamageTitle.AutoSize = true;
            this.lblEngineDamageTitle.Location = new System.Drawing.Point(158, 4);
            this.lblEngineDamageTitle.Name = "lblEngineDamageTitle";
            this.lblEngineDamageTitle.Size = new System.Drawing.Size(127, 19);
            this.lblEngineDamageTitle.TabIndex = 20;
            this.lblEngineDamageTitle.Text = "Engine Damage";
            // 
            // lblEngineDamage
            // 
            this.lblEngineDamage.AutoSize = true;
            this.lblEngineDamage.Location = new System.Drawing.Point(204, 361);
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
            this.imgEngineDamage.Size = new System.Drawing.Size(75, 332);
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
            this.lblChassisDamage.Location = new System.Drawing.Point(49, 361);
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
            this.imgChassisDamage.Size = new System.Drawing.Size(75, 332);
            this.imgChassisDamage.TabIndex = 15;
            this.imgChassisDamage.TabStop = false;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(15, 18);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(192, 26);
            this.txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(15, 72);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(192, 26);
            this.txtTo.TabIndex = 1;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(15, 126);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(192, 26);
            this.txtCargo.TabIndex = 2;
            // 
            // txtTruck
            // 
            this.txtTruck.Location = new System.Drawing.Point(15, 176);
            this.txtTruck.Name = "txtTruck";
            this.txtTruck.Size = new System.Drawing.Size(192, 26);
            this.txtTruck.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Truck";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddJob);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtTruck);
            this.tabPage2.Controls.Add(this.txtCargo);
            this.tabPage2.Controls.Add(this.txtTo);
            this.tabPage2.Controls.Add(this.txtFrom);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Job";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmEuroTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 468);
            this.Controls.Add(this.tabsTracker);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEuroTracker";
            this.Text = "EuroTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEuroTracker_FormClosing);
            this.tabsTracker.ResumeLayout(false);
            this.tabDamage.ResumeLayout(false);
            this.tabDamage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEngineDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChassisDamage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
    }
}

