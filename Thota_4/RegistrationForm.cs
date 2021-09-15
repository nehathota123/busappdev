// Programmer: Neha Thota
// Project: Individual Assignment 4
// Due Date: 05/05/2020
// Description: Hopkins Film School Course Registration
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // To read StreamWriter and StreamReader

namespace Thota_4
{
    public partial class RegistrationForm : Form
    {
        // Defining Live Action and Animation Classes prices as decimals
        private decimal LiveActionPrice = 79.95m; // Each Live Action Class costs 79.95$
        private decimal AnimationPrice = 99.95m; // Each Animation Class costs 99.95$
        private int NumofClasses; // Defining number of courses being purchased as an integer
        decimal CoursePrice; // Defining price per course being purchased as a decimal value
        decimal TotalAmount; // Defining total amount of the courses being purchased as a decimal value

        public RegistrationForm()
        {
            InitializeComponent();
            PopulateBoxes(); // Shortcut to input files for listboxes
            UpdateTotals(); // Shortcut to update the course registration group box
            DateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy"); // Display today's date by default 
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            PopulateBoxes(); // Shortcut to input files for listboxes
            UpdateTotals(); // Shortcut to update the course registration group box
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FirstNameTextBox.Text))
                {
                    // Show error message when first name is not entered 
                    MessageBox.Show("Please Enter the first name of the registrant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    // Show error message when last name is not entered 
                    MessageBox.Show("Please Enter the last name of the registrant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (string.IsNullOrEmpty(EmailAddressTextBox.Text))
                {
                    // Show error message when e-mail address is not entered 
                    MessageBox.Show("Please Enter the E-mail Address of the registrant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                if (string.IsNullOrEmpty(DateOfBirthMaskedTextBox.Text))
                {
                    DateOfBirthMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // The mask format must be removed in order for entry to be empty
                    // Show error message when date of birth is not entered 
                    MessageBox.Show("Please Enter the Date of Birth of the registrant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Write order information to output file
                StreamWriter outputfile; // Declare StreamWriter object for use in writing file
                outputfile = File.AppendText("RegistrationData.txt"); // Specifying Registration text file to write all the data
                outputfile.WriteLine("Registration date:" + DateMaskedTextBox.Text); // Write registration/current date to file
                outputfile.WriteLine("Name:" + FirstNameTextBox.Text + " " + LastNameTextBox.Text); // Write Registrant's Full Name
                outputfile.WriteLine("E-mail Address:" + EmailAddressTextBox.Text); //Write Registrant's E-mail Address
                outputfile.WriteLine("Date of Birth:" + DateOfBirthMaskedTextBox.Text); // Write Registrant's Date of Birth
                outputfile.WriteLine("Status:" + StatusComboBox.Text); // Write Registrant's Status
                if (LiveActionRadioButton.Checked)
                {
                    outputfile.WriteLine("Class Type: Live Action Classes"); // If Live Action radio button was selected, display Live Action classes in the text file
                }
                else
                {
                    outputfile.WriteLine("Class Type: Animation Classes"); // If Animation radio button was selected, display Animation classes in the text file
                }
                for (int count = 0; count < FoodsInTheCategory.Items.Count; count++) // Loop through all items in list box and write selected items to output file
                {
                    if (FoodsInTheCategory.GetSelected(count)) // Use GetSelected method to determine if a listbox is selected or not
                    {
                        outputfile.WriteLine(FoodsInTheCategory.Items[count]); // Write selected items to file
                    }
                }
                outputfile.WriteLine("Number Of Classes:" + NumberOfClassesLabel.Text); // Write the number of courses purchased
                outputfile.WriteLine("Price Per Class:" + PricePerClassLabel.Text); // Write price per course purchased
                outputfile.WriteLine("Total Price:" +TotalPriceLabel.Text);// Write the Total Price of the courses purchased
                if (CashRadioButton.Checked)
                {
                    outputfile.WriteLine("Payment Type: Cash"); // Write payment type as cash if cash radio button is selected 
                }
                if (CheckRadioButton.Checked)
                {
                    outputfile.WriteLine("Payment Type: Check"); // Write payment type as check if check radio button is selected
                }
                if (ReceiptCheckBox.Checked)
                {
                    outputfile.WriteLine("E-mail Receipt Requested: Yes"); // Write Yes if receipt check box is checked
                }
                else
                {
                    outputfile.WriteLine("E-mail Receipt Requested: No"); // Write no if receipt check box is not checked
                }

                outputfile.WriteLine(); // Write a blank link to separate orders
                outputfile.Close();// Close output file after writing data

                {
                    string ClassType; // Defining the type of class selected as string 
                    if (LiveActionRadioButton.Checked)
                    {
                        ClassType = LiveActionRadioButton.Text; // Display Live Action as type of class if live action radio button was selected
                    }
                    else
                    {
                        ClassType = AnimationRadioButton.Text; // Display Animation as type of class if animation radio button was selected 
                    }

                    string Receipt; // Defining E-mail Receipt Request check box as string 
                    if (ReceiptCheckBox.Checked)
                    {
                        Receipt = "Yes"; // Display "yes" if E-mail Receipt Request was checked
                    }
                    else
                    {
                        Receipt = "No"; // Display 'no' if E-mail Receipt Request was not checked
                    }

                    string Payment; // Defining type of payment as string
                    if (CashRadioButton.Checked)
                    {
                        Payment = "Cash"; // Display cash as type of payment if cash radio button was selected
                    }
                    else
                    {
                        Payment = "Check"; // Display check as type of payment if check radio button was selected 
                    }

                    string ClassNames = "";
                    for (int count = 0; count < FoodsInTheCategory.Items.Count; count++) // Loop through all items in list box and write selected items to output file
                    {
                        if (FoodsInTheCategory.GetSelected(count)) // Use GetSelected method to determine if a listbox is selected or not
                        {
                            ClassNames += FoodsInTheCategory.Items[count] + " \n";
                        }
                    }
                 
                    int Courses; // Defining number of courses selected as an integer
                    if (int.TryParse(NumberOfClassesLabel.Text, out Courses)) //Converting the output label, which is text, to a number
                    {
                        if (Courses>=1 && Courses<=4) // Four or less courses must be selected 
                        {
                            MessageBox.Show("Hopkins Film School Class Registration " + 
                            "\n \nRegistrant Information" +
                            "\nName: " + FirstNameTextBox.Text + " " + LastNameTextBox.Text + // Display customer full name
                            "\nE-mail Address: " + EmailAddressTextBox.Text + // Display Customer E-mail Address
                            "\nDate of Birth:  " + DateOfBirthMaskedTextBox.Text + // Display customer date of birth
                            "\n \nRegistration Information" +
                            "\nClass Type: " + ClassType + // Display the type of class selected
                            "\nClasses Selected:\n" + ClassNames.Trim()+ " \n" +// Display all the courses selected
                            "\nNumber of Classes: " + Courses+ // Display the number of courses selected
                            "\nPrice Per Class: " + PricePerClassLabel.Text + // Display the price of each course
                            "\nTotal Amount:  " + TotalPriceLabel.Text + // Display the total price
                            "\nPayment Type: " + Payment+ // Display the payment type selected
                            "\nReceipt Request: " + Receipt+ // Display if the customer wants an e-mail receipt or not
                            "\nOrder Status: " + Courses + " courses have been purchased"); // Display the order status
                        }
                        else 
                        {
                            MessageBox.Show("Order must contain at least one course and not contain more than four courses"); // Show error message if the more than four courses were selected
                        }
                    }             
                }
            }
            catch (Exception ex)
            {
                // Display message if error occurs when attempting to write file
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display About form when about is selected from the menu bar
            AboutForm f2 = new AboutForm(); 
            f2.ShowDialog();
        }
        
        private void ClearForm()
        {
            // Reseting the form to its original state
            FirstNameTextBox.Focus(); // Send focus to First Name Text Box
            FirstNameTextBox.Text = ""; // Clear First Name
            LastNameTextBox.Text = ""; // Clear Last Name
            EmailAddressTextBox.Text = ""; // Clear E-mail address
            DateOfBirthMaskedTextBox.Text = ""; // Clear Date of Birth
            StatusComboBox.SelectedItem=""; // Clear the selected item from status combo box
            StatusComboBox.Text = ""; // Clear the combo box
            LiveActionRadioButton.Checked = true; //Go back to live action default button as type of class
            FoodsInTheCategory.ResetText(); // Clear Available classes 
            FoodsInTheCategory.ClearSelected(); // Deselect all the selected classes
            CashRadioButton.Checked = true; // Go back to cash default button as payment type
            ReceiptCheckBox.Checked = false; // Go back to unchecking receipt default 
            NumberOfClassesLabel.Text = "0"; // Clear number of courses selected
            TotalPriceLabel.Text = "0.00"; // Clear total price
        }

        private void LiveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateBoxes(); // Shortcut to input files for listboxes
            UpdateTotals(); // Shortcut to update the course registration group box
        }
        private void PopulateBoxes()
        {
            FoodsInTheCategory.Items.Clear(); // Clear the available classes list box

            try
            {
                StreamReader inputFile; // Declare StreamReader object for input file
                inputFile = File.OpenText("LiveActionClasses.txt"); // Open file with Live action classes
                if (LiveActionRadioButton.Checked)  
                    while (!inputFile.EndOfStream) // Verify that more data exists to read
                    {
                        FoodsInTheCategory.Items.Add(inputFile.ReadLine()); // Display the classes when live action radio button is selected
                    }
                inputFile.Close(); // Close input file after reading

                inputFile = File.OpenText("AnimationClasses.txt"); // Open file with Animation classes
                if (AnimationRadioButton.Checked)
                    while (!inputFile.EndOfStream) // Verify that more data exists to read
                    {
                        FoodsInTheCategory.Items.Add(inputFile.ReadLine()); // Display the classes when animation radio button is selected
                    }
                inputFile.Close(); // Close input file after reading
            }
            catch (Exception ex)
            {
                // Display message if error occurs when attempting to write file
                MessageBox.Show(ex.Message);
                this.Close(); // Close the form
            }

            PricePerClassLabel.Text = CoursePrice.ToString("c"); //Convert price per class label to string
        }

        private void UpdateTotals()
        {
            NumofClasses = 0; // Number of classes is 0 by default

            for (int count = 0; count < FoodsInTheCategory.Items.Count; count++) // Loop through all items in list box and write selected items to output file
            {
                if (FoodsInTheCategory.GetSelected(count)) // Use GetSelected method to determine if a listbox is selected or not
                { NumofClasses++; } // Add the number of classes 
            }


            if (LiveActionRadioButton.Checked)
            {
                CoursePrice = LiveActionPrice; // Course price is 79.95$ if Live action radio button is selected
            }
            else
            {
                CoursePrice = AnimationPrice; // Course price is 99.95$ if Animation radio button is selected 
            }

            TotalAmount = CoursePrice * NumofClasses; // Total price is the product of number of classes selected and the price of each course
            PricePerClassLabel.Text = CoursePrice.ToString("c"); // convert price per class label into string
            NumberOfClassesLabel.Text = NumofClasses.ToString(); // convert number of classes label into string
            TotalPriceLabel.Text = TotalAmount.ToString("c"); // convert total amount or price label into string
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm(); // Shortcut to reset the form into original state 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit; // Display a dialog box when exit is selected
            exit = MessageBox.Show("Are you sure you wish to exit the program?", // Ask the user if he wishes to exit the program
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Display Yes or No
            if (exit == DialogResult.Yes)
            {
            this.Close(); // Close the form if Yes is selected 
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AvailableClassesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Shortcut to update the course registration group box
        }

        private void RegistrationForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

