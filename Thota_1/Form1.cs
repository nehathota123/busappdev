// Programmer: Neha Thota
// Project: Individual Assignment 1
// Due Date: 02/17/2020
// Description: Customer's Charges in Motorway Motel

// The code starts in the middle with TryCatch
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thota_1
{
    public partial class MotelForm : Form
    {
        public MotelForm()
        {
            InitializeComponent();
        }

        private void DateBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RoomNumberBox_ValueChanged(object sender, EventArgs e)
        {
            IEnumerable<int> range = Enumerable.Range(100, 999);
        }

        private void NumberOfNightsBox_ValueChanged(object sender, EventArgs e)
        {
            IEnumerable<int> range = Enumerable.Range(100, 999);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RoomChargesLabel_Click(object sender, EventArgs e)
        {
            int NumberOfNightsBox = int.Parse(RoomChargesLabel.Text);
            int NightlyDollarRateBox = int.Parse(RoomChargesLabel.Text);
            RoomChargesLabel.Text = (NumberOfNightsBox* NightlyDollarRateBox).ToString();
        }

        private void AdditionalChargesLabel_Click(object sender, EventArgs e)
        {
            int MiniBarChargesBox = int.Parse(AdditionalChargesLabel.Text);
            int TelephoneChargesBox = int.Parse(AdditionalChargesLabel.Text);
            int MiscellaneousChargesBox = int.Parse(AdditionalChargesLabel.Text);
            AdditionalChargesLabel.Text = (MiniBarChargesBox + TelephoneChargesBox + MiscellaneousChargesBox).ToString();
        }

        private void SubtotalLabel_Click(object sender, EventArgs e)
        {
            SubtotalLabel.Text = (RoomChargesLabel.Text + AdditionalChargesLabel.Text);
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                double First = double.Parse(RoomNumberBox.Text);
                if (99 < First) 
                {
                    First += 99;
                }
                else
                    {
                        MessageBox.Show("Invalid Data was entered.");
                    }
                if (First < 999)
                {
                    First -= 999;
                }
                else
                {
                    MessageBox.Show("Invalid Data was entered.");
                }
                // to hold 3 digit room number 
                double Second = double.Parse(NumberOfNightsBox.Text);       
                double Third = double.Parse(NightlyDollarRateBox.Text);
                double Fourth = double.Parse(MiniBarChargesBox.Text);
                double Fifth = double.Parse(TelephoneChargesBox.Text);
                double Sixth = double.Parse(MiscellaneousChargesBox.Text);
                // to hold Number of Nights spent, Nightly rate, Mini Bar Charges, Telephone Charges, and Miscellaneous Charges
                double result1 = (Second * Third);
                RoomChargesLabel.Text = result1.ToString("C");
                double result2 = (Fourth + Fifth + Sixth);
                AdditionalChargesLabel.Text = result2.ToString("C");
                double result3 = (result1 + result2);
                SubtotalLabel.Text = result3.ToString("C");
                double result4 = (result3 * 7) / 100;
                TaxLabel.Text = result4.ToString("C");
                double finalresult = (result3 + result4);
                TotalAmountLabel.Text = finalresult.ToString("C");
                // Calculation of Room Charges, Additional Charges, Subtotal, Taxes and the Total Amount the customer must pay
            }
            catch
            {
                MessageBox.Show("Invalid Data was entered.");
                // Invalid if it is not a number
            }
        }

        private void ClearBox_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            RoomNumberBox.Text = "";
            NumberOfNightsBox.Text = "";
            NightlyDollarRateBox.Text = "";
            MiniBarChargesBox.Text = "";
            TelephoneChargesBox.Text = "";
            MiscellaneousChargesBox.Text = "";
            RoomChargesLabel.Text = "";
            AdditionalChargesLabel.Text = "";
            SubtotalLabel.Text = "";
            TaxLabel.Text = "";
            TotalAmountLabel.Text = "";
            DateBox.Mask = "";
            DateBox.Text = "";
            // No contents must be displayed
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type the Customer's checking out date, First and Last Name, Room Number, Number of Nights he/she stayed, Nightly Rate, Mini Bar Charges, Telephone Charges, and Miscellaneous Charges.");
            // Type in all the customer's information in order to get the total amount 
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // The window must be closed 
        }
    }
}
