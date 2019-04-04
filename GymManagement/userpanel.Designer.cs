namespace Gym_Manager
{
    partial class userpanel
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
            this.UserTabControl = new MetroFramework.Controls.MetroTabControl();
            this.ProfileTabPage = new MetroFramework.Controls.MetroTabPage();
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
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.ProgramandServicesTabPage = new MetroFramework.Controls.MetroTabPage();
            this.programnameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.programname = new System.Windows.Forms.Label();
            this.programlabel = new System.Windows.Forms.Label();
            this.programdescTextbox = new MetroFramework.Controls.MetroTextBox();
            this.UserTabControl.SuspendLayout();
            this.ProfileTabPage.SuspendLayout();
            this.ProgramandServicesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.ProfileTabPage);
            this.UserTabControl.Controls.Add(this.ProgramandServicesTabPage);
            this.UserTabControl.Location = new System.Drawing.Point(11, 63);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(983, 480);
            this.UserTabControl.Style = MetroFramework.MetroColorStyle.Lime;
            this.UserTabControl.TabIndex = 0;
            this.UserTabControl.UseSelectable = true;
            // 
            // ProfileTabPage
            // 
            this.ProfileTabPage.AllowDrop = true;
            this.ProfileTabPage.Controls.Add(this.emailLabel);
            this.ProfileTabPage.Controls.Add(this.nameLabel);
            this.ProfileTabPage.Controls.Add(this.emailTextBox);
            this.ProfileTabPage.Controls.Add(this.yearTextBox);
            this.ProfileTabPage.Controls.Add(this.monthComboBox);
            this.ProfileTabPage.Controls.Add(this.genderComboBox);
            this.ProfileTabPage.Controls.Add(this.dayComboBox);
            this.ProfileTabPage.Controls.Add(this.birthdayLabel);
            this.ProfileTabPage.Controls.Add(this.phoneNumberLabel);
            this.ProfileTabPage.Controls.Add(this.nameTextBox);
            this.ProfileTabPage.Controls.Add(this.genderLabel);
            this.ProfileTabPage.Controls.Add(this.zipTextBox);
            this.ProfileTabPage.Controls.Add(this.phoneNumberTextBox);
            this.ProfileTabPage.Controls.Add(this.cityComboBox);
            this.ProfileTabPage.Controls.Add(this.surnameTextBox);
            this.ProfileTabPage.Controls.Add(this.countyTextBox);
            this.ProfileTabPage.Controls.Add(this.metroLabel6);
            this.ProfileTabPage.Controls.Add(this.aptTextBox);
            this.ProfileTabPage.Controls.Add(this.addressTextBox);
            this.ProfileTabPage.Controls.Add(this.updateButton);
            this.ProfileTabPage.HorizontalScrollbarBarColor = true;
            this.ProfileTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ProfileTabPage.HorizontalScrollbarSize = 10;
            this.ProfileTabPage.Location = new System.Drawing.Point(4, 38);
            this.ProfileTabPage.Name = "ProfileTabPage";
            this.ProfileTabPage.Size = new System.Drawing.Size(975, 438);
            this.ProfileTabPage.Style = MetroFramework.MetroColorStyle.Lime;
            this.ProfileTabPage.TabIndex = 0;
            this.ProfileTabPage.Text = "My Profile";
            this.ProfileTabPage.VerticalScrollbarBarColor = true;
            this.ProfileTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.ProfileTabPage.VerticalScrollbarSize = 10;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.emailLabel.Location = new System.Drawing.Point(4, 228);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(130, 19);
            this.emailLabel.TabIndex = 79;
            this.emailLabel.Text = "Your e-mail address";
            this.emailLabel.UseCustomBackColor = true;
            this.emailLabel.UseCustomForeColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nameLabel.Location = new System.Drawing.Point(3, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 19);
            this.nameLabel.TabIndex = 65;
            this.nameLabel.Text = "Name";
            this.nameLabel.UseCustomBackColor = true;
            this.nameLabel.UseCustomForeColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(4, 250);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PromptText = "first.last@example.com";
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(316, 29);
            this.emailTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.emailTextBox.TabIndex = 71;
            this.emailTextBox.UseCustomBackColor = true;
            this.emailTextBox.UseSelectable = true;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.White;
            this.yearTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.yearTextBox.Lines = new string[0];
            this.yearTextBox.Location = new System.Drawing.Point(219, 87);
            this.yearTextBox.MaxLength = 32767;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.PasswordChar = '\0';
            this.yearTextBox.PromptText = "Year";
            this.yearTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.yearTextBox.SelectedText = "";
            this.yearTextBox.Size = new System.Drawing.Size(101, 29);
            this.yearTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.yearTextBox.TabIndex = 67;
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
            this.monthComboBox.Location = new System.Drawing.Point(93, 87);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.PromptText = "Month";
            this.monthComboBox.Size = new System.Drawing.Size(120, 29);
            this.monthComboBox.TabIndex = 66;
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
            this.genderComboBox.Location = new System.Drawing.Point(4, 143);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.PromptText = "........";
            this.genderComboBox.Size = new System.Drawing.Size(315, 29);
            this.genderComboBox.TabIndex = 69;
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
            this.dayComboBox.Location = new System.Drawing.Point(4, 87);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.PromptText = "Day";
            this.dayComboBox.Size = new System.Drawing.Size(83, 29);
            this.dayComboBox.TabIndex = 63;
            this.dayComboBox.UseSelectable = true;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthdayLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.birthdayLabel.Location = new System.Drawing.Point(1, 66);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(60, 19);
            this.birthdayLabel.TabIndex = 68;
            this.birthdayLabel.Text = "Birthday";
            this.birthdayLabel.UseCustomBackColor = true;
            this.birthdayLabel.UseCustomForeColor = true;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.phoneNumberLabel.Location = new System.Drawing.Point(3, 174);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(100, 19);
            this.phoneNumberLabel.TabIndex = 77;
            this.phoneNumberLabel.Text = "Phone number";
            this.phoneNumberLabel.UseCustomBackColor = true;
            this.phoneNumberLabel.UseCustomForeColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(4, 30);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PromptText = "First";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(155, 29);
            this.nameTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.nameTextBox.TabIndex = 62;
            this.nameTextBox.UseCustomBackColor = true;
            this.nameTextBox.UseSelectable = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.genderLabel.Location = new System.Drawing.Point(2, 121);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 19);
            this.genderLabel.TabIndex = 74;
            this.genderLabel.Text = "Gender";
            this.genderLabel.UseCustomBackColor = true;
            this.genderLabel.UseCustomForeColor = true;
            // 
            // zipTextBox
            // 
            this.zipTextBox.BackColor = System.Drawing.Color.White;
            this.zipTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.zipTextBox.Lines = new string[0];
            this.zipTextBox.Location = new System.Drawing.Point(161, 381);
            this.zipTextBox.MaxLength = 32767;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.PasswordChar = '\0';
            this.zipTextBox.PromptText = "Zip code";
            this.zipTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.zipTextBox.SelectedText = "";
            this.zipTextBox.Size = new System.Drawing.Size(159, 29);
            this.zipTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.zipTextBox.TabIndex = 78;
            this.zipTextBox.UseCustomBackColor = true;
            this.zipTextBox.UseSelectable = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.phoneNumberTextBox.Lines = new string[0];
            this.phoneNumberTextBox.Location = new System.Drawing.Point(3, 196);
            this.phoneNumberTextBox.MaxLength = 32767;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PasswordChar = '\0';
            this.phoneNumberTextBox.PromptText = "(500) 000-0000";
            this.phoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneNumberTextBox.SelectedText = "";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(316, 29);
            this.phoneNumberTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.phoneNumberTextBox.TabIndex = 70;
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
            this.cityComboBox.Location = new System.Drawing.Point(4, 381);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.PromptText = "City";
            this.cityComboBox.Size = new System.Drawing.Size(150, 29);
            this.cityComboBox.TabIndex = 76;
            this.cityComboBox.UseSelectable = true;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.White;
            this.surnameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.surnameTextBox.Lines = new string[0];
            this.surnameTextBox.Location = new System.Drawing.Point(165, 30);
            this.surnameTextBox.MaxLength = 32767;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.PromptText = "Last";
            this.surnameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.Size = new System.Drawing.Size(155, 29);
            this.surnameTextBox.TabIndex = 64;
            this.surnameTextBox.UseCustomBackColor = true;
            this.surnameTextBox.UseSelectable = true;
            // 
            // countyTextBox
            // 
            this.countyTextBox.BackColor = System.Drawing.Color.White;
            this.countyTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.countyTextBox.Lines = new string[0];
            this.countyTextBox.Location = new System.Drawing.Point(160, 339);
            this.countyTextBox.MaxLength = 32767;
            this.countyTextBox.Name = "countyTextBox";
            this.countyTextBox.PasswordChar = '\0';
            this.countyTextBox.PromptText = "County";
            this.countyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.countyTextBox.SelectedText = "";
            this.countyTextBox.Size = new System.Drawing.Size(159, 29);
            this.countyTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.countyTextBox.TabIndex = 75;
            this.countyTextBox.UseCustomBackColor = true;
            this.countyTextBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(3, 250);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 19);
            this.metroLabel6.TabIndex = 80;
            this.metroLabel6.Text = "Your address";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // aptTextBox
            // 
            this.aptTextBox.BackColor = System.Drawing.Color.White;
            this.aptTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.aptTextBox.Lines = new string[0];
            this.aptTextBox.Location = new System.Drawing.Point(3, 338);
            this.aptTextBox.MaxLength = 32767;
            this.aptTextBox.Name = "aptTextBox";
            this.aptTextBox.PasswordChar = '\0';
            this.aptTextBox.PromptText = "Apt./Suite";
            this.aptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aptTextBox.SelectedText = "";
            this.aptTextBox.Size = new System.Drawing.Size(151, 29);
            this.aptTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.aptTextBox.TabIndex = 73;
            this.aptTextBox.UseCustomBackColor = true;
            this.aptTextBox.UseSelectable = true;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.White;
            this.addressTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.addressTextBox.Lines = new string[0];
            this.addressTextBox.Location = new System.Drawing.Point(2, 293);
            this.addressTextBox.MaxLength = 32767;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.PromptText = "Street address";
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.Size = new System.Drawing.Size(316, 29);
            this.addressTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.addressTextBox.TabIndex = 72;
            this.addressTextBox.UseCustomBackColor = true;
            this.addressTextBox.UseSelectable = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(357, 379);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(224, 31);
            this.updateButton.Style = MetroFramework.MetroColorStyle.Green;
            this.updateButton.TabIndex = 60;
            this.updateButton.Text = "Update changes";
            this.updateButton.UseSelectable = true;
            this.updateButton.UseStyleColors = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ProgramandServicesTabPage
            // 
            this.ProgramandServicesTabPage.Controls.Add(this.programdescTextbox);
            this.ProgramandServicesTabPage.Controls.Add(this.programlabel);
            this.ProgramandServicesTabPage.Controls.Add(this.programnameTextbox);
            this.ProgramandServicesTabPage.Controls.Add(this.programname);
            this.ProgramandServicesTabPage.ForeColor = System.Drawing.Color.Black;
            this.ProgramandServicesTabPage.HorizontalScrollbarBarColor = true;
            this.ProgramandServicesTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ProgramandServicesTabPage.HorizontalScrollbarSize = 10;
            this.ProgramandServicesTabPage.Location = new System.Drawing.Point(4, 38);
            this.ProgramandServicesTabPage.Name = "ProgramandServicesTabPage";
            this.ProgramandServicesTabPage.Size = new System.Drawing.Size(975, 438);
            this.ProgramandServicesTabPage.TabIndex = 1;
            this.ProgramandServicesTabPage.Text = "Program and Services";
            this.ProgramandServicesTabPage.VerticalScrollbarBarColor = true;
            this.ProgramandServicesTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.ProgramandServicesTabPage.VerticalScrollbarSize = 10;
            // 
            // programnameTextbox
            // 
            this.programnameTextbox.BackColor = System.Drawing.Color.White;
            this.programnameTextbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.programnameTextbox.Lines = new string[0];
            this.programnameTextbox.Location = new System.Drawing.Point(210, 23);
            this.programnameTextbox.MaxLength = 32767;
            this.programnameTextbox.Name = "programnameTextbox";
            this.programnameTextbox.PasswordChar = '\0';
            this.programnameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.programnameTextbox.SelectedText = "";
            this.programnameTextbox.Size = new System.Drawing.Size(155, 29);
            this.programnameTextbox.Style = MetroFramework.MetroColorStyle.White;
            this.programnameTextbox.TabIndex = 63;
            this.programnameTextbox.UseCustomBackColor = true;
            this.programnameTextbox.UseSelectable = true;
            // 
            // programname
            // 
            this.programname.AutoSize = true;
            this.programname.BackColor = System.Drawing.SystemColors.Window;
            this.programname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.programname.Location = new System.Drawing.Point(51, 23);
            this.programname.Name = "programname";
            this.programname.Size = new System.Drawing.Size(153, 24);
            this.programname.TabIndex = 3;
            this.programname.Text = "Program Name : ";
            // 
            // programlabel
            // 
            this.programlabel.AutoSize = true;
            this.programlabel.BackColor = System.Drawing.SystemColors.Window;
            this.programlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.programlabel.Location = new System.Drawing.Point(8, 78);
            this.programlabel.Name = "programlabel";
            this.programlabel.Size = new System.Drawing.Size(196, 24);
            this.programlabel.TabIndex = 64;
            this.programlabel.Text = "Program Description : ";
            // 
            // programdescTextbox
            // 
            this.programdescTextbox.BackColor = System.Drawing.Color.White;
            this.programdescTextbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.programdescTextbox.Lines = new string[0];
            this.programdescTextbox.Location = new System.Drawing.Point(210, 78);
            this.programdescTextbox.MaxLength = 32767;
            this.programdescTextbox.Name = "programdescTextbox";
            this.programdescTextbox.PasswordChar = '\0';
            this.programdescTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.programdescTextbox.SelectedText = "";
            this.programdescTextbox.Size = new System.Drawing.Size(250, 150);
            this.programdescTextbox.Style = MetroFramework.MetroColorStyle.White;
            this.programdescTextbox.TabIndex = 65;
            this.programdescTextbox.UseCustomBackColor = true;
            this.programdescTextbox.UseSelectable = true;
            // 
            // userpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 522);
            this.Controls.Add(this.UserTabControl);
            this.Name = "userpanel";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "User Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userpanel_FormClosing);
            this.Load += new System.EventHandler(this.userpanel_Load);
            this.UserTabControl.ResumeLayout(false);
            this.ProfileTabPage.ResumeLayout(false);
            this.ProfileTabPage.PerformLayout();
            this.ProgramandServicesTabPage.ResumeLayout(false);
            this.ProgramandServicesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl UserTabControl;
        private MetroFramework.Controls.MetroTabPage ProfileTabPage;
        private MetroFramework.Controls.MetroTabPage ProgramandServicesTabPage;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroTextBox yearTextBox;
        private MetroFramework.Controls.MetroComboBox monthComboBox;
        private MetroFramework.Controls.MetroComboBox genderComboBox;
        private MetroFramework.Controls.MetroComboBox dayComboBox;
        private MetroFramework.Controls.MetroLabel birthdayLabel;
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
        private System.Windows.Forms.Label programname;
        private MetroFramework.Controls.MetroTextBox programnameTextbox;
        private System.Windows.Forms.Label programlabel;
        private MetroFramework.Controls.MetroTextBox programdescTextbox;
    }
}