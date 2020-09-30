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
    public partial class ViewSale : Form
    {
        private IDatabaseAppSettings _databaseAppSettings;
        private int SaleID;
        private Sale _sale;
        List<Sale> _SalesList;
        PHPRepo _PHPRepo;
        public ViewSale(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _SalesList = pHPRepo.GetSales();
            DisplaySales();
        }

        private void SaleID_Search(object sender, EventArgs e)
        {
            SaleTable.Items.Clear();
            if (_PHPRepo.GetSaleById(SaleID) == null)
                MessageBox.Show("Could not find sale", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                _sale = _PHPRepo.GetSaleById(SaleID);
                AddSaleToTable(_sale);
            }
        }
        private void DisplaySales()
        {
            
            foreach(Sale sale in _SalesList)
            {
                AddSaleToTable(sale);
            }
        }
        private void AddSaleToTable(Sale sale)
        {
            string[] row = {sale.SaleId.ToString(), sale.Sale_Date.ToString(),
                            sale.Total_Cost.ToString(), sale.Customer_Name,
                            sale.EmployeeId.ToString()};
            var listViewItem = new ListViewItem(row);
            SaleTable.Items.Add(listViewItem);
        }

        private void SaleID_TexChanged(object sender, EventArgs e)
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
    }
}
