using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("PDiscount")]
    public class PDiscount
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public double DiscountValue { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ExpirayDate { get; set; }

        public DateTime ValidFrom { get; set; }

        public virtual Product Product { get; set; } 
    } 
}
