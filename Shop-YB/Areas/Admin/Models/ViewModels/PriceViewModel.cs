using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Areas.Admin.Models.ViewModels
{
    public class PriceViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int NewPrice { get; set; }
        public int BasePrice { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpirayDate { get; set; }
        public bool IsActive { get; set; }
    }
}
