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

namespace PHP
{
    public partial class SalesPrediction : Form
    {
        PHPRepo _PHPRepo;
        List<Product> ProductTypeList;
        List<Sale> WeeklySalesList;
        double[] WeeklySales = new double[4]{ 0, 0, 0, 0 };
        double PredictedWeeklySales = 0;
        string _productType;
        public SalesPrediction(PHPRepo pHPRepo)
        {
            InitializeComponent();
            _PHPRepo = pHPRepo;
        }

        private void ProductType_changed(object sender, EventArgs e)
        {
            _productType = ProductTypeText.Text; 
        }

        private void PredictWeeklySales(object sender, EventArgs e)
        {
            ProductTypeList = _PHPRepo.GetProductByType(_productType);
            if (!(ProductTypeList.Any()))
                MessageBox.Show("Invalid Product Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ProductTypeTextBox.Text = _productType;
                PredictionPeriod.Text = DateTime.Now.AddDays(-7).ToString() + " - " + DateTime.Now.ToString();
            }
            for (int i = 0; i < 4; i++)
            {
                WeeklySalesList = _PHPRepo.GetSaleByDate(DateTime.Now.AddDays(-7*(i+1)), DateTime.Now.AddDays(-7*i));
                foreach (Product p in ProductTypeList)
                {
                    foreach (Sale s in WeeklySalesList)
                    {
                        foreach (ProductSale ps in s.ProductSales)
                        {
                            if (ps.Product == p)
                                WeeklySales[i] = WeeklySales[i] + ps.Quantity;
                        }
                    }
                }
                //WeeklySales[i] = WeeklySales[i] * (0.7 - 1/i*(15));
            }
            for (int i = 0; i < 4; i++)
            {
                PredictedWeeklySales += WeeklySales[i];
            }
            PredictedWeeklySales = Math.Ceiling(PredictedWeeklySales / 4);
            SalesPredictionText.Text = PredictedWeeklySales.ToString();



        }
    }
}
