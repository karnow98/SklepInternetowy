using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Tags { get; set; }
        public bool Promotion { get; set; }
        public int PromotionAmount { get; set; }
    }
}