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

        bool current_month = false;
        DateTime firstDayOfThisMonth;
        DateTime _to;
        DateTime _from;

        string folder = null;
        string default_filepath = "C:/Reports/Monthly Reports/";

        Dictionary<string, List<double>> prod_data = new Dictionary<string, List<double>>();
        private double _totalSales;
        private double _totalRevenue;

        public MonthlyReport(PHPRepo pHPRepo)
        {
            InitializeComponent();

            firstDayOfThisMonth = DateTime.Today.AddDays(-(DateTime.Today.Day - 1));
            _to = firstDayOfThisMonth.AddDays(-1);
            _from = firstDayOfThisMonth.AddMonths(-1);

            _PHPRepo = pHPRepo;
            _SalesList = _PHPRepo.GetSaleByDate(_from, _to);
            DisplaySales();
            
        }
        private void DisplaySales()
        {
            foreach (Sale sale in _SalesList)
            {
                SortData(sale);
            }

            AddSaleToTable(prod_data);
            AddTotalsToTable();
        }

        // sort data so no duplicates appear and quantities are calculated
        private void SortData(Sale sale)
        {
          
            foreach (ProductSale p in sale.ProductSales)
            {
                string p_name = p.Product.Product_Name;
                int p_quantity = p.Quantity;
                double p_price = p.Product.Price;

                if (prod_data.ContainsKey(p_name))
                {
                    prod_data[p_name][0] += p_quantity;
                    _totalSales += p_quantity;
                    continue;
                }
                prod_data.Add(p_name, new List<double> { p_quantity, p_price });
                _totalSales += p_quantity;
            }
        }
        // add sorted data to list view table
        private void AddSaleToTable(Dictionary<string, List<double>> sale_data)
        {
            
            foreach (KeyValuePair<string, List<double>> k in sale_data)
            {
                string p_name = k.Key;
                int p_quantity = (Int32)k.Value[0];
                double p_price = k.Value[1];

                string[] reportRow = { p_name, p_quantity.ToString(), p_price.ToString(), (p_price * p_quantity).ToString() };
                var salesReportItem = new ListViewItem(reportRow);

                ReportTable.Items.Add(salesReportItem);

                _totalRevenue += p_price * p_quantity;
            }
           
        }
        void AddTotalsToTable()
        {
            string[] totalsRow = { _totalSales.ToString(), _totalRevenue.ToString() };
            var TotalListItem = new ListViewItem(totalsRow);
            TotalsTable.Items.Add(TotalListItem);
        }

        void ClearTables()
        {
            foreach (ListViewItem i in TotalsTable.Items)
            {
                i.Remove();
            }
            foreach (ListViewItem i in ReportTable.Items)
            {
                i.Remove();
            }
        }
        private void CurrentToggle_CheckedChanged(object sender, EventArgs e)
        {
            ClearTables();
            prod_data.Clear();
            current_month = !current_month;
            // clear data and tables, reset sales and renenue count
            _totalSales = 0;
            _totalRevenue = 0;

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

            _SalesList.Clear();
            _SalesList = _PHPRepo.GetSaleByDate(_from, _to);
            DisplaySales();
            ReportTable.Update();
            TotalsTable.Update();
        }

        //generate csv button
        private void button1_Click(object sender, EventArgs e)
        {

            string month = _from.ToString("MMMM");
            string year = DateTime.Now.Year.ToString();
            if (folder == null)
            {
                folder = default_filepath;
            }

            string filename = folder + "\\" + year +"-"+month + ".csv";
            System.IO.Directory.CreateDirectory(folder);
            PHP.Functions.GenerateCSV.ListViewToCSV(ReportTable, TotalsTable,filename);

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
        private void MonthlyReport_FormClosing(Object sender, FormClosingEventArgs e)
        {
            CurrentToggle.Checked = false;
        }
    }
}
