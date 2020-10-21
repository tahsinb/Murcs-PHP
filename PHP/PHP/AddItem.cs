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
using PHP.Database;

namespace PHP
{
    public partial class AddItem : Form
    {
        PHPRepo _PHPRepo;
        List<Product> _ProductList;
        Product _Product = new Product();
        public AddItem(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
            _ProductList = pHPRepo.GetProducts();
            DisplayItems();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(ID.Text) && !string.IsNullOrEmpty(Price.Text) && !string.IsNullOrEmpty(Stock.Text))
            {
                int IntTest;
                Double DoubleTest;
                Boolean Fail = true;
                while (Fail)
                {
                    if (Int32.TryParse(ID.Text, out IntTest))
                    {
                        _Product.ProductId = Int32.Parse(ID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Not an acceptable ID");
                        Fail = false;
                        break;
                    }

                    if (Double.TryParse(Price.Text, out DoubleTest))
                    {
                        _Product.Price = Double.Parse(Price.Text);
                    }
                    else
                    {
                        MessageBox.Show("Not an acceptable price");
                        Fail = false;
                        break;
                    }

                    if (Int32.TryParse(Stock.Text, out IntTest))
                    {
                        _Product.Stock_Level = Int32.Parse(Stock.Text);
                    }
                    else
                    {
                        MessageBox.Show("Not an acceptable stock level");
                        Fail = false;
                        break;
                    }

                    _Product.Product_Name = Name.Text;
                    _PHPRepo.AddProductRecord(_Product);

                    MessageBox.Show("New product added successfully.");

                    StockList.Items.Clear();
                    List<Product> _NewList = _PHPRepo.GetProducts();
                    foreach (Product p in _NewList)
                    {
                        string[] row = { p.ProductId.ToString(), p.Product_Name.ToString(), p.Price.ToString(), p.Stock_Level.ToString() };
                        var listViewItem = new ListViewItem(row);
                        StockList.Items.Add(listViewItem);
                    };

                    Name.Clear();
                    Price.Clear();
                    ID.Clear();
                    Stock.Clear();

                    Fail = false;
                    break;
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields");
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
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
        //TODO: Highlight or pinpoint which field is incomplete
    }
}
