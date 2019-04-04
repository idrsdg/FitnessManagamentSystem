namespace Gym_Manager
{
    partial class License
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
            this.LicenseText = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LicenseText
            // 
            this.LicenseText.AutoSize = true;
            this.LicenseText.Location = new System.Drawing.Point(2, 7);
            this.LicenseText.Name = "LicenseText";
            this.LicenseText.Size = new System.Drawing.Size(134, 76);
            this.LicenseText.TabIndex = 0;
            this.LicenseText.Text = "GYM MANAGEMENT\r\n\r\n\r\n";
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 257);
            this.Controls.Add(this.LicenseText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "License";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LicenseText;
    }
}