using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Areas.Admin.Models.ViewModels
{
    public class DiscountViewModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public float DiscountValue { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ExpirayDate { get; set; }

        public string ProductName { get; set; }
        public DateTime ValidFrom { get; set; }

        public int Price { get; set; }
    }
}
