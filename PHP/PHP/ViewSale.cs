using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private HelpProvider helpProvider;
        public ViewSale(PHPRepo pHPRepo)
        {
            InitializeComponent();
            CreateHelpProvider();
            _PHPRepo = pHPRepo;
            _SalesList = pHPRepo.GetSales();
            DisplaySales();
        }

        private void CreateHelpProvider()
        {
            helpProvider = new HelpProvider();
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string path = Path.Combine(exeDir, "..\\..\\Resources\\ViewSale.htm");
            helpProvider.HelpNamespace = path;
            helpProvider.SetHelpNavigator(SaleIDtext, HelpNavigator.TableOfContents);
        }

        private void SaleID_Search(object sender, EventArgs e)
        {
            SaleTable.Items.Clear();
            if (_PHPRepo.GetSaleById(SaleID) == null)
            {
                MessageBox.Show("Could not find sale", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DisplaySales();
            }
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
                try
                {
                    SaleID = int.Parse(SaleIDtext.Text);
                }
                catch(FormatException)
                {
                    MessageBox.Show("Please enter a valid sale ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SaleIDtext.Text = "";
                }
            }
        }

        private void SaleTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewSale_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
                //confirmed exit
                this.Close();
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

        private void SaleIDtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
