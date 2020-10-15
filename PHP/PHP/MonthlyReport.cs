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
using PHP.Functions;

namespace PHP
{
    public partial class MonthlyReport : Form
    {
        private IDatabaseAppSettings _databaseAppSettings;
        List<Sale> _SalesList;
        PHPRepo _PHPRepo;

        private double _totalSales;
        private double _totalRevenue;

        bool current_month = false;
        DateTime firstDayOfThisMonth;
        DateTime _to;
        DateTime _from;

        string folder = null;
        string default_filepath = "C:/Monthly Reports/";

        public MonthlyReport(PHPRepo pHPRepo)
        {
            InitializeComponent();

            firstDayOfThisMonth = DateTime.Today.AddDays(-(DateTime.Today.Day - 1));
            _to = firstDayOfThisMonth.AddDays(-1);
            _from = firstDayOfThisMonth.AddMonths(-1);

            _PHPRepo = pHPRepo;
            _SalesList = _PHPRepo.GetSaleByDate(_from, _to);

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

        //calculate and display total sales (not working at the moment, maybe not needed?)
        private void DisplayTotalSales()
        {
            _totalSales = 0;
            TotalSales.Text = _totalSales.ToString();
           /* foreach (Sale sale in _SalesList)
            {
                for (int i = 0; i < sale.ProductSales.Count; i++)
                {
                    int num = sale.ProductSales.ElementAt(i).Quantity;
                    _totalSales += num;
                }

            }*/
            //_totalSales += Convert.ToInt32(s_count);
            TotalSales.Text = _totalSales.ToString();
        }

        //calculate and display total revanue
        private void DisplayTotalRevenue()
        {
            _totalRevenue = 0;
            TotalRevanue.Text = _totalRevenue.ToString();

            for (int j = 0; j < this.SaleTable.Items.Count; j++)
            {
                string s_value = SaleTable.Items[j].SubItems[2].Text;
                _totalRevenue += Convert.ToDouble(s_value);
            }

            TotalRevanue.Text = _totalRevenue.ToString();
        }

        private void CurrentToggle_CheckedChanged(object sender, EventArgs e)
        {
            current_month = !current_month;
            foreach(ListViewItem i in SaleTable.Items)
            {
                SaleTable.Items.Remove(i);
            }
            if (current_month)
            {
                _to = DateTime.Now;
                _from = firstDayOfThisMonth;
            }
            else
            {
                _to = firstDayOfThisMonth.AddDays(-1);
                _from = firstDayOfThisMonth.AddMonths(-1);
            }
           
            _SalesList = _PHPRepo.GetSaleByDate(_from, _to);
            DisplaySales();
            DisplayTotalSales();
            DisplayTotalRevenue();
            SaleTable.Update();
        }

        //generate csv button
        private void button1_Click(object sender, EventArgs e)
        {
           
            string month = _from.ToString("MMMM");
            if(folder == null)
            {
                folder = default_filepath;
            }
              
            string filename = folder +"\\"+ month + ".csv";
            System.IO.Directory.CreateDirectory(folder);
            PHP.Functions.GenerateCSV.ListViewToCSV(SaleTable, filename);

            var ConfirmationPopup = new Popup_FileGenerated(folder);
            ConfirmationPopup.Show(this);
        }
        //select filepath button
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folder = diag.SelectedPath;  

            }
        }
    }
}
