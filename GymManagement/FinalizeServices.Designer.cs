namespace Gym_Manager
{
    partial class FinalizeServices
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
            this.nextButton = new MetroFramework.Controls.MetroButton();
            this.currentBillAmount = new MetroFramework.Controls.MetroLabel();
            this.priceLabel = new MetroFramework.Controls.MetroLabel();
            this.currentBill = new MetroFramework.Controls.MetroLabel();
            this.programsComboBox = new MetroFramework.Controls.MetroComboBox();
            this.totalLabel = new MetroFramework.Controls.MetroLabel();
            this.totalAmount = new MetroFramework.Controls.MetroLabel();
            this.proteincheckBox = new System.Windows.Forms.CheckBox();
            this.fatcheckBox = new System.Windows.Forms.CheckBox();
            this.vitamincheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(340, 214);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(88, 34);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseSelectable = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // currentBillAmount
            // 
            this.currentBillAmount.AutoSize = true;
            this.currentBillAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentBillAmount.Location = new System.Drawing.Point(356, 48);
            this.currentBillAmount.Name = "currentBillAmount";
            this.currentBillAmount.Size = new System.Drawing.Size(17, 19);
            this.currentBillAmount.TabIndex = 2;
            this.currentBillAmount.Text = "$";
            this.currentBillAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.priceLabel.Location = new System.Drawing.Point(390, 25);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(38, 19);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // currentBill
            // 
            this.currentBill.AutoSize = true;
            this.currentBill.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentBill.Location = new System.Drawing.Point(14, 48);
            this.currentBill.Name = "currentBill";
            this.currentBill.Size = new System.Drawing.Size(77, 19);
            this.currentBill.TabIndex = 4;
            this.currentBill.Text = "Current bill";
            // 
            // programsComboBox
            // 
            this.programsComboBox.FormattingEnabled = true;
            this.programsComboBox.ItemHeight = 23;
            this.programsComboBox.Location = new System.Drawing.Point(14, 124);
            this.programsComboBox.Name = "programsComboBox";
            this.programsComboBox.PromptText = "Choose Program";
            this.programsComboBox.Size = new System.Drawing.Size(148, 29);
            this.programsComboBox.TabIndex = 29;
            this.programsComboBox.UseSelectable = true;
            this.programsComboBox.SelectedIndexChanged += new System.EventHandler(this.programsComboBox_SelectedIndexChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.totalLabel.Location = new System.Drawing.Point(281, 164);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(42, 19);
            this.totalLabel.TabIndex = 32;
            this.totalLabel.Text = "Total";
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.totalAmount.Location = new System.Drawing.Point(356, 164);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(17, 19);
            this.totalAmount.TabIndex = 33;
            this.totalAmount.Text = "$";
            this.totalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // proteincheckBox
            // 
            this.proteincheckBox.AutoSize = true;
            this.proteincheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.proteincheckBox.Location = new System.Drawing.Point(18, 83);
            this.proteincheckBox.Name = "proteincheckBox";
            this.proteincheckBox.Size = new System.Drawing.Size(105, 21);
            this.proteincheckBox.TabIndex = 40;
            this.proteincheckBox.Text = "Protein Dust";
            this.proteincheckBox.UseVisualStyleBackColor = true;
            // 
            // fatcheckBox
            // 
            this.fatcheckBox.AutoSize = true;
            this.fatcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fatcheckBox.Location = new System.Drawing.Point(120, 83);
            this.fatcheckBox.Name = "fatcheckBox";
            this.fatcheckBox.Size = new System.Drawing.Size(94, 21);
            this.fatcheckBox.TabIndex = 41;
            this.fatcheckBox.Text = "Fat Burner";
            this.fatcheckBox.UseVisualStyleBackColor = true;
            // 
            // vitamincheckBox
            // 
            this.vitamincheckBox.AutoSize = true;
            this.vitamincheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.vitamincheckBox.Location = new System.Drawing.Point(214, 83);
            this.vitamincheckBox.Name = "vitamincheckBox";
            this.vitamincheckBox.Size = new System.Drawing.Size(73, 21);
            this.vitamincheckBox.TabIndex = 42;
            this.vitamincheckBox.Text = "Vitamin";
            this.vitamincheckBox.UseVisualStyleBackColor = true;
            // 
            // FinalizeServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(434, 254);
            this.Controls.Add(this.vitamincheckBox);
            this.Controls.Add(this.fatcheckBox);
            this.Controls.Add(this.proteincheckBox);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.currentBill);
            this.Controls.Add(this.programsComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.currentBillAmount);
            this.Controls.Add(this.nextButton);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalizeServices";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Load += new System.EventHandler(this.FinalizeServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton nextButton;
        private MetroFramework.Controls.MetroLabel currentBillAmount;
        private MetroFramework.Controls.MetroLabel priceLabel;
        private MetroFramework.Controls.MetroLabel currentBill;
        private MetroFramework.Controls.MetroLabel totalLabel;
        private MetroFramework.Controls.MetroLabel totalAmount;
        public MetroFramework.Controls.MetroComboBox programsComboBox;
        private System.Windows.Forms.CheckBox proteincheckBox;
        private System.Windows.Forms.CheckBox fatcheckBox;
        private System.Windows.Forms.CheckBox vitamincheckBox;
    }
}