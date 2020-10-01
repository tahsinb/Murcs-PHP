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
    public partial class ViewStock : Form
    {
        private IDatabaseAppSettings _databaseAppSettings;
        private int prodID;
        private Product _product;
        List<Product> _ProductList;
        PHPRepo _PHPRepo;

        
        public ViewStock(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _ProductList = pHPRepo.GetProducts();
            DisplayProducts();
        }

        /// <summary>
        /// Method to display all products in the table
        /// </summary>
        private void DisplayProducts()
        {
            foreach(Product p in _ProductList)
            {
                AddProductToTable(p);
            }
        }

        /// <summary>
        /// Method to add a product to the table
        /// </summary>
        /// <param name="prodToAdd"></param>
        private void AddProductToTable(Product prodToAdd)
        {
            string[] row = {prodToAdd.ProductId.ToString(), prodToAdd.Product_Name.ToString(),
                            prodToAdd.Price.ToString(), prodToAdd.Stock_Level.ToString()};
            var listViewItem = new ListViewItem(row);
            ProductTable.Items.Add(listViewItem);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ProductTable.Items.Clear();
            if(_PHPRepo.GetProductbyId(prodID) == null)
            {
                MessageBox.Show("Could not find sale", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DisplayProducts();
            }
            else
            {
                _product = _PHPRepo.GetProductbyId(prodID);
                AddProductToTable(_product);
            }
        }

        private void ProdIDInput_TextChanged(object sender, EventArgs e)
        {
            //DisplayProducts();
            if(String.IsNullOrEmpty(ProdIDInput.Text))
            {
                ProdIDInput.Text = "";
                ProductTable.Items.Clear();
                DisplayProducts();
            }
            else
            {
                try
                {
                prodID = Int32.Parse(ProdIDInput.Text);

                }
                catch(FormatException)
                {
                    MessageBox.Show("Please enter a valid product ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ProdIDInput.Text = "";
                }
            }
            DisplayProducts();
        }
    }
}
