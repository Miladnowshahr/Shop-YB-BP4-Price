using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    public class Item
    {
        public Product Product { get; set; }

        public int Price { get; set; }
        public double Discount { get; set; }

        public int BasePrice{get;set;}
        public string PhotoName { get; set; }
        public int Quantity { get; set; }
    }
}
