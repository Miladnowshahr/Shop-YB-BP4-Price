using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models.ViewModels
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }

        public IEnumerable<Product> RelatedProduct { get; set; }

        public ProductPrice ProductPrice { get; set; }

        public bool IsDiscount { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
