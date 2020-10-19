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
        double PredictedWeeklySales;
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
            PredictionPeriod.Text = DateTime.Now.AddDays(-7).ToString() + " - " + DateTime.Now.ToString();
            if (_PHPRepo.GetProductByType(_productType) == null)
                MessageBox.Show("Invalid Product Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ProductTypeList = _PHPRepo.GetProductByType(_productType);
                ProductTypeTextBox.Text = _productType;
            }
            for (int i = 0; i < 4; i++)
            {
                WeeklySalesList = _PHPRepo.GetSaleByDate(DateTime.Today.AddDays(-7*(i+1)), DateTime.Today.AddDays(-7*i));
                foreach (Product p in ProductTypeList)
                {
                    foreach (Sale s in WeeklySalesList)
                    {
                        foreach (ProductSale ps in s.ProductSales)
                        {
                            Console.WriteLine(WeeklySales[i]);
                            if (ps.Product == p)
                                WeeklySales[i]++;
                        }
                    }
                }
                //WeeklySales[i] = WeeklySales[i] * (0.7 - 1/i*(15));
            }
            for (int i = 0; i < 4; i++)
            {
                PredictedWeeklySales = +WeeklySales[i];
            }
            PredictedWeeklySales = PredictedWeeklySales / 4;
            SalesPredictionText.Text = PredictedWeeklySales.ToString();


        }
    }
}
