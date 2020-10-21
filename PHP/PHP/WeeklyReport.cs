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

        DateTime _from;
        DateTime _to;

        string folder = null;
        string default_filepath = "C:/Reports/Weekly Reports/";

        Dictionary<string, List<double>> prod_data = new Dictionary<string, List<double>>();

        private int _totalSales;
        private double _totalRevenue;

        public WeeklyReport(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _from = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
            _to = DateTime.Now;
            _SalesList = pHPRepo.GetSaleByDate(_from, _to);
            DisplaySales();
        }

        private void DisplaySales()
        {
            foreach (Sale sale in _SalesList)
            {
                SortData(sale); 
            }
            AddSaleToTable(prod_data);
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
            string[] totalsRow = { _totalSales.ToString(), _totalRevenue.ToString() };
            var TotalListItem = new ListViewItem(totalsRow);
            TotalsTable.Items.Add(TotalListItem);
        }

        // generate csv button
        private void button1_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.Date.DayOfWeek.ToString();
            string date_from = _from.ToString("d").Replace('/','-');
            string date_to = _to.ToString("d").Replace('/','-');
            if (folder == null)
            {
                folder = default_filepath;
            }

            string filename = folder + "\\" + date_from +" to " +date_to + ".csv";
            System.IO.Directory.CreateDirectory(folder);
            PHP.Functions.GenerateCSV.ListViewToCSV(ReportTable, TotalsTable,filename);

            var ConfirmationPopup = new Popup_FileGenerated(folder);
            ConfirmationPopup.Show(this);
        }

        // select filepath button
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
