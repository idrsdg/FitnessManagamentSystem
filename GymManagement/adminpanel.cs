using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Twilio;
namespace Gym_Manager
{
    public partial class adminpanel : MetroForm
    {
        public adminpanel()
        {
            InitializeComponent();
            CenterToScreen();
            startDatePicker.MinDate = DateTime.Now;
            endDatePicker.MinDate = DateTime.Today.AddDays(1);
            LoadForDataGridView();
        }

        public Int32 primaryID = 0;
        public string primaryname = null;
        public Boolean taskFinder = false;
        public Boolean editClicked = false;

        private void editButton_Click(object sender, EventArgs e)
        {
            editClicked = true;
           
            startDatePicker.MinDate = new DateTime(2014, 4, 18);
            startDatePicker.CustomFormat = "dd.MM.yyyy";
            startDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.MinDate = new DateTime(2014, 4, 1);
            endDatePicker.CustomFormat = "dd.MM.yyyy";
            endDatePicker.Format = DateTimePickerFormat.Custom;
            updateButton.Visible = true;
            deleteButton.Visible = true;
            userComboBox.Visible = true;
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_admin();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string deneme = (dayComboBox.SelectedIndex + 1).ToString() + "." + (monthComboBox.SelectedIndex + 1).ToString() + "." + yearTextBox.Text;
            DateTime birthday = Convert.ToDateTime(deneme);
            Int32 getIDBack = 0;
            if(totalamount() !=0)
            {
                  string query = "insert into userinfo(name, surname, birthdate, gender, phone,email, address, aptnumber, county, city, zipcode, startdate, enddate, totalamount, programid) values('" + nameTextBox.Text +
                  "', '" + surnameTextBox.Text + "','" + birthday.ToString("dd.MM.yyyy") + "','" +
                  genderComboBox.SelectedItem.ToString() + "', '" + phoneNumberTextBox.Text + "','" +
                  emailTextBox.Text + "', '" + addressTextBox.Text + "','" +
                  aptTextBox.Text + "','" + countyTextBox.Text + "','" + cityComboBox.Text + "','" +
                  zipTextBox.Text + "', '" + startDatePicker.Value.ToString("MM.dd.yyyy") + "', '" + endDatePicker.Value.ToString("MM.dd.yyyy") + "' , '"
                   + totalamount() + "'," + FinalizeServices.programid.ToString()+");";
                query += "SELECT CAST(scope_identity() AS int)";
                string query2 = "insert into login(username, password, type) values('" + nameTextBox.Text + "', '" + null + "', 2)";
                SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
                SqlCommand query_table = new SqlCommand(query, connection);
                SqlCommand query_table2 = new SqlCommand(query2, connection);
                try
                {
                    connection.Open();
                    query_table2.ExecuteScalar();
                    connection.Close();
                    connection.Open();
                    getIDBack = (Int32)query_table.ExecuteScalar();
                    //query_table.ExecuteNonQuery();
                    string userID = Convert.ToString(getIDBack);
                    MetroFramework.MetroMessageBox.Show(this, "Entry successfully inserted into database. " + "\n\n" +
                        "Provide this unique ID to the customer." + "\n\n" +
                    "USER UNIQUE ID: " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                ComboBoxItemsFromDataBase();
                LoadForDataGridView();
                reset_admin();
            }
        }

        public int totalamount()
        {
            int bill = 0;
            DateTime startdate = startDatePicker.Value;
            DateTime enddate = endDatePicker.Value;
            if(startDatePicker.Value.Year == endDatePicker.Value.Year)
            {
                if (startDatePicker.Value.Month<endDatePicker.Value.Month)
                {
                    bill = 80 * (endDatePicker.Value.Month - startDatePicker.Value.Month);
                }
                else
                {
                    MessageBox.Show("In the same year, start month can not be bigger than end" +
                        "month.");
                }
            }
            if (startDatePicker.Value.Year < endDatePicker.Value.Year)
            {
                bill = (Convert.ToInt32((enddate - startdate).TotalDays) / 30) * 80;
            }
            if(startDatePicker.Value.Year > endDatePicker.Value.Year)
            {
                MessageBox.Show("Start year can not be bigger than end year.");
            }
                return bill;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            updateButton.Visible = false;
            deleteButton.Visible = false;
            userComboBox.Visible = false;
            reset_admin();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }

        private void reset_admin()
        {
            try
            {
                userComboBox.Items.Clear();
                ClearAllTextBoxes(this);
                ComboBoxItemsFromDataBase();
                dayComboBox.SelectedItem = null;
                monthComboBox.SelectedItem = null;

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (primaryID > 100)
            {
                string query = "delete from userinfo where Id = '" + primaryID + "'";
                string query2 = "delete from login where username = '" + primaryname +"'";
                SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
                SqlCommand query_table = new SqlCommand(query, connection);
                SqlCommand query_table2 = new SqlCommand(query2, connection);
                SqlDataReader reader;
                SqlDataReader reader2;
                try
                {
                    connection.Open();
                    reader2 = query_table2.ExecuteReader();
                    connection.Close();
                    connection.Open();
                    reader = query_table.ExecuteReader();
                    
                    MetroFramework.MetroMessageBox.Show(this, "User has been deleted."  + "\n\n" + "User_id: " +
                " " + primaryID + " is deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    connection.Close();
                    


                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Selected ID doesn't exist.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            ComboBoxItemsFromDataBase();
            LoadForDataGridView();
            reset_admin();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string deneme = (dayComboBox.SelectedIndex + 1).ToString() + "." + (monthComboBox.SelectedIndex + 1).ToString() + "." + yearTextBox.Text;
            DateTime birthday = Convert.ToDateTime(deneme);
            string query = "update userinfo set name ='" + nameTextBox.Text +
              "', surname ='" + surnameTextBox.Text + "', birthdate='" + birthday.ToString("dd.MM.yyyy") + "', gender='" + genderComboBox.SelectedItem + "', phone='" + phoneNumberTextBox.Text + "', email='"
                + emailTextBox.Text + "', address= '" + addressTextBox.Text + "', aptnumber='" +
                aptTextBox.Text + "', county = '" + countyTextBox.Text + "', city= '" +
                cityComboBox.Text + "', zipcode = '" + zipTextBox.Text + "', startdate = '" +
                startDatePicker.Value.ToString("MM.dd.yyyy") + "', enddate = '" +
                endDatePicker.Value.ToString("MM.dd.yyyy")
               + "' WHERE Id = '" + primaryID + "';";

            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                string userID = Convert.ToString(primaryID);
                reader = query_table.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, "Entry successfully updated into database. For the UNIQUE USER ID of: " + "\n\n" +
                " " + userID, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ComboBoxItemsFromDataBase();
            reset_admin();
            LoadForDataGridView();
        }

        private void addingservicesButton_Click(object sender, EventArgs e)
        {
            FinalizeServices finalizeser = new FinalizeServices();
            finalizeser.totalamountfromadmin = totalamount();
            if (totalamount() != 0)
            {
                finalizeser.ShowDialog();
            }
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            FinalizePayment finalizepay = new FinalizePayment();
            if (totalamount() != 0)
            {               
                finalizepay.ShowDialog();
            }
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getID = userComboBox.Text.Substring(0, 4).Replace(" ", string.Empty);
            string query = "Select * from userinfo where Id= '" + getID + "'";

            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = query_table.ExecuteReader();
                while (reader.Read())
                {
                    taskFinder = true;
                    string ID = reader["Id"].ToString();
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    string birthdate = reader["birthdate"].ToString();
                    string gender = reader["gender"].ToString();
                    string phone = reader["phone"].ToString();
                    string email = reader["email"].ToString();
                    string address = reader["address"].ToString();
                    string apt_suite = reader["aptnumber"].ToString();
                    string county = reader["county"].ToString();
                    string city = reader["city"].ToString();
                    string zip_code = reader["zipcode"].ToString();
                    string start_date = Convert.ToDateTime(reader["startdate"]).ToString("dd-MM-yyyy").Replace(" ", string.Empty);
                    startDatePicker.Value = Convert.ToDateTime(start_date);
                    string end_date = Convert.ToDateTime(reader["enddate"]).ToString("dd-MM-yyyy").Replace(" ", string.Empty);
                    endDatePicker.Value = Convert.ToDateTime(end_date);
                    startDatePicker.Value.ToShortDateString();
                    endDatePicker.Value.ToShortDateString();
                    nameTextBox.Text = name;
                    surnameTextBox.Text = surname;
                    phoneNumberTextBox.Text = phone;
                    genderComboBox.SelectedItem = gender;
                    dayComboBox.SelectedItem = birthdate.Substring(0, birthdate.IndexOf('.'));
                    monthComboBox.SelectedIndex = Convert.ToInt32(birthdate.Substring(birthdate.IndexOf('.') + 1, 2)) - 1;
                    yearTextBox.Text = birthdate.Substring(birthdate.Length - Math.Min(4, birthdate.Length));
                    emailTextBox.Text = email;
                    addressTextBox.Text = address;
                    aptTextBox.Text = apt_suite;
                    countyTextBox.Text = county;
                    cityComboBox.SelectedItem = city;
                    zipTextBox.Text = zip_code;
                    primaryID = Convert.ToInt32(ID);
                    primaryname = name;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBoxItemsFromDataBase()
        {
            string query = "Select * from userinfo";
            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = query_table.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader["ID"].ToString();
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    userComboBox.Items.Add(ID + "  | " + name + "  " + surname);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadForDataGridView()
        {
            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            SqlCommand query = new SqlCommand("Select * from userinfo", connection);
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                resTotalDataGridView.DataSource = bindingSource;
                dataAdapter.Update(dataTable);
                connection.Close();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error loading data", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.None);
            }
        }
    }
}
