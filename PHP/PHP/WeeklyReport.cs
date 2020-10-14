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
    public partial class WeeklyReport : Form
    {
        private IDatabaseAppSettings _databaseAppSettings;
        private int _saleID;
        private Sale _sale;
        List<Sale> _SalesList;
        PHPRepo _PHPRepo;

        private double _totalSales;
        private double _totalRevanue;

        public WeeklyReport(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _SalesList = pHPRepo.GetSales();
            DisplaySales();
            DisplayTotalSales();
            DisplayTotalRevanue();
        }

        private void DisplaySales()
        {

            foreach (Sale sale in _SalesList)
            {
                AddSaleToTable(sale); 
            }
        }
        bool InTheSameWeek(DateTime date1, DateTime date2)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
        }
        private void AddSaleToTable(Sale sale)
        {
            if (InTheSameWeek(DateTime.Now, sale.Sale_Date))
            {
                string[] row = {sale.SaleId.ToString(), sale.Sale_Date.ToString(),
                        sale.Total_Cost.ToString(), sale.Customer_Name};
                var listViewItem = new ListViewItem(row);
                SaleTable.Items.Add(listViewItem);
            }   
        }

        //calculate and display total sales (maybe not needed?)
        private void DisplayTotalSales()
        {
        }

        //calculate and display total revanue
        private void DisplayTotalRevanue()
        {
            for (int j = 0; j < this.SaleTable.Items.Count; j++)
            {
                string s_value = SaleTable.Items[j].SubItems[2].Text;
                _totalRevanue += Convert.ToDouble(s_value);
            }

            TotalRevanue.Text = _totalRevanue.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {

        }
    }
}
