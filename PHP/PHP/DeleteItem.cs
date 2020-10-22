using PHP.Database;
using PHP.Database.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHP.Database.Classes;
using System.Reflection;
using System.IO;

namespace PHP
{
    public partial class DeleteItem : Form
    {
        List<Product> _ProductList;
        PHPRepo _PHPRepo;
        private HelpProvider helpProvider;

        public DeleteItem(PHPRepo pHPRepo)
        {
            InitializeComponent();
            CreateHelpProvider();
            _PHPRepo = pHPRepo;
            _ProductList = pHPRepo.GetProducts();
            DisplayItems();
        }
        private void CreateHelpProvider()
        {
            helpProvider = new HelpProvider();
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string path = Path.Combine(exeDir, "..\\..\\Resources\\DeleteItem.htm");
            helpProvider.HelpNamespace = path;
            helpProvider.SetHelpNavigator(ProductID, HelpNavigator.TableOfContents);
        }
        private void DisplayItems()
        {
            foreach (Product p in _ProductList)
            {
                string[] row = { p.ProductId.ToString(), p.Product_Name.ToString(), p.Price.ToString(), p.Stock_Level.ToString() };
                var listViewItem = new ListViewItem(row);
                StockList.Items.Add(listViewItem);
            };
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int ID;
            if (int.TryParse(ProductID.Text, out ID))
            {
                if (_PHPRepo.VerifyProductID(ID))
                {
                    _PHPRepo.GetProductbyId(ID);
                    Product _Product = _PHPRepo.GetProductbyId(ID);
                    _PHPRepo.deleteProduct(_Product);
                    MessageBox.Show("Product has been deleted ", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.None);
                    StockList.Items.Clear();
                    List<Product> _NewList = _PHPRepo.GetProducts();
                    foreach (Product p in _NewList)
                    {
                        string[] row = { p.ProductId.ToString(), p.Product_Name.ToString(), p.Price.ToString(), p.Stock_Level.ToString() };
                        var listViewItem = new ListViewItem(row);
                        StockList.Items.Add(listViewItem);
                    };
                    ProductID.Clear();
                }
                else
                {
                    MessageBox.Show("Could not find item: " + ID);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteItem_Load(object sender, EventArgs e)
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
