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
    public partial class EditSale : Form
    {
        private int SaleID;
        private Sale _sale;
        List<Sale> _SalesList;
        PHPRepo _PHPRepo;
        public EditSale(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _SalesList = pHPRepo.GetSales();
            DisplaySales();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SaleIDtext.Text))
            {
                SaleIDtext.Text = "";
                SaleTable.Items.Clear();
                DisplaySales();
            }
            else
            {
                SaleID = int.Parse(SaleIDtext.Text);
            }
        }
        private void SaleID_Search(object sender, EventArgs e)
        {
            SaleTable.Items.Clear();
            if (_PHPRepo.GetSaleById(SaleID) == null)
                MessageBox.Show("Could not find sale", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                _sale = _PHPRepo.GetSaleById(SaleID);
                string[] row = {_sale.SaleId.ToString(), _sale.Sale_Date.ToString(),
                            _sale.Total_Cost.ToString(), _sale.Customer_Name,
                            _sale.EmployeeId.ToString()};
                var listViewItem = new ListViewItem(row);
                SaleTable.Items.Add(listViewItem);
            }
        }
        private void DisplaySales()
        {

            foreach (Sale sale in _SalesList)
            {
                string[] row = {sale.SaleId.ToString(), sale.Sale_Date.ToString(),
                            sale.Total_Cost.ToString(), sale.Customer_Name,
                            sale.EmployeeId.ToString()};
                var listViewItem = new ListViewItem(row);
                SaleTable.Items.Add(listViewItem);
            }
        }

        private void ClickConfirm(object sender, EventArgs e)
        {
            if(SaleIdBox.Text != "")
            {
                _sale.SaleId = int.Parse(SaleIdBox.Text);
            }
            if(DateBox.Text != "")
            {
                _sale.Sale_Date = Convert.ToDateTime(DateBox.Text);
            }
            if (CostBox.Text != "")
            {
                _sale.Total_Cost = int.Parse(CostBox.Text);
            }
            if (NameBox.Text != "")
            {
                _sale.Customer_Name = NameBox.Text; 
            }
            if (IDBox.Text != "")
            {
                _sale.EmployeeId = int.Parse(IDBox.Text);
            }
            SaleTable.Items.Clear();
            _sale = _PHPRepo.GetSaleById(SaleID);
            string[] row = {_sale.SaleId.ToString(), _sale.Sale_Date.ToString(),
                            _sale.Total_Cost.ToString(), _sale.Customer_Name,
                            _sale.EmployeeId.ToString()};
            var listViewItem = new ListViewItem(row);
            SaleTable.Items.Add(listViewItem);
            
            SaleIdBox.Clear();
            SaleIdBox.Enabled = false;


        }
    }
}
