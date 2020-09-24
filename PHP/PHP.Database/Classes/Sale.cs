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
            Products = new List<ProductSale>();
        }
        public int SaleId { get; set; }
        public DateTime Sale_Date { get; set; }
        public double Total_Cost { get; set; }
        public string Customer_Name { get; set; }
        public ICollection<ProductSale> Products { get; set; }
        public Employee Employee {get;set;}
        public int EmployeeId { get; set; }
        public int ProductSaleId { get; set; }

    }
}
