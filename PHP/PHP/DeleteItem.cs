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

namespace PHP
{
    public partial class DeleteItem : Form
    {
        

        List<Product> _ProductList;
        PHPRepo _PHPRepo;
        public DeleteItem(PHPRepo pHPRepo)
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
                listView1.Items.Add(listViewItem);
            };
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox1.Text, out ID);
            Product _Product = _PHPRepo.GetProductbyId(ID);
            _PHPRepo.deleteProduct(_Product);
            MessageBox.Show("Product has been deleted ", "Sucessful", MessageBoxButtons.OK, MessageBoxIcon.None);
            listView1.Items.Clear();
            List<Product> _NewList = _PHPRepo.GetProducts();
            foreach (Product p in _NewList)
            {
                string[] row = { p.ProductId.ToString(), p.Product_Name.ToString(), p.Price.ToString(), p.Stock_Level.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            };
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
    }
}
