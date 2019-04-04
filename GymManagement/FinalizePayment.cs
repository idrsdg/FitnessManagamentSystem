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

namespace Gym_Manager
{
    public partial class FinalizePayment : MetroForm
    {
        public FinalizePayment()
        {
            InitializeComponent();
            CenterToParent();
        }
        public int totalamountfromadmin = 0;

        private string paymentType;

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        private string paymentCardNumber;

        public string PaymentCardNumber
        {
            get { return paymentCardNumber; }
            set { paymentCardNumber = value; }
        }
        private string MM_YY_Of_Card;

        public string MM_YY_Of_Card1
        {
            get { return MM_YY_Of_Card; }
            set { MM_YY_Of_Card = value; }
        }
        private string CVC_Of_Card;

        public string CVC_Of_Card1
        {
            get { return CVC_Of_Card; }
            set { CVC_Of_Card = value; }
        }
        private string CardType;

        public string CardType1
        {
            get { return CardType; }
            set { CardType = value; }
        }

        private void FinalizePayment_Load(object sender, EventArgs e)
        {
            
            int FinalTotal = Convert.ToInt32(totalamountfromadmin + FinalizeServices.finalTotalFinalized);
            currentBillAmount.Text = "$" + Convert.ToString(FinalTotal)+" USD";
            totalAmount.Text = "$" + Convert.ToString(FinalTotal) + " USD";


        }

        private void nextButton_Click(object sender, EventArgs e)
        {   
            try
            {
                PaymentType = paymentComboBox.Text;
                PaymentCardNumber = phoneNComboBox.Text;
                MM_YY_Of_Card1 = monthComboBox.SelectedItem.ToString() +"/"+ yearComboBox.SelectedItem.ToString();
                CVC_Of_Card1 = cvcComboBox.Text;
                CardType1 = cardTypeView.Text;               
                this.Hide();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error Closing the window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (phoneNComboBox.Text.Substring(0, 1) == "3")
            {
                cardTypeView.Text = "AmericanExpress";
            }
            else if (phoneNComboBox.Text.Substring(0, 1) == "4")
            {
                cardTypeView.Text = "Visa";
            }
            else if (phoneNComboBox.Text.Substring(0, 1) == "5")
            {
                cardTypeView.Text = "MasterCard";
            }
            else if (phoneNComboBox.Text.Substring(0, 1) == "6")
            {
                cardTypeView.Text = "Discover";
            }
            else
                cardTypeView.Text = "Unknown";
        }      
    }
}
