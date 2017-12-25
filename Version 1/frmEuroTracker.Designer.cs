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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEXP = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblTruck = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.imgDamage = new System.Windows.Forms.PictureBox();
            this.lblDamagePercentage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDamage)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDamagePercentage);
            this.panel1.Controls.Add(this.imgDamage);
            this.panel1.Controls.Add(this.lblEXP);
            this.panel1.Controls.Add(this.lblMoney);
            this.panel1.Controls.Add(this.lblDistance);
            this.panel1.Controls.Add(this.lblTarget);
            this.panel1.Controls.Add(this.lblTruck);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.lblFuel);
            this.panel1.Location = new System.Drawing.Point(-1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 424);
            this.panel1.TabIndex = 1;
            // 
            // lblEXP
            // 
            this.lblEXP.AutoSize = true;
            this.lblEXP.Location = new System.Drawing.Point(3, 102);
            this.lblEXP.Name = "lblEXP";
            this.lblEXP.Size = new System.Drawing.Size(98, 19);
            this.lblEXP.TabIndex = 11;
            this.lblEXP.Text = "Experience:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(3, 74);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(64, 19);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "Money:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(3, 235);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(77, 19);
            this.lblDistance.TabIndex = 9;
            this.lblDistance.Text = "Distance:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(3, 207);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(63, 19);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "Target:";
            // 
            // lblTruck
            // 
            this.lblTruck.AutoSize = true;
            this.lblTruck.Location = new System.Drawing.Point(3, 178);
            this.lblTruck.Name = "lblTruck";
            this.lblTruck.Size = new System.Drawing.Size(56, 19);
            this.lblTruck.TabIndex = 4;
            this.lblTruck.Text = "Truck:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(3, 149);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(61, 19);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(3, 45);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(70, 19);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position:";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(3, 13);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(45, 19);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Fuel:";
            // 
            // imgDamage
            // 
            this.imgDamage.BackColor = System.Drawing.Color.White;
            this.imgDamage.Location = new System.Drawing.Point(543, 45);
            this.imgDamage.Name = "imgDamage";
            this.imgDamage.Size = new System.Drawing.Size(41, 209);
            this.imgDamage.TabIndex = 12;
            this.imgDamage.TabStop = false;
            // 
            // lblDamagePercentage
            // 
            this.lblDamagePercentage.AutoSize = true;
            this.lblDamagePercentage.Location = new System.Drawing.Point(538, 257);
            this.lblDamagePercentage.Name = "lblDamagePercentage";
            this.lblDamagePercentage.Size = new System.Drawing.Size(52, 19);
            this.lblDamagePercentage.TabIndex = 13;
            this.lblDamagePercentage.Text = "100%";
            // 
            // frmEuroTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEuroTracker";
            this.Text = "EuroTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEuroTracker_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblTruck;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblEXP;
        private System.Windows.Forms.PictureBox imgDamage;
        private System.Windows.Forms.Label lblDamagePercentage;
    }
}

