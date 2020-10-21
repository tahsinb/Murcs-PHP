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
        AutoCompleteStringCollection ACprodNames = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ACprodIDs = new AutoCompleteStringCollection();
        List<Product> _ProductList;
        Product prod1 = new Product();
        Product prod2 = new Product();
        Product prod3 = new Product();
        Product prod4 = new Product();
        Product prod5 = new Product();

        public AddTransaction(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            setEmpDetails();

            //initialise autocomplete
            _ProductList = pHPRepo.GetProducts();
            initialiseAutocomplete();

            
        }

        //Methods to validate data entry into form
        #region Validation Checks

        //only allows integer input on product id fields
        private void prodIDinput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on product id fields
        private void prodIDinput2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on product id fields
        private void prodIDinput3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on product id fields
        private void prodIDinput4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on product id fields
        private void prodIDinput5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on quantity fields
        private void QtyInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on quantity fields
        private void QtyInput2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on quantity fields
        private void QtyInput3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on quantity fields
        private void QtyInput4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //only allows integer input on quantity fields
        private void QtyInput5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //converts first letter of entry to uppercase to so autocomplete is correct
        private void ProdNameInput1_TextChanged(object sender, EventArgs e)
        {
            firstLetterToUpper(ProdNameInput1);
        }

        //converts first letter of entry to uppercase to so autocomplete is correct
        private void ProdNameInput2_TextChanged(object sender, EventArgs e)
        {
            firstLetterToUpper(ProdNameInput2);
        }

        //converts first letter of entry to uppercase to so autocomplete is correct
        private void ProdNameInput3_TextChanged(object sender, EventArgs e)
        {
            firstLetterToUpper(ProdNameInput3);
        }

        //converts first letter of entry to uppercase to so autocomplete is correct
        private void ProdNameInput4_TextChanged(object sender, EventArgs e)
        {
            firstLetterToUpper(ProdNameInput4);
        }

        //converts first letter of entry to uppercase to so autocomplete is correct
        private void ProdNameInput5_TextChanged(object sender, EventArgs e)
        {
            firstLetterToUpper(ProdNameInput5);
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
        /// Validates that all fields have been completed successfully before saving and
        /// continuing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            //checks if all fields are completed 
            if (!string.IsNullOrEmpty(CustomerNameInput.Text) && row1Complete())
            {
                //_sale.SaleId = Int32.Parse(SaleIDInput.Text);
                _sale.Sale_Date = DateTime.Now;
               
                _sale.Customer_Name = CustomerNameInput.Text;
                _sale.Total_Cost = saleTotal;

                //generate row1 product
                Product product1 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput1.Text));
                if (product1 != null)
                {
                    _sale.ProductSales.Add(new ProductSale()
                    {
                        Product = product1,
                        Quantity = Int32.Parse(QtyInput1.Text)

                    });
                }
                //TODO: pass this product to relevant db, reduce stock count 

                if (row2Complete())
                {
                    //generate row2 product
                    Product product2 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput2.Text));
                    if (product2 != null)
                    {
                        _sale.ProductSales.Add(new ProductSale()
                        {
                            Product = product2,
                            Quantity = Int32.Parse(QtyInput2.Text)

                        });
                    }
                }

                if (row3Complete())
                {
                    //generate row3 product
                    Product product3 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput3.Text));
                    if (product3 != null)
                    {
                        _sale.ProductSales.Add(new ProductSale()
                        {
                            Product = product1,
                            Quantity = Int32.Parse(QtyInput3.Text)

                        });
                    }
                }

                if (row4Complete())
                {
                    //generate row4 product
                    Product product4 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput4.Text));
                    if (product4 != null)
                    {
                        _sale.ProductSales.Add(new ProductSale()
                        {
                            Product = product4,
                            Quantity = Int32.Parse(QtyInput4.Text)

                        });
                    }
                }

                if (row5Complete())
                {
                    //generate row5 product
                    Product product5 = _PHPRepo.GetProductbyId(Int32.Parse(prodIDinput5.Text));
                    if (product5 != null)
                    {
                        _sale.ProductSales.Add(new ProductSale()
                        {
                            Product = product5,
                            Quantity = Int32.Parse(QtyInput5.Text)

                        });
                    }
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


        //calculates and displays price by multiplying quantity of item by its price, after quantity is validated
        private void calcPriceByQty(TextBox inputPrice, TextBox inputQty, Product inputProd)
        {
            if (InputIsNumber(inputQty.Text))
            {
                double price1;
                price1 = (Int32.Parse(inputQty.Text) * inputProd.Price);
                inputPrice.Text = price1.ToString();
            }
        }

        //function to convert first letter to uppercase if it is in lowercase
        private void firstLetterToUpper(TextBox inputTextbox)
        {
            if (inputTextbox.Text != "" && (char.IsLower(Convert.ToChar(inputTextbox.Text.Substring(0, 1)))))
            {
                inputTextbox.Text = inputTextbox.Text.Replace(inputTextbox.Text.Substring(0, 1), inputTextbox.Text.ToUpper());
                inputTextbox.SelectionStart = 2;
            }
        }

        //automatically sets the employee ID and name
        private void setEmpDetails()
        {
            EmpIDDisplay.Text = _PHPRepo.currentEmployee.EmployeeId.ToString();
            EmpNameDisplay.Text = _PHPRepo.currentEmployee.Employee_Name;
            _sale.EmployeeId = _PHPRepo.currentEmployee.EmployeeId;
            _sale.Employee = _PHPRepo.currentEmployee;
        }



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

        //sets sale product when product name is entered
        private Product setProdByName(TextBox inputTextBox)
        {
            Product saleProd = new Product();
            foreach (Product p in _ProductList)
            {
                if (p.Product_Name == inputTextBox.Text)
                {
                    saleProd = p;
                    break;
                }
            }
            return saleProd;
        }

        //sets sale product when Product ID is entered
        private Product setProdByID(TextBox inputTextBox)
        {
            Product saleProd = new Product();
            foreach (Product p in _ProductList)
            {
                try
                {
                    if (Int32.Parse(inputTextBox.Text) == p.ProductId)
                    {
                        saleProd = p;
                        break;
                    }
                }
                catch (System.FormatException)
                { }
            }
            return saleProd;
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

        #region Autocomplete Functionality

        //initialise autocomplete functionality
        private void initialiseAutocomplete()
        {
            List<string> nameList = new List<string>();
            List<string> idList = new List<string>();

            //sorts product names and ids and stores in respective list
            foreach (Product p in _ProductList)
            {
                nameList.Add(p.Product_Name);
                idList.Add(p.ProductId.ToString());
            }
            nameList.Sort();
            idList.Sort();
            

            //adds sorted names to autocomplete suggestion list
            foreach (string s in nameList)
            {
                ACprodNames.Add(s);
            }

            //adds sorted product IDs to autocomplete suggestion list
            foreach(string s in idList)
            {
                ACprodIDs.Add(s);
            }

            //gives each product name input field access to autocomplete suggestion list
            ProdNameInput1.AutoCompleteCustomSource = ACprodNames;
            ProdNameInput2.AutoCompleteCustomSource = ACprodNames;
            ProdNameInput3.AutoCompleteCustomSource = ACprodNames;
            ProdNameInput4.AutoCompleteCustomSource = ACprodNames;
            ProdNameInput5.AutoCompleteCustomSource = ACprodNames;

            //gives each product ID field access to autocomplete suggestion list
            prodIDinput1.AutoCompleteCustomSource = ACprodIDs;
            prodIDinput2.AutoCompleteCustomSource = ACprodIDs;
            prodIDinput3.AutoCompleteCustomSource = ACprodIDs;
            prodIDinput4.AutoCompleteCustomSource = ACprodIDs;
            prodIDinput5.AutoCompleteCustomSource = ACprodIDs;
        }

        //autofills product name when id is entered
        private void prodIDinput1_Leave(object sender, EventArgs e)
        {
            prod1 = setProdByID(prodIDinput1);
            if (prod1 != null)
            {
                ProdNameInput1.Text = prod1.Product_Name;
            }
            else
            {
                prodIDinput1.Text = "";
            }

        }

        //autofills product name when id is entered
        private void prodIDinput2_Leave(object sender, EventArgs e)
        {
            prod2 = setProdByID(prodIDinput2);
            if (prod2 != null)
            {
                ProdNameInput2.Text = prod2.Product_Name;
            }
            else
            {
                prodIDinput2.Text = "";
            }
        }

        //autofills product name when id is entered
        private void prodIDinput3_Leave(object sender, EventArgs e)
        {
            prod3 = setProdByID(prodIDinput3);
            if (prod3 != null)
            {
                ProdNameInput3.Text = prod3.Product_Name;
            }
            else
            {
                prodIDinput3.Text = "";
            }
        }

        //autofills product name when id is entered
        private void prodIDinput4_Leave(object sender, EventArgs e)
        {
            prod4 = setProdByID(prodIDinput4);
            if (prod4 != null)
            {
                ProdNameInput4.Text = prod4.Product_Name;
            }
            else
            {
                prodIDinput4.Text = "";
            }
        }

        //autofills product name when id is entered
        private void prodIDinput5_Leave(object sender, EventArgs e)
        {
            prod5 = setProdByID(prodIDinput5);
            if (prod5 != null)
            {
                ProdNameInput5.Text = prod5.Product_Name;
            }
            else
            {
                prodIDinput5.Text = "";
            }
        }

        //Calculates and shows price when quantity is filled
        private void QtyInput1_Leave(object sender, EventArgs e)
        {
            calcPriceByQty(PriceInput1, QtyInput1, prod1);
        }

        //Calculates and shows price when quantity is filled
        private void QtyInput2_Leave(object sender, EventArgs e)
        {
            calcPriceByQty(PriceInput2, QtyInput2, prod2);
        }

        //Calculates and shows price when quantity is filled
        private void QtyInput3_Leave(object sender, EventArgs e)
        {
            calcPriceByQty(PriceInput3, QtyInput3, prod3);
        }

        //Calculates and shows price when quantity is filled
        private void QtyInput4_Leave(object sender, EventArgs e)
        {
            calcPriceByQty(PriceInput4, QtyInput4, prod4);
        }

        //Calculates and shows price when quantity is filled
        private void QtyInput5_Leave(object sender, EventArgs e)
        {
            calcPriceByQty(PriceInput5, QtyInput5, prod5);
        }

        //autofills product id when name field is completed
        private void ProdNameInput1_Leave(object sender, EventArgs e)
        {
            prod1 = setProdByName(ProdNameInput1);
            if (prod1 != null)
            {
                prodIDinput1.Text = prod1.ProductId.ToString();
            }
        }

        //autofills product id when name field is completed
        private void ProdNameInput2_Leave(object sender, EventArgs e)
        {
            prod2 = setProdByName(ProdNameInput2);
            if (prod2 != null)
            {
                prodIDinput2.Text = prod2.ProductId.ToString();
            }
        }

        //autofills product id when name field is completed
        private void ProdNameInput3_Leave(object sender, EventArgs e)
        {
            prod3 = setProdByName(ProdNameInput3);
            if (prod3 != null)
            {
                prodIDinput3.Text = prod3.ProductId.ToString();
            }
        }

        //autofills product id when name field is completed
        private void ProdNameInput4_Leave(object sender, EventArgs e)
        {
            prod4 = setProdByName(ProdNameInput4);
            if (prod4 != null)
            {
                prodIDinput4.Text = prod4.ProductId.ToString();
            }
        }

        //autofills product id when name field is completed
        private void ProdNameInput5_Leave(object sender, EventArgs e)
        {
            prod5 = setProdByName(ProdNameInput5);
            if (prod5 != null)
            {
                prodIDinput5.Text = prod5.ProductId.ToString();
            }
        }

        #endregion

        private void CloseButton_Click(object sender, EventArgs e)
        {

                //confirm closing of forms
                if (MessageBox.Show("Are you sure you want to exit this page? All unsaved changes will be lost.", "Close form",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    //confirmed exit
                    this.Close();
                    
                }
                else
                {
                    //do nothing after dialog box is closed
                }
        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult logoutResult = MessageBox.Show("Are you sure you would like to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo);
            if (logoutResult == DialogResult.Yes)
            {

                //close current page
                this.Close();

                //close homepage
                ParentMDI.ActiveForm.Close();

                //return to login page
                new Login(_PHPRepo).Show();

            }
            else if (logoutResult == DialogResult.No)
            {
                //do nothing
            }
        }

       
    }
}

