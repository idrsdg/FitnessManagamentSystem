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
namespace Gym_Manager
{
    public partial class userpanel : MetroForm
    {
        
        public userpanel()
        {
            InitializeComponent();

        }



        private void resetEntries(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    resetEntries(control);
                }
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string primaryID = Login.assign;
            string deneme = (dayComboBox.SelectedIndex + 1).ToString() + "." + (monthComboBox.SelectedIndex + 1).ToString() + "." + yearTextBox.Text;
            DateTime birthday = Convert.ToDateTime(deneme);
            string query = "update userinfo set name ='" + nameTextBox.Text +
              "', surname ='" + surnameTextBox.Text + "', birthdate='" + birthday.ToString("dd.MM.yyyy") + "', gender='" + genderComboBox.SelectedItem + "', phone='" + phoneNumberTextBox.Text + "', email='"
                + emailTextBox.Text + "', address= '" + addressTextBox.Text + "', aptnumber='" +
                aptTextBox.Text + "', county = '" + countyTextBox.Text + "', city= '" +
                cityComboBox.Text + "', zipcode = '" + zipTextBox.Text + "' WHERE name = '" + primaryID + "';";

            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);

            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                string userName = Convert.ToString(Login.assign);
                reader = query_table.ExecuteReader();
                MetroFramework.MetroMessageBox.Show(this, "Update is successfull for User Name: " +
                " " + userName, "Report", MessageBoxButtons.OK, MessageBoxIcon.Question);
                while (reader.Read())
                {

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(query);
            }
        }

        private void userpanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userpanel_Load(object sender, EventArgs e)
        {
            string primaryID = Login.assign;
            int programid = -1;
            string query = "Select * from userinfo where name ='" + primaryID + "'";

            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;           
            connection.Open();
            reader = query_table.ExecuteReader();
            try
            {               
                while (reader.Read())
                {
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
                    programid = Convert.ToInt32(reader["programid"].ToString());
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
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
            SqlConnection connection2 = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            string query2 = " select * from programs where programid = " + programid.ToString() + "";
            SqlCommand query_table2 = new SqlCommand(query2, connection2);
            SqlDataReader reader2;
            if (connection2.State == ConnectionState.Closed)
            {
                
                try
                {
                    connection2.Open();
                    reader2 = query_table2.ExecuteReader();
                    if (reader2.Read())
                    {
                        string pname = reader2["name"].ToString();
                        string pdescr = reader2["description"].ToString();
                        programnameTextbox.Text = pname;
                        programdescTextbox.Text = pdescr;
                    }
                    connection2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }           
        }
        
    }
}
