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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
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
                int First = int.Parse(RoomNumberBox.Text);
                double Second = double.Parse(NumberOfNightsBox.Text);
                double Third = double.Parse(NightlyDollarRateBox.Text);
                double Fourth = double.Parse(MiniBarChargesBox.Text);
                double Fifth = double.Parse(TelephoneChargesBox.Text);
                double Sixth = double.Parse(MiscellaneousChargesBox.Text);
                double result1 = (Second * Third);
                RoomChargesLabel.Text = result1.ToString();
            }
            catch
            { 
                MessageBox.Show("Invalid Data was entered.")
            }
        }
    }
}
