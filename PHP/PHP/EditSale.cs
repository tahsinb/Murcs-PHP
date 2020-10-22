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
    public partial class EditSale : Form
    {
        private int SaleID;
        private Sale _sale;
        List<Sale> _SalesList;
        PHPRepo _PHPRepo;
        private HelpProvider helpProvider;

        public EditSale(PHPRepo pHPRepo)
        {
            InitializeComponent();
            CreateHelpProvider();
            _PHPRepo = pHPRepo;
            _SalesList = pHPRepo.GetSales();
            InitialiseTextBoxes();
            DisplaySales();
        }

        private void CreateHelpProvider()
        {
            helpProvider = new HelpProvider();
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string path = Path.Combine(exeDir, "..\\..\\Resources\\EditSale.htm");
            helpProvider.HelpNamespace = path;
            helpProvider.SetHelpNavigator(SaleIDtext, HelpNavigator.TableOfContents);
            helpProvider.SetHelpNavigator(DateBox, HelpNavigator.TableOfContents);
            helpProvider.SetHelpNavigator(CostBox, HelpNavigator.TableOfContents);
            helpProvider.SetHelpNavigator(NameBox, HelpNavigator.TableOfContents);
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
            enableTextBoxes();
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
                DateBox.Text = _sale.Sale_Date.ToString();
                CostBox.Text = _sale.Total_Cost.ToString();
                NameBox.Text = _sale.Customer_Name;

            }
        }
        private void DisplaySales()
        {

            foreach (Sale sale in _SalesList)
            {
                AddSaleToTable(sale);
            }
        }

        private void ClickConfirm(object sender, EventArgs e)
        {
            if(DateBox.Text != "" )
            {
                _sale.Sale_Date = Convert.ToDateTime(DateBox.Text);
            }
            if (CostBox.Text != "")
            {
                _sale.Total_Cost = double.Parse(CostBox.Text);
            }
            if (NameBox.Text != "")
            {
                _sale.Customer_Name = NameBox.Text; 
            }
            _PHPRepo.EditSalesRecord(_sale);
            SaleTable.Items.Clear();
            _sale = _PHPRepo.GetSaleById(SaleID);
            AddSaleToTable(_sale);
            InitialiseTextBoxes();
            SaleIDtext.Clear();
        }
        private void AddSaleToTable(Sale sale)
        {
            string[] row = {sale.SaleId.ToString(), sale.Sale_Date.ToString(),
                            sale.Total_Cost.ToString(), sale.Customer_Name,
                            sale.EmployeeId.ToString()};
            var listViewItem = new ListViewItem(row);
            SaleTable.Items.Add(listViewItem);
        }
        private void InitialiseTextBoxes()
        {
            DateBox.Clear();
            DateBox.Enabled = false;
            CostBox.Clear();
            CostBox.Enabled = false;
            NameBox.Clear();
            NameBox.Enabled = false;
        }
        private void enableTextBoxes()
        {
            DateBox.Enabled = true;
            CostBox.Enabled = true;
            NameBox.Enabled = true;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
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
