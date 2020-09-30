using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHP.Database;
using PHP.Database.Classes;

namespace PHP
{
    public partial class AddTransaction : Form
    {
        private Sale _sale = new Sale();
        private double saleTotal;
        PHPRepo _PHPRepo;
        public AddTransaction(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
        }


        //Methods to validate data entry into form
        #region Validation Checks

        /// <summary>
        /// Validates that Employee Name field is not empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmpNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (this.EmpNameInput.Text == string.Empty)
            {
                MessageBox.Show("Please enter employee name.");
            }
        }

        /// <summary>
        /// Validates that Customer Name field is not empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (this.CustomerNameInput.Text == string.Empty)
            {
                MessageBox.Show("Please enter customer name.");
            }
        }

        /// <summary>
        /// Only allows letters to be entered in the Customer name field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back
                         || e.KeyChar == (char)Keys.Space);
        }

        /// <summary>
        /// Only allows letters to be entered in the employee name field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmpNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back
                         || e.KeyChar == (char)Keys.Space);
        }

        /// <summary>
        /// Validates that all fields have been completed successfully before saving and
        /// continuing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            //checks if all fields are completed 
            if (SaleIDInput.MaskCompleted && !string.IsNullOrEmpty(EmpNameInput.Text)
                && !string.IsNullOrEmpty(CustomerNameInput.Text) && EmpIDInput.MaskCompleted && row1Complete())
            {
                _sale.SaleId = Int32.Parse(SaleIDInput.Text);
                _sale.Sale_Date = DateTime.Now;
                _sale.EmployeeId = Int32.Parse(EmpIDInput.Text);
                _sale.Employee = _PHPRepo.GetEmployeeById(Int32.Parse(EmpIDInput.Text));
                _sale.Customer_Name = CustomerNameInput.Text;
                _sale.Total_Cost = saleTotal;

                //generate row1 product
                Product product1 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput1.Text));
                //TODO: pass this product to relevant db, reduce stock count 

                if (row2Complete())
                {
                    //generate row2 product
                    Product product2 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput2.Text));
                }

                if (row3Complete())
                {
                    //generate row3 product
                    Product product3 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput3.Text));
                }

                if (row4Complete())
                {
                    //generate row4 product
                    Product product4 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput4.Text));
                }

                if (row5Complete())
                {
                    //generate row5 product
                    Product product5 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput5.Text));
                }

                _PHPRepo.AddSalesRecord(_sale);
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
            double total = 0;
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
                            total += double.Parse(priceArray[i]);
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

                saleTotal = total;
                /*converts total back to string and formats it to have 2 decimal places 
                and display a $ sign in front*/
                this.TotalOutput.Text = "$" + total.ToString();

            }
        }

        
        #endregion

        //Checks for completion of each row of table
        #region Row Checks

            //Checks whether the first row of the table is complete
            private bool row1Complete()
            {
                if (!string.IsNullOrEmpty(prodIDinput1.Text) && !string.IsNullOrEmpty(ProdNameInput1.Text)
                    && !string.IsNullOrEmpty(QtyInput1.Text) && !string.IsNullOrEmpty(PriceInput1.Text))
                    return true;
                else
                    return false;
            }

            //Checks whether the second row of the table is complete
            private bool row2Complete()
            {
                if (!string.IsNullOrEmpty(prodIDinput2.Text) && !string.IsNullOrEmpty(ProdNameInput2.Text)
                    && !string.IsNullOrEmpty(QtyInput2.Text) && !string.IsNullOrEmpty(PriceInput2.Text))
                    return true;
                else
                    return false;
            }

            //Checks whether the third row of the table is complete
            private bool row3Complete()
            {
                if (!string.IsNullOrEmpty(prodIDinput3.Text) && !string.IsNullOrEmpty(ProdNameInput3.Text)
                    && !string.IsNullOrEmpty(QtyInput3.Text) && !string.IsNullOrEmpty(PriceInput3.Text))
                    return true;
                else
                    return false;
            }

            //Checks whether the fourth row of the table is complete
            private bool row4Complete()
            {
                if (!string.IsNullOrEmpty(prodIDinput4.Text) && !string.IsNullOrEmpty(ProdNameInput4.Text)
                    && !string.IsNullOrEmpty(QtyInput4.Text) && !string.IsNullOrEmpty(PriceInput4.Text))
                    return true;
                else
                    return false;
            }

            //Checks whether the fifth row of the table is complete
            private bool row5Complete()
            {
                if (!string.IsNullOrEmpty(prodIDinput5.Text) && !string.IsNullOrEmpty(ProdNameInput5.Text)
                    && !string.IsNullOrEmpty(QtyInput5.Text) && !string.IsNullOrEmpty(PriceInput5.Text))
                    return true;
                else
                    return false;
            }
        #endregion

        //Methods called when data is entered on any cell in the Price column of the table,
        #region Price Input Handlers

            private void PriceInput1_TextChanged(object sender, EventArgs e)
            {
                CalculateTotal();
            }

            private void PriceInput2_TextChanged(object sender, EventArgs e)
            {
                CalculateTotal();
            }

            private void PriceInput3_TextChanged(object sender, EventArgs e)
            {
                CalculateTotal();
            }

            private void PriceInput4_TextChanged(object sender, EventArgs e)
            {
                CalculateTotal();
            }

            private void PriceInput5_TextChanged(object sender, EventArgs e)
            {
                CalculateTotal();
            }



        #endregion

    
    }
}

