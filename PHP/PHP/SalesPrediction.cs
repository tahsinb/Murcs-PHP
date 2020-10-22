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
            List<Sale> WeeklySalesList;
            double[] WeeklySales = new double[4] { 0, 0, 0, 0 };
            double[] TotalCost = new double[4] { 0, 0, 0, 0 };
            ProductTypeList = _PHPRepo.GetProductByType(_productType);
            //Check for error in input
            if (!(ProductTypeList.Any()))
                MessageBox.Show("Invalid Product Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ProductTypeTextBox.Text = _productType;
                PredictionPeriod.Text = DateTime.Now.ToString() + " - " + DateTime.Now.AddDays(7).ToString();
            }
            //Data from previous 2 weeks
            for (int i = 0; i < 2; i++)
            {
                //Fill first 2 eleement of array with data from previous 2 weeks
                WeeklySalesList = _PHPRepo.GetSaleByDate(DateTime.Now.AddDays(- 7 - i * 7), DateTime.Now.AddDays(-i*7));
                foreach (Product p in ProductTypeList)
                {
                    foreach (Sale s in WeeklySalesList)
                    {
                        foreach (ProductSale ps in s.ProductSales)
                        {
                            if (ps.Product == p)
                            {
                                TotalCost[i] += ps.Product.Price*ps.Quantity;
                                WeeklySales[i] = WeeklySales[i] + ps.Quantity;
                            }
                        }
                    }
                }
            }

            for (int i = 2; i < 4; i++)
            {
                WeeklySalesList = _PHPRepo.GetSaleByDate(DateTime.Now.AddYears(1- i).AddDays(-7), DateTime.Now.AddYears(1 -i));
                foreach (Product p in ProductTypeList)
                {
                    foreach (Sale s in WeeklySalesList)
                    {
                        foreach (ProductSale ps in s.ProductSales)
                        {
                            if (ps.Product == p)
                            {
                                TotalCost[i] += ps.Product.Price*ps.Quantity;
                                WeeklySales[i] = WeeklySales[i] + ps.Quantity;
                            }
                        }
                    }
                }
            }
            PredictedSales.Text = PredictSales(WeeklySales).ToString();
            TotalCostText.Text = "$" + CostPrediction(TotalCost).ToString();
        }

        private void PredictMonthlySales(object sender, EventArgs e)
        {
            List<Sale> MonthlySalesList;
            double[] MonthlySales = new double[4] { 0, 0, 0, 0 };
            double[] TotalCost = new double[4] { 0, 0, 0, 0 };
            ProductTypeList = _PHPRepo.GetProductByType(_productType);
            if (!(ProductTypeList.Any()))
                MessageBox.Show("Invalid Product Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ProductTypeTextBox.Text = _productType;
                PredictionPeriod.Text = DateTime.Now.ToString() + " - " + DateTime.Now.AddMonths(1).ToString();
            }
            //Fill first 2 eleement of array with data from previous 2 months
            for (int i = 0; i < 2; i++)
            {
                MonthlySalesList = _PHPRepo.GetSaleByDate(DateTime.Now.AddMonths(-1 - i), DateTime.Now.AddMonths(-i));
                foreach (Product p in ProductTypeList)
                {
                    foreach (Sale s in MonthlySalesList)
                    {
                        foreach (ProductSale ps in s.ProductSales)
                        {
                            if (ps.Product == p)
                            {
                                TotalCost[i] += ps.Product.Price*ps.Quantity;
                                MonthlySales[i] += ps.Quantity;
                            }
                        }
                    }
                }
            }
            //Fill fourth element with data from current month one and two years ago
            for (int i = 2; i < 4; i++)
            {
                MonthlySalesList = _PHPRepo.GetSaleByDate(DateTime.Now.AddYears(1 - i).AddMonths(-1), DateTime.Now.AddYears(1 - i));
                foreach (Product p in ProductTypeList)
                {
                    foreach (Sale s in MonthlySalesList)
                    {
                        foreach (ProductSale ps in s.ProductSales)
                        {
                            if (ps.Product == p)
                            {
                                TotalCost[i] += ps.Product.Price * ps.Quantity;
                                MonthlySales[i] = MonthlySales[i] + ps.Quantity;
                            }
                        }
                    }
                }
            }
            PredictedSales.Text = PredictSales(MonthlySales).ToString();
            TotalCostText.Text = "$" + CostPrediction(TotalCost).ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double PredictSales(double [] SalesArr)
        {
            double PredictedSales = 0;
            //Scale weekly/monthly data depending on its importance to the prediction
            SalesArr[0] *= 0.2;
            SalesArr[1] *= 0.1;         
            SalesArr[2] *= 0.5;
            SalesArr[3] *= 0.2;
            for (int i = 0; i < 4; i++)
            {
                PredictedSales += SalesArr[i];
            }
            return Math.Ceiling(PredictedSales);
        }
        private double CostPrediction(double [] TotalCostArr)
        {
            //Scale weekly/monthly data depending on its importance to the prediction
            double totalcost = 0;
            TotalCostArr[0] *= 0.2;
            TotalCostArr[1] *= 0.1;
            TotalCostArr[2] *= 0.5;
            TotalCostArr[3] *= 0.2;
            for (int i = 0; i < 4; i++)
            {
                totalcost += TotalCostArr[i];
            }
            return totalcost;
        }
    }
}

