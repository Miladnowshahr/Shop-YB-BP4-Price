using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("Product_Price")]
    public class ProductPrice
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BasePrice { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpirayDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Product Product { get; set; }
    }
}
