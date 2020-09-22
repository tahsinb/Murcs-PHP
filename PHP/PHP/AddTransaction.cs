using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP
{
    public partial class AddTransaction : Form
    { 
        //Default Constructor
        #region Constructor
        public AddTransaction()
        {
            InitializeComponent();
        }

        #endregion

        //Methods to validate data entry into form
        #region Validation Checks

        /// <summary>
        /// Validates that Employee Name field is not empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameEntry_Validating(object sender, CancelEventArgs e)
        {
            if (this.NameEntry.Text == string.Empty)
            {
                MessageBox.Show("Please enter employee name.");
            }
        }

        /// <summary>
        /// Only allows letters to be entered in the Employee name field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back 
                         ||e.KeyChar == (char)Keys.Space);
        }

        /// <summary>
        /// Validates that all fields have been completed successfully before saving and
        /// continuing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //checks if all fields are completed
            if (InvNumInput.MaskCompleted && SaleDate.Checked && !string.IsNullOrEmpty(NameEntry.Text)
                && EmpIDInput.MaskCompleted && !string.IsNullOrEmpty(ProdIDinput1.Text) &&
                !string.IsNullOrEmpty(QTYinput1.Text) && !string.IsNullOrEmpty(PriceInput1.Text))
            {
                //TODO: INSERT DATABASE EXPORT FUNCTIONALITY HERE
                MessageBox.Show("Transaction recorded successfully.");
            }
            else
            {
                MessageBox.Show("Please complete all fields before trying to save.");
                //TODO: Highlight or pinpoint which field is incomplete
            }
        }

        #endregion

        //Extra functions that are used throughout the form.
        #region Helper Functions

        /// <summary>
        /// This function will verify that the input text string contains all integers.
        /// </summary>
        /// <param name="input">The instance of the text input which needs to be validated as a number.</param>
        /// <returns>Returns true if input string is all integers, else returns false.</returns>
        private bool InputIsNumber(string input)
        {
            int number;
            bool isNumber = Int32.TryParse(input, out number);
            return isNumber;
        }

        /// <summary>
        /// Calculates and displays the total of the prices entered in the table, to 2 decimal places.
        /// </summary>
        private void CalculateTotal()
        {
            //initialise variable to store total
            float total = 0;
            //stores prices entered in a string array
            string[] priceArray = new string[] {PriceInput1.Text, PriceInput2.Text,
                                   PriceInput3.Text, PriceInput4.Text, PriceInput5.Text};

            //Cycles through array
            for (int i = 0; i < 5; i++)
            {
                //Only takes into account the fields that have information entered, ignores empty fields
                if (priceArray[i] != string.Empty)
                {
                    //if a whole number is entered
                    if (!priceArray[i].Contains('.'))
                    {
                        //Convert text entered to integer and add to total
                        try
                        {
                            total += Int32.Parse(priceArray[i]);
                        }
                        catch (FormatException)
                        {
                            //Error message is shown if invalid character is entered
                            MessageBox.Show("Please enter a valid price.");
                        }
                    }
                    //if a decimal number is entered
                    else if (priceArray[i].Contains('.'))
                    {
                        //Convert text entered to float and add to total
                        try
                        {
                            total += float.Parse(priceArray[i]);
                        }
                        /*Catch exception thrown when a character other than a number or decimal point 
                          is entered*/
                        catch (FormatException)
                        {
                            //Error message shown if invalid character is entered
                            MessageBox.Show("Please enter a valid price.");
                        }
                    }
                }

                /*converts total back to string and formats it to have 2 decimal places 
                and display a $ sign in front*/
                this.TotalOutput.Text = "$" + total.ToString();
            }
        }

        #endregion

        //Methods called when data is entered on any cell in the Price column of the table,
        #region Price Input Handlers

        //handles input for price cell on 1st row
        private void PriceInput1_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        //handles input for price cell on 2nd row
        private void PriceInput2_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        //handles input for price cell on 3rd row
        private void PriceInput3_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        //handles input for price cell on 4th row
        private void PriceInput4_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        //handles input for price cell on 5th row
        private void PriceInput5_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
        #endregion
    }
}

           