using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PHP.Database.Classes
{
    public class Sale
    {
        public Sale()
        {
        }
        public int SaleId { get; set; }
        public DateTime Sale_Date { get; set; }
        public double Total_Cost { get; set; }
        public string Customer_Name { get; set; }
        public ICollection<ProductSale> ProductSales { get; set; } = new List<ProductSale>();
        public Employee Employee {get;set;}
        public int EmployeeId { get; set; }

    }
}
