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
    public partial class ViewSale : Form
    {
        private IDatabaseAppSettings _databaseAppSettings;
        private int SaleID;
        private Sale _sale;
        PHPRepo _PHPRepo;
        public ViewSale(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaleID = int.Parse(SaleIDtext.Text);
        }

        private void SaleID_Search(object sender, EventArgs e)
        {
            _sale = _PHPRepo.GetSaleById(SaleID);
            string[] row = {_sale.SaleId.ToString(), _sale.Sale_Date.ToString(),
                            _sale.Total_Cost.ToString(), _sale.Customer_Name,
                            _sale.Employee.Employee_Name, _sale.EmployeeId.ToString()};
            var listViewItem = new ListViewItem(row);
            SaleTable.Items.Add(listViewItem);
            
            


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
