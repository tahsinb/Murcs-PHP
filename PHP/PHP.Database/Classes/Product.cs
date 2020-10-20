using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PHP.Database.Classes
{
    public class Product
    {
 
        public int ProductId { get; set; }
        public string Product_Name { get; set; }
        public double Price { get; set; }
        public int Stock_Level { get; set; }
        public string Type { get; set; }
        public int Low_Stock_Number { get; set; }

    }
}
