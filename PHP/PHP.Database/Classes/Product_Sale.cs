using System;
using System.Collections.Generic;
using System.Text;

namespace PHP.Database.Classes
{
    public class Product_Sale
    {
        public Product Product { get; set; }
        public Sale Sale { get; set; }
        int Quantity { get; set; }
    }
}
