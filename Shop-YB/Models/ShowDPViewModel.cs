using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    public class ShowDPViewModel
    {
        public Product product { get; set; }
        public int Price { get; set; }
        public double DiscountValue { get; set; }

        public int NewPrice { get; set; }
        public DateTime ExprireDate { get; set; }
    }
}
