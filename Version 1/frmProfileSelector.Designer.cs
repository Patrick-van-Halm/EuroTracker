namespace Version_1
{
    partial class frmProfileSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfileSelector));
            this.listboxProfiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listboxProfiles
            // 
            this.listboxProfiles.FormattingEnabled = true;
            this.listboxProfiles.ItemHeight = 19;
            this.listboxProfiles.Location = new System.Drawing.Point(0, 0);
            this.listboxProfiles.Name = "listboxProfiles";
            this.listboxProfiles.Size = new System.Drawing.Size(285, 289);
            this.listboxProfiles.TabIndex = 0;
            this.listboxProfiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ListboxProfiles_KeyUp);
            this.listboxProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListboxProfiles_MouseDoubleClick);
            // 
            // frmProfileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 290);
            this.Controls.Add(this.listboxProfiles);
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfileSelector";
            this.Text = "Select Your Profile";
            this.Load += new System.EventHandler(this.FrmProfileSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listboxProfiles;
    }
}