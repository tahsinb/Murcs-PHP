using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHP.Database;
using PHP.Database.Classes;

namespace PHP
{
    public partial class WeeklyReport : Form
    {
        private IDatabaseAppSettings _databaseAppSettings;
        List<Sale> _SalesList;
        PHPRepo _PHPRepo;

        private int _totalSales;
        private double _totalRevenue;

        public WeeklyReport(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _SalesList = pHPRepo.GetSaleByDate(DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek), DateTime.Now);
            DisplaySales();
            DisplayTotalSales();
            DisplayTotalRevenue();
        }

        private void DisplaySales()
        {
            foreach (Sale sale in _SalesList)
            {
                AddSaleToTable(sale); 
            }
        }
   
        private void AddSaleToTable(Sale sale)
        {
            string[] row = {sale.SaleId.ToString(), sale.Sale_Date.ToString(),
                    sale.Total_Cost.ToString(), sale.Customer_Name};
            var listViewItem = new ListViewItem(row);
            SaleTable.Items.Add(listViewItem);
        }

        //calculate and display total sales (maybe not needed?)
        private void DisplayTotalSales()
        {
            foreach(Sale sale in _SalesList)
            {
                for (int i = 0; i < sale.ProductSales.Count; i++)
                {
                    int num = sale.ProductSales.ElementAt(i).Quantity;
                    _totalSales += num;
                }
               
            }
            //_totalSales += Convert.ToInt32(s_count);
            TotalSales.Text = _totalSales.ToString();
        }

        //calculate and display total revanue
        private void DisplayTotalRevenue()
        {
            for (int j = 0; j < this.SaleTable.Items.Count; j++)
            {
                string s_value = SaleTable.Items[j].SubItems[2].Text;
                _totalRevenue += Convert.ToDouble(s_value);
            }

            TotalRevanue.Text = _totalRevenue.ToString();
        }


        private void WeeklyReport_Load(object sender, EventArgs e)
        {

        }
    }
}
