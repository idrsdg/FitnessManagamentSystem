namespace Gym_Manager
{
    partial class adminpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanel));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.resTotalDataGridView = new System.Windows.Forms.DataGridView();
            this.reservationPage = new MetroFramework.Controls.MetroTabPage();
            this.rightMPanel = new MetroFramework.Controls.MetroPanel();
            this.userComboBox = new MetroFramework.Controls.MetroComboBox();
            this.newButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.middlePanel = new MetroFramework.Controls.MetroPanel();
            this.addingservicesButton = new MetroFramework.Controls.MetroButton();
            this.finalizeButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.entryLabel = new MetroFramework.Controls.MetroLabel();
            this.leftMPanel = new MetroFramework.Controls.MetroPanel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.yearTextBox = new MetroFramework.Controls.MetroTextBox();
            this.monthComboBox = new MetroFramework.Controls.MetroComboBox();
            this.genderComboBox = new MetroFramework.Controls.MetroComboBox();
            this.dayComboBox = new MetroFramework.Controls.MetroComboBox();
            this.birthdayLabel = new MetroFramework.Controls.MetroLabel();
            this.phoneNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.genderLabel = new MetroFramework.Controls.MetroLabel();
            this.zipTextBox = new MetroFramework.Controls.MetroTextBox();
            this.phoneNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cityComboBox = new MetroFramework.Controls.MetroComboBox();
            this.surnameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.countyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.aptTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addressTextBox = new MetroFramework.Controls.MetroTextBox();
            this.resPanel = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resTotalDataGridView)).BeginInit();
            this.reservationPage.SuspendLayout();
            this.rightMPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.leftMPanel.SuspendLayout();
            this.resPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.Controls.Add(this.resTotalDataGridView);
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(976, 440);
            this.metroTabPage2.TabIndex = 3;
            this.metroTabPage2.Text = "User Information";
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // resTotalDataGridView
            // 
            this.resTotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resTotalDataGridView.Location = new System.Drawing.Point(0, 3);
            this.resTotalDataGridView.Name = "resTotalDataGridView";
            this.resTotalDataGridView.Size = new System.Drawing.Size(976, 434);
            this.resTotalDataGridView.TabIndex = 2;
            // 
            // reservationPage
            // 
            this.reservationPage.Controls.Add(this.rightMPanel);
            this.reservationPage.Controls.Add(this.middlePanel);
            this.reservationPage.Controls.Add(this.leftMPanel);
            this.reservationPage.HorizontalScrollbarBarColor = true;
            this.reservationPage.HorizontalScrollbarHighlightOnWheel = false;
            this.reservationPage.HorizontalScrollbarSize = 10;
            this.reservationPage.Location = new System.Drawing.Point(4, 38);
            this.reservationPage.Name = "reservationPage";
            this.reservationPage.Size = new System.Drawing.Size(976, 440);
            this.reservationPage.Style = MetroFramework.MetroColorStyle.Green;
            this.reservationPage.TabIndex = 0;
            this.reservationPage.Text = "Add - Update User";
            this.reservationPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reservationPage.VerticalScrollbarBarColor = true;
            this.reservationPage.VerticalScrollbarHighlightOnWheel = false;
            this.reservationPage.VerticalScrollbarSize = 10;
            // 
            // rightMPanel
            // 
            this.rightMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rightMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightMPanel.Controls.Add(this.userComboBox);
            this.rightMPanel.Controls.Add(this.newButton);
            this.rightMPanel.Controls.Add(this.deleteButton);
            this.rightMPanel.Controls.Add(this.editButton);
            this.rightMPanel.Controls.Add(this.updateButton);
            this.rightMPanel.HorizontalScrollbarBarColor = true;
            this.rightMPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.rightMPanel.HorizontalScrollbarSize = 10;
            this.rightMPanel.Location = new System.Drawing.Point(708, 14);
            this.rightMPanel.Name = "rightMPanel";
            this.rightMPanel.Size = new System.Drawing.Size(265, 421);
            this.rightMPanel.TabIndex = 34;
            this.rightMPanel.UseCustomBackColor = true;
            this.rightMPanel.UseCustomForeColor = true;
            this.rightMPanel.UseStyleColors = true;
            this.rightMPanel.VerticalScrollbarBarColor = true;
            this.rightMPanel.VerticalScrollbarHighlightOnWheel = false;
            this.rightMPanel.VerticalScrollbarSize = 10;
            // 
            // userComboBox
            // 
            this.userComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userComboBox.ForeColor = System.Drawing.Color.Green;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.ItemHeight = 23;
            this.userComboBox.Items.AddRange(new object[] {
            "[ID]    [NAME]    [PHONE NUMBER]"});
            this.userComboBox.Location = new System.Drawing.Point(10, 30);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.PromptText = "Select user to edit";
            this.userComboBox.Size = new System.Drawing.Size(252, 29);
            this.userComboBox.TabIndex = 20;
            this.userComboBox.UseCustomForeColor = true;
            this.userComboBox.UseSelectable = true;
            this.userComboBox.UseStyleColors = true;
            this.userComboBox.Visible = false;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(10, 375);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(245, 32);
            this.newButton.Style = MetroFramework.MetroColorStyle.Green;
            this.newButton.TabIndex = 22;
            this.newButton.Text = "New user";
            this.newButton.UseSelectable = true;
            this.newButton.UseStyleColors = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Highlight = true;
            this.deleteButton.Location = new System.Drawing.Point(10, 288);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(245, 34);
            this.deleteButton.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteButton.UseSelectable = true;
            this.deleteButton.UseStyleColors = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(10, 335);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(245, 32);
            this.editButton.Style = MetroFramework.MetroColorStyle.Green;
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit existing User";
            this.editButton.UseSelectable = true;
            this.editButton.UseStyleColors = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Highlight = true;
            this.updateButton.Location = new System.Drawing.Point(10, 245);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(245, 34);
            this.updateButton.Style = MetroFramework.MetroColorStyle.Green;
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateButton.UseSelectable = true;
            this.updateButton.UseStyleColors = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.middlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.middlePanel.Controls.Add(this.addingservicesButton);
            this.middlePanel.Controls.Add(this.finalizeButton);
            this.middlePanel.Controls.Add(this.metroLabel12);
            this.middlePanel.Controls.Add(this.submitButton);
            this.middlePanel.Controls.Add(this.endDatePicker);
            this.middlePanel.Controls.Add(this.startDatePicker);
            this.middlePanel.Controls.Add(this.entryLabel);
            this.middlePanel.HorizontalScrollbarBarColor = true;
            this.middlePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.middlePanel.HorizontalScrollbarSize = 10;
            this.middlePanel.Location = new System.Drawing.Point(355, 14);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(345, 421);
            this.middlePanel.TabIndex = 16;
            this.middlePanel.UseCustomBackColor = true;
            this.middlePanel.UseCustomForeColor = true;
            this.middlePanel.UseStyleColors = true;
            this.middlePanel.VerticalScrollbarBarColor = true;
            this.middlePanel.VerticalScrollbarHighlightOnWheel = false;
            this.middlePanel.VerticalScrollbarSize = 10;
            // 
            // addingservicesButton
            // 
            this.addingservicesButton.Location = new System.Drawing.Point(16, 300);
            this.addingservicesButton.Name = "addingservicesButton";
            this.addingservicesButton.Size = new System.Drawing.Size(314, 31);
            this.addingservicesButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addingservicesButton.TabIndex = 33;
            this.addingservicesButton.Text = "Adding Services";
            this.addingservicesButton.UseSelectable = true;
            this.addingservicesButton.UseStyleColors = true;
            this.addingservicesButton.Click += new System.EventHandler(this.addingservicesButton_Click);
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(16, 337);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(314, 31);
            this.finalizeButton.Style = MetroFramework.MetroColorStyle.Green;
            this.finalizeButton.TabIndex = 22;
            this.finalizeButton.Text = "Finalize bill";
            this.finalizeButton.UseSelectable = true;
            this.finalizeButton.UseStyleColors = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(16, 79);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(65, 19);
            this.metroLabel12.TabIndex = 32;
            this.metroLabel12.Text = "End Date";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Highlight = true;
            this.submitButton.Location = new System.Drawing.Point(16, 372);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(314, 36);
            this.submitButton.Style = MetroFramework.MetroColorStyle.Green;
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Submit";
            this.submitButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.submitButton.UseSelectable = true;
            this.submitButton.UseStyleColors = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.CustomFormat = "dd.MM.yyyy";
            this.endDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(16, 101);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(316, 26);
            this.endDatePicker.TabIndex = 31;
            this.endDatePicker.Value = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // startDatePicker
            // 
            this.startDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.CustomFormat = "dd.MM.yyyy";
            this.startDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(16, 50);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(314, 26);
            this.startDatePicker.TabIndex = 26;
            this.startDatePicker.Value = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            // 
            // entryLabel
            // 
            this.entryLabel.AutoSize = true;
            this.entryLabel.BackColor = System.Drawing.Color.Transparent;
            this.entryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.entryLabel.Location = new System.Drawing.Point(16, 28);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(71, 19);
            this.entryLabel.TabIndex = 30;
            this.entryLabel.Text = "Start Date";
            this.entryLabel.UseCustomBackColor = true;
            this.entryLabel.UseCustomForeColor = true;
            // 
            // leftMPanel
            // 
            this.leftMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.leftMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftMPanel.Controls.Add(this.emailLabel);
            this.leftMPanel.Controls.Add(this.nameLabel);
            this.leftMPanel.Controls.Add(this.emailTextBox);
            this.leftMPanel.Controls.Add(this.yearTextBox);
            this.leftMPanel.Controls.Add(this.monthComboBox);
            this.leftMPanel.Controls.Add(this.genderComboBox);
            this.leftMPanel.Controls.Add(this.dayComboBox);
            this.leftMPanel.Controls.Add(this.birthdayLabel);
            this.leftMPanel.Controls.Add(this.phoneNumberLabel);
            this.leftMPanel.Controls.Add(this.nameTextBox);
            this.leftMPanel.Controls.Add(this.genderLabel);
            this.leftMPanel.Controls.Add(this.zipTextBox);
            this.leftMPanel.Controls.Add(this.phoneNumberTextBox);
            this.leftMPanel.Controls.Add(this.cityComboBox);
            this.leftMPanel.Controls.Add(this.surnameTextBox);
            this.leftMPanel.Controls.Add(this.countyTextBox);
            this.leftMPanel.Controls.Add(this.metroLabel6);
            this.leftMPanel.Controls.Add(this.aptTextBox);
            this.leftMPanel.Controls.Add(this.addressTextBox);
            this.leftMPanel.HorizontalScrollbarBarColor = true;
            this.leftMPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.leftMPanel.HorizontalScrollbarSize = 10;
            this.leftMPanel.Location = new System.Drawing.Point(3, 15);
            this.leftMPanel.Name = "leftMPanel";
            this.leftMPanel.Size = new System.Drawing.Size(345, 421);
            this.leftMPanel.TabIndex = 4;
            this.leftMPanel.UseCustomBackColor = true;
            this.leftMPanel.UseCustomForeColor = true;
            this.leftMPanel.UseStyleColors = true;
            this.leftMPanel.VerticalScrollbarBarColor = true;
            this.leftMPanel.VerticalScrollbarHighlightOnWheel = false;
            this.leftMPanel.VerticalScrollbarSize = 10;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.emailLabel.Location = new System.Drawing.Point(15, 225);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(130, 19);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Your e-mail address";
            this.emailLabel.UseCustomBackColor = true;
            this.emailLabel.UseCustomForeColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nameLabel.Location = new System.Drawing.Point(14, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 19);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            this.nameLabel.UseCustomBackColor = true;
            this.nameLabel.UseCustomForeColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(15, 247);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PromptText = "first.last@example.com";
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(316, 29);
            this.emailTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.UseCustomBackColor = true;
            this.emailTextBox.UseSelectable = true;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.White;
            this.yearTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.yearTextBox.Lines = new string[0];
            this.yearTextBox.Location = new System.Drawing.Point(230, 84);
            this.yearTextBox.MaxLength = 32767;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.PasswordChar = '\0';
            this.yearTextBox.PromptText = "Year";
            this.yearTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.yearTextBox.SelectedText = "";
            this.yearTextBox.Size = new System.Drawing.Size(101, 29);
            this.yearTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.yearTextBox.TabIndex = 5;
            this.yearTextBox.UseCustomBackColor = true;
            this.yearTextBox.UseSelectable = true;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.ItemHeight = 23;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(104, 84);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.PromptText = "Month";
            this.monthComboBox.Size = new System.Drawing.Size(120, 29);
            this.monthComboBox.TabIndex = 4;
            this.monthComboBox.UseSelectable = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.ItemHeight = 23;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.genderComboBox.Location = new System.Drawing.Point(15, 140);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.PromptText = "........";
            this.genderComboBox.Size = new System.Drawing.Size(315, 29);
            this.genderComboBox.TabIndex = 6;
            this.genderComboBox.UseSelectable = true;
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.ItemHeight = 23;
            this.dayComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(15, 84);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.PromptText = "Day";
            this.dayComboBox.Size = new System.Drawing.Size(83, 29);
            this.dayComboBox.TabIndex = 3;
            this.dayComboBox.UseSelectable = true;
            this.dayComboBox.SelectedIndexChanged += new System.EventHandler(this.dayComboBox_SelectedIndexChanged);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthdayLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.birthdayLabel.Location = new System.Drawing.Point(12, 63);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(60, 19);
            this.birthdayLabel.TabIndex = 5;
            this.birthdayLabel.Text = "Birthday";
            this.birthdayLabel.UseCustomBackColor = true;
            this.birthdayLabel.UseCustomForeColor = true;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.phoneNumberLabel.Location = new System.Drawing.Point(14, 171);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(100, 19);
            this.phoneNumberLabel.TabIndex = 12;
            this.phoneNumberLabel.Text = "Phone number";
            this.phoneNumberLabel.UseCustomBackColor = true;
            this.phoneNumberLabel.UseCustomForeColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(15, 27);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PromptText = "First";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(155, 29);
            this.nameTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.UseCustomBackColor = true;
            this.nameTextBox.UseSelectable = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.genderLabel.Location = new System.Drawing.Point(13, 118);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 19);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "Gender";
            this.genderLabel.UseCustomBackColor = true;
            this.genderLabel.UseCustomForeColor = true;
            // 
            // zipTextBox
            // 
            this.zipTextBox.BackColor = System.Drawing.Color.White;
            this.zipTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.zipTextBox.Lines = new string[0];
            this.zipTextBox.Location = new System.Drawing.Point(172, 378);
            this.zipTextBox.MaxLength = 32767;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.PasswordChar = '\0';
            this.zipTextBox.PromptText = "Zip code";
            this.zipTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.zipTextBox.SelectedText = "";
            this.zipTextBox.Size = new System.Drawing.Size(159, 29);
            this.zipTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.zipTextBox.TabIndex = 13;
            this.zipTextBox.UseCustomBackColor = true;
            this.zipTextBox.UseSelectable = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.phoneNumberTextBox.Lines = new string[0];
            this.phoneNumberTextBox.Location = new System.Drawing.Point(14, 193);
            this.phoneNumberTextBox.MaxLength = 32767;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PasswordChar = '\0';
            this.phoneNumberTextBox.PromptText = "(500)1234567";
            this.phoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneNumberTextBox.SelectedText = "";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(316, 29);
            this.phoneNumberTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.phoneNumberTextBox.TabIndex = 7;
            this.phoneNumberTextBox.UseCustomBackColor = true;
            this.phoneNumberTextBox.UseSelectable = true;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.ItemHeight = 23;
            this.cityComboBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İçel",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Şırnak",
            "Şanlıurfa",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cityComboBox.Location = new System.Drawing.Point(15, 378);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.PromptText = "City";
            this.cityComboBox.Size = new System.Drawing.Size(150, 29);
            this.cityComboBox.TabIndex = 12;
            this.cityComboBox.UseSelectable = true;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.White;
            this.surnameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.surnameTextBox.Lines = new string[0];
            this.surnameTextBox.Location = new System.Drawing.Point(176, 27);
            this.surnameTextBox.MaxLength = 32767;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.PromptText = "Last";
            this.surnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.Size = new System.Drawing.Size(155, 29);
            this.surnameTextBox.TabIndex = 3;
            this.surnameTextBox.UseCustomBackColor = true;
            this.surnameTextBox.UseSelectable = true;
            // 
            // countyTextBox
            // 
            this.countyTextBox.BackColor = System.Drawing.Color.White;
            this.countyTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.countyTextBox.Lines = new string[0];
            this.countyTextBox.Location = new System.Drawing.Point(171, 336);
            this.countyTextBox.MaxLength = 32767;
            this.countyTextBox.Name = "countyTextBox";
            this.countyTextBox.PasswordChar = '\0';
            this.countyTextBox.PromptText = "County";
            this.countyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.countyTextBox.SelectedText = "";
            this.countyTextBox.Size = new System.Drawing.Size(159, 29);
            this.countyTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.countyTextBox.TabIndex = 11;
            this.countyTextBox.UseCustomBackColor = true;
            this.countyTextBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(14, 247);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Your address";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // aptTextBox
            // 
            this.aptTextBox.BackColor = System.Drawing.Color.White;
            this.aptTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.aptTextBox.Lines = new string[0];
            this.aptTextBox.Location = new System.Drawing.Point(14, 335);
            this.aptTextBox.MaxLength = 32767;
            this.aptTextBox.Name = "aptTextBox";
            this.aptTextBox.PasswordChar = '\0';
            this.aptTextBox.PromptText = "Apt./Suite";
            this.aptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aptTextBox.SelectedText = "";
            this.aptTextBox.Size = new System.Drawing.Size(151, 29);
            this.aptTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.aptTextBox.TabIndex = 10;
            this.aptTextBox.UseCustomBackColor = true;
            this.aptTextBox.UseSelectable = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.White;
            this.addressTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.addressTextBox.Lines = new string[0];
            this.addressTextBox.Location = new System.Drawing.Point(13, 290);
            this.addressTextBox.MaxLength = 32767;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PromptText = "Street address";
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.Size = new System.Drawing.Size(316, 29);
            this.addressTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.addressTextBox.TabIndex = 9;
            this.addressTextBox.UseCustomBackColor = true;
            this.addressTextBox.UseSelectable = true;
            // 
            // resPanel
            // 
            this.resPanel.Controls.Add(this.reservationPage);
            this.resPanel.Controls.Add(this.metroTabPage2);
            this.resPanel.Location = new System.Drawing.Point(8, 59);
            this.resPanel.Name = "resPanel";
            this.resPanel.SelectedIndex = 0;
            this.resPanel.Size = new System.Drawing.Size(984, 482);
            this.resPanel.Style = MetroFramework.MetroColorStyle.Green;
            this.resPanel.TabIndex = 0;
            this.resPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resPanel.UseSelectable = true;
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(998, 545);
            this.Controls.Add(this.resPanel);
            this.Name = "adminpanel";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Admin Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frontend_FormClosing);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resTotalDataGridView)).EndInit();
            this.reservationPage.ResumeLayout(false);
            this.rightMPanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.leftMPanel.ResumeLayout(false);
            this.leftMPanel.PerformLayout();
            this.resPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView resTotalDataGridView;
        private MetroFramework.Controls.MetroTabPage reservationPage;
        private MetroFramework.Controls.MetroPanel rightMPanel;
        private MetroFramework.Controls.MetroComboBox userComboBox;
        private MetroFramework.Controls.MetroButton newButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroPanel middlePanel;
        private MetroFramework.Controls.MetroButton finalizeButton;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton submitButton;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private MetroFramework.Controls.MetroLabel entryLabel;
        private MetroFramework.Controls.MetroPanel leftMPanel;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroTextBox yearTextBox;
        private MetroFramework.Controls.MetroComboBox monthComboBox;
        private MetroFramework.Controls.MetroComboBox genderComboBox;
        private MetroFramework.Controls.MetroLabel birthdayLabel;
        private MetroFramework.Controls.MetroComboBox dayComboBox;
        private MetroFramework.Controls.MetroLabel phoneNumberLabel;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroTextBox zipTextBox;
        private MetroFramework.Controls.MetroTextBox phoneNumberTextBox;
        private MetroFramework.Controls.MetroComboBox cityComboBox;
        private MetroFramework.Controls.MetroTextBox surnameTextBox;
        private MetroFramework.Controls.MetroTextBox countyTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox aptTextBox;
        private MetroFramework.Controls.MetroTextBox addressTextBox;
        private MetroFramework.Controls.MetroTabControl resPanel;
        private MetroFramework.Controls.MetroButton addingservicesButton;
    }
}