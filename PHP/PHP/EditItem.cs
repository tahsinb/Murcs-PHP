﻿using System;
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
    public partial class EditItem : Form
    {
        List<Product> _ProductList;
        PHPRepo _PHPRepo;
        Product _Product = new Product();
        public EditItem(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _ProductList = _PHPRepo.GetProducts();
            DisplayItems();
        }
        private void DisplayItems()
        {
            _ProductList.Clear();
            _ProductList = _PHPRepo.GetProducts();
            foreach (Product p in _ProductList)
            {
                string[] row = { p.ProductId.ToString(), p.Product_Name.ToString(), p.Price.ToString(), p.Stock_Level.ToString() };
                var listViewItem = new ListViewItem(row);
                ListView1.Items.Add(listViewItem);
            };
        }

        private void EditItem_Load(object sender, EventArgs e)
        {

        }

        private void ProductTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product_ID.Enabled = true;
            Product_Name.Enabled = true;
            Product_Stock.Enabled = true;
            Product_Price.Enabled = true;
            int Id;
            int.TryParse(ID.Text, out Id);
            ListView1.Items.Clear();
            if (_PHPRepo.GetProductbyId(Id) == null)
            {
                MessageBox.Show("Could not find Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _Product = _PHPRepo.GetProductbyId(Id);
                ListView1.Items.Clear();
                string[] row = { _Product.ProductId.ToString(), _Product.Product_Name.ToString(), _Product.Price.ToString(), _Product.Stock_Level.ToString() };
                var listViewItem = new ListViewItem(row);
                ListView1.Items.Add(listViewItem);

                Product_ID.Text = _Product.ProductId.ToString();
                Product_Name.Text = _Product.Product_Name.ToString();
                Product_Stock.Text = _Product.Stock_Level.ToString();
                Product_Price.Text = _Product.Price.ToString();
            }
            ID.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Product.Product_Name = Product_Name.Text;
            _Product.ProductId = Int32.Parse(Product_ID.Text);
            _Product.Stock_Level = Int32.Parse(Product_Stock.Text);
            _Product.Price = Double.Parse(Product_Price.Text);
            _PHPRepo.EditProductRecord(_Product);

            Product_ID.Clear();
            Product_Name.Clear();
            Product_Stock.Clear();
            Product_Price.Clear();

            Product_ID.Enabled = false;
            Product_Name.Enabled = false;
            Product_Stock.Enabled = false;
            Product_Price.Enabled = false;

            ListView1.Items.Clear();
            List<Product> _NewList = _PHPRepo.GetProducts();
            foreach (Product p in _NewList)
            {
                string[] row = { p.ProductId.ToString(), p.Product_Name.ToString(), p.Price.ToString(), p.Stock_Level.ToString() };
                var listViewItem = new ListViewItem(row);
                ListView1.Items.Add(listViewItem);
            };
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
    }
}
