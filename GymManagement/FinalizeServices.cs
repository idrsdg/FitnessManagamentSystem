using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_Manager
{
    public partial class FinalizeServices : MetroForm
    {
        public FinalizeServices()
        {
            InitializeComponent();
            CenterToParent();
        }
        public int totalservices = 0;
        public static int  finalTotalFinalized = 0;
        public int priceforprogram = 0;
        public int totalamountfromadmin = 0;
        public static int programid = -1;

        private void FinalizeServices_Load(object sender, EventArgs e)
        {
            programCombobox();
            

        }

        private void finalizeamount()
        {
            int price1 = 0, price2 = 0, price3 = 0;
            if (proteincheckBox.Checked == true)
            {
                price1 = 100;
            }
            if (vitamincheckBox.Checked == true)
            {
                price2 = 150;
            }
            if (fatcheckBox.Checked == true)
            {
                price3 = 200;
            }
            int month = totalamountfromadmin / 80;
            totalservices = price1 + price2 + price3;
            finalTotalFinalized = (totalservices + priceforprogram)*month;
            
            int FinalTotal = Convert.ToInt32(totalamountfromadmin);
            currentBillAmount.Text = "$" + Convert.ToString(totalamountfromadmin) + " USD";
            totalAmount.Text = "$" + Convert.ToString(finalTotalFinalized) + " USD";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            
        }

        private void programCombobox()
        {
            string query = "Select * from programs";
            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = query_table.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader["programid"].ToString();
                    string name = reader["name"].ToString();
                    programsComboBox.Items.Add(ID + "  | " + name);
                }
                connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void programsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getID = programsComboBox.Text.Substring(0, 2).Replace(" ", string.Empty);
            string query = "Select * from programs where programid= '" + getID + "'";

            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            SqlCommand query_table = new SqlCommand(query, connection);
            SqlDataReader reader;
            try
            {
                connection.Open();
                reader = query_table.ExecuteReader();
                while (reader.Read())
                {
                    programid = Convert.ToInt32(reader["programid"].ToString());
                    priceforprogram = Convert.ToInt32(reader["price"].ToString());
                }
                finalizeamount();
                connection.Close();
            }               
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}