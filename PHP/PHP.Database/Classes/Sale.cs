using System;
using System.Collections.Generic;
using System.Text;

namespace PHP.Database.Classes
{
    public class Sale
    {
        public int Sales_id { get; set; }
        public DateTime Sale_Date { get; set; }
        public double Total_Cost { get; set; }
        public string Customer_Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public Employee Employee {get;set;}

    }
}
