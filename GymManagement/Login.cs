using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_Manager
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public static string assign;
        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (signing()==1)
                {
                    this.Hide();
                    adminpanel admin_panel = new adminpanel();
                    admin_panel.Show();
                }
                else if (signing()!=1 && signing()!=0 && signing()!=3)
                {
                    this.Hide();
                    userpanel user_panel = new userpanel();
                    user_panel.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,"Invalid username or password. Try Again." ,"Error",MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = false;
            }

        }

        public int signing()
        {
            int logintype;
            int success=0;
            SqlConnection connection = new SqlConnection(Gym_Manager.Properties.Settings.Default.finalconnection);
            string sql = "SELECT * FROM login WHERE username='" + usernameTextBox.Text + "' AND password='" + passwordTextBox.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataReader sqlReader;
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    success = 3;
                    connection.Open();
                    sqlReader = sqlCommand.ExecuteReader();
                    if (sqlReader.Read())
                    {
                        success = 4;
                        logintype = Convert.ToInt32(sqlReader["type"].ToString());
                        if (logintype == 1)
                            return success = 1;
                        else if (logintype == 2)
                        {
                            success = Convert.ToInt32(sqlReader["userid"].ToString());
                            assign = sqlReader["username"].ToString();
                            return success;
                        }
                    }
                    connection.Close();
                }
                catch (Exception e)
                {
                    MetroFramework.MetroMessageBox.Show(this, e.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            return success;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LicenseCallButton_Click(object sender, EventArgs e)
        {
            License open_license = new License();
            open_license.ShowDialog();
        }
    }
}
