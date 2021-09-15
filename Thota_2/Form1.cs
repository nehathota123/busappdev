// Programmer: Neha Thota
// Project: Thota_2 
// Due Date: 3/11/2020 
//Description: Individual Assignment #2 - Course purchase in Language Arts Institute 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thota_2
{
    public partial class Form : System.Windows.Forms.Form
    {
        private decimal Result; //Defining the number of courses as a decimal
        private decimal First; //Defining In-State charge per course as a decimal
        private decimal Second; //Defining Out-Of-State charge per course as a decimal 

        public Form()
        {
            InitializeComponent();
        }

        private void InStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OutOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void BegFrenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (InStateRadioButton.Checked == true)
            {
                First = 0;
                if (BegFrenchCheckBox.Checked) 
                {
                    First += 49; //The price of In-State Beginning French Course is 49$
                }
                if (BegGermanCheckBox.Checked)
                {
                    First += 49; //The price of In-State Beginning German Course is 49$
                }
                if (BegItalianCheckBox.Checked)
                {
                    First += 49; //The price of In-State Beginning Italian Course is 49$
                }
                if (BegRussianCheckBox.Checked)
                {
                    First += 49; //The price of In-State Beginning Russian Course is 49$
                }
                if (BegSpanishCheckBox.Checked)
                {
                    First += 49; //The price of In-State Beginning Spanish Course is 49$
                }
                TotalChargeLabel.Text = First.ToString("C");
                // The total charge label will display the amount for the courses selected for In-state           
            }
            if (OutOfStateRadioButton.Checked == true)
            {
                Second = 0;
                if (BegFrenchCheckBox.Checked)
                {
                    Second += 99; //The price of In-State Beginning French Course is 99$
                }
                if (BegGermanCheckBox.Checked)
                {
                    Second += 99; //The price of In-State Beginning German Course is 99$
                }
                if (BegItalianCheckBox.Checked)
                {
                    Second += 99; //The price of In-State Beginning Italian Course is 99$
                }
                if (BegRussianCheckBox.Checked)
                {
                    Second += 99; //The price of In-State Beginning Russian Course is 99$
                }
                if (BegSpanishCheckBox.Checked)
                {
                    Second += 99; //The price of In-State Beginning Spanish Course is 99$
                }
                TotalChargeLabel.Text = Second.ToString("C");
                // The total charge label will display the amount for the courses selected for Out-of-state  
            }
            Result = 0;
            if (BegFrenchCheckBox.Checked) 
            {
               Result += 1;  //The number of courses will add one more to the current value when Beginning French course is selected
            }
            if (BegGermanCheckBox.Checked)
            {
                Result += 1; //The number of courses will add one more to the current value when Beginning German course is selected
            }
            if (BegItalianCheckBox.Checked)
            {
                Result += 1; //The number of courses will add one more to the current value when Beginning Italian course is selected
            }
            if (BegRussianCheckBox.Checked)
            {
                Result += 1; //The number of courses will add one more to the current value when Beginning Russian course is selected
            }
            if (BegSpanishCheckBox.Checked)
            {
                Result += 1; //The number of courses will add one more to the current value when Beginning Spanish course is selected
            }
            NumberOfCoursesOutpulLabel.Text = Result.ToString();
            // Display the total number of courses selected in the Output label
        }
        private void NumberOfCoursesOutpulLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void TotalChargeLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string Term=""; // To display the Term 
            if (FallRadioButton.Checked)
            {
                Term = FallRadioButton.Text; //Display the Term as "Fall" when Fall Button is selected
            }
            else if (SpringRadioButton.Checked)
            {
                Term = SpringRadioButton.Text; //Display the Term as "Spring" when Spring Button is selected
            }
            string ResidenceStatus = ""; //To display the Residence Status 
            string Price = ""; //To Display the Price of each course depending on the Residence Status 
            if (InStateRadioButton.Checked)
            {
                ResidenceStatus = InStateRadioButton.Text;  //Display the Residence Status as In-State when In-State Button is selected
                Price = InStatePriceLabel.Text; //Display the price of each course as 49$ for In-State when In-State Button is selected
            }
            else if (OutOfStateRadioButton.Checked)
            {
                ResidenceStatus = OutOfStateRadioButton.Text; //Display the Residence Status as Out-Of-State when Out-Of-State Button is selected
                Price = InStatePriceLabel.Text; //Display the price of each course as 99$ for Out-Of-State when Out-Of-State Button is selected
            }
            string CardType = ""; // To display the Card Type
            if (MasterCardButton.Checked)
            {
                CardType = MasterCardButton.Text; //Display Card Type as MasterCard when MasterCard Button is selected
            }
            else if (VisaCreditRadioButton.Checked)
            {
                CardType = VisaCreditRadioButton.Text; //Display Card Type as Visa Credit when VisaCredit Button is selected
            }
            string Course=""; //To display the Course names
            if (BegFrenchCheckBox.Checked)
            {
                Course = Course + BegFrenchCheckBox.Text + "\n"; //Display Beginning French as the approved course when selected/purchased
            }
            if (BegGermanCheckBox.Checked)
            {
                Course= Course= BegGermanCheckBox.Text + "\n"; //Display Beginning German as the approved course when selected/purchased
            }
            if (BegItalianCheckBox.Checked)
            {
                Course= Course+ BegItalianCheckBox.Text + "\n"; //Display Beginning Italian as the approved course when selected/purchased
            }
            if (BegRussianCheckBox.Checked)
            {
                Course= Course+ BegRussianCheckBox.Text + "\n"; //Display Beginning Russian as the approved course when selected/purchased
            }
            if (BegSpanishCheckBox.Checked)
            {
                Course= Course + BegSpanishCheckBox.Text + "\n"; //Display Beginning Spanish as the approved course when selected/purchased
            }
            int FinalResult; //Defining the number of courses selected as the variable, FinalResult
            if (int.TryParse(NumberOfCoursesOutpulLabel.Text, out FinalResult)) //Converting the output label, which is text, to a number
            { 
                if (FinalResult>=1 && FinalResult<=3) //The courses selected must be more than or equal to 1 and less than or equal to 3
                {
                    // Display the below mentioned information in a Message Box
                    MessageBox.Show("Term= "+ Term + "\n" + //Display the selected Term- fall or Spring
                        "Year= " + YearComboBox.Text + "\n" + //Display the selected Year- 2018 through 2023
                        "Student ID= "+ StudentIDMaskedTextBox.Text + "\n" + //Display the Student ID typed
                        "Full Name= " + FirstNameTextBox.Text + " " + LastNameTextBox.Text + "\n" + //Display the Student's First and Last Name
                        "Email Address= " + EmailAddressTextBox.Text + "\n" + //Display the Student's Email Address
                        "Residence Status= "+ ResidenceStatus + "\n" + //Display the Student's Residence Status- In-State or Out-Of-State
                        "Number of Courses= "+ NumberOfCoursesOutpulLabel.Text + "\n" + //Display the number of courses selected/purchased
                        "Charge per course= "+ Price + "\n" + //Display the charge per course- 49$ for In-State and 99$ for Out-Of-State
                        "Total Charge= "+ TotalChargeLabel.Text + "\n" + // Display the total charge depending on the number of courses and the charge on each course
                        "Credit Card Type= "+ CardType + "\n" + //Display the Credit Card type- MasterCard or Visa Credit
                        "Credit Card Number= "+ CreditCardNumberMaskedBox.Text + "\n" + //Display the Credit Card Number
                        "Expiration Date= "+ ExpirationDateMaskedTextBox.Text + "\n" + //Display the Expiration Date of the Credit Card 
                        "Order Status= " + Course+"course/courses have been purchased"); //Display the Order status stating that the selected courses have been purchased
                }
                else
                {
                    MessageBox.Show("Order must contain at least one but not more than three courses"); //Display a message when no courses or more than 3 courses are selected
                }
            }
        }   

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // No contents must be displayed
            FallRadioButton.Focus(); //Focus on the Fall Button
            FallRadioButton.Checked = true; //Go back to default selection of Fall Button
            SpringRadioButton.Checked = false; //Spring button must be deselected
            YearComboBox.SelectedIndex = -1; //Selected year must be cleared
            FirstNameTextBox.Text = ""; //First Name must be cleared
            LastNameTextBox.Text = ""; //Last Name must be cleared
            EmailAddressTextBox.Text = ""; //Email Address must be cleared
            StudentIDMaskedTextBox.Text = ""; //Student ID must be cleared
            InStateRadioButton.Checked = true; //Go back to default selection of In-State Button
            OutOfStateRadioButton.Checked = false; //Out-Of-State Button must be deselected
            BegFrenchCheckBox.Checked = false; //Beginning French Course must be deslected 
            BegGermanCheckBox.Checked = false; //Beginning German Course must be deslected 
            BegItalianCheckBox.Checked = false; //Beginning Italian Course must be deslected 
            BegRussianCheckBox.Checked = false; //Beginning Russian Course must be deslected
            BegSpanishCheckBox.Checked = false; //Beginning Spanish Course must be deslected 
            NumberOfCoursesOutpulLabel.Text = ""; // Number of Courses must be cleared
            TotalChargeLabel.Text = ""; // Total Charge must be cleared
            MasterCardButton.Checked = true; //Go back to default selection of MasterCard
            VisaCreditRadioButton.Checked = false; //Visa Credit button must be deselected
            CreditCardNumberMaskedBox.Text = ""; //Credit Card Number must be cleared
            ExpirationDateMaskedTextBox.Text = ""; //Expiration date of credit card must be cleared
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
            //Exit or close the window
        }
    }
}
