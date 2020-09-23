using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace PHP.Database.Classes
{
    public class ProductSale
    {
        [Key]
        public int ProductSaleId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public Sale Sale { get; set; }
        [ForeignKey("Sale")]
        public int SaleId { get; set; }
    }
}
