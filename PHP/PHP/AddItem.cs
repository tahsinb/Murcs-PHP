﻿using PHP.Database.Classes;
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

namespace PHP
{
    public partial class AddItem : Form
    {
        PHPRepo _PHPRepo;
        List<Product> _ProductList;
        Product _Product = new Product();
        public AddItem(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _ProductList = pHPRepo.GetProducts();
            DisplayItems();
        }
        private void DisplayItems()
        {
            foreach (Product p in _ProductList)
            {
                string[] row = { p.ProductId.ToString(), p.Product_Name.ToString(), p.Price.ToString(), p.Stock_Level.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            };
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            _Product.ProductId = Int32.Parse(ID.Text);
            _Product.Product_Name = Name.Text;
            _Product.Price = Double.Parse(Price.Text);
            _Product.Stock_Level = Int32.Parse(Stock.Text);
            _PHPRepo.AddProductRecord(_Product);
            
            MessageBox.Show("New product added successfully.");

            listView1.Items.Clear();
            List<Product> _NewList = _PHPRepo.GetProducts();
            foreach (Product p in _NewList)
            {
                string[] row = { p.ProductId.ToString(), p.Product_Name.ToString(), p.Price.ToString(), p.Stock_Level.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            };
            Name.Clear();
            Price.Clear();
            ID.Clear();
            Stock.Clear();
        }
private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        //TODO: Highlight or pinpoint which field is incomplete
    }
}
