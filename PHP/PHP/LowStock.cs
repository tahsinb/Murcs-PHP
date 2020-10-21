using PHP.Database;
using PHP.Database.Classes;
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
    public partial class LowStock : Form
    {
        PHPRepo _PHPRepo;
        private int prodID;
        private Product _product;
        List<Product> _lowStockList;

        public LowStock(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _lowStockList = pHPRepo.GetLowStockProducts();
            DisplayLowStock();
        }

        private void DisplayLowStock()
        {
            foreach(Product p in _lowStockList)
            {
                AddProductToTable(p);
            }
        }

        private void AddProductToTable(Product prod)
        {
            string[] row = { prod.ProductId.ToString(), prod.Product_Name, prod.Stock_Level.ToString() };
            var listViewItem = new ListViewItem(row);
            LowStockTable.Items.Add(listViewItem);
        }



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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LowStockTable.Items.Clear();
            if (_PHPRepo.GetProductbyId(prodID) == null || textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid product ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DisplayLowStock();
                textBox1.Text = "";
            }
            else
            {
                _product = _PHPRepo.GetProductbyId(prodID);
                if(_lowStockList.Contains(_product))
                {
                    AddProductToTable(_product);
                }
                else
                {

                    MessageBox.Show("This product has not been flagged for low stock.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DisplayLowStock();
                    textBox1.Text = "";
                }
                

               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "";
                LowStockTable.Items.Clear();
                DisplayLowStock();
            }
            else
            {
                try
                {
                    prodID = Int32.Parse(textBox1.Text);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid product ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
            }
            LowStockTable.Items.Clear();
            DisplayLowStock();
        }
    }
}
