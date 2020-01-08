using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("Product_Discount")]
    public class ProductDiscount
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public int Discount_Value { get; set; }
        public string Discount_Unit { get; set; }
        public DateTime Create_Date { get; set; }
        public DateTime Valid_From { get; set; }

        public DateTime Valid_Until { get; set; }
        public string Coupon_Code { get; set; }
        public int Min_Order_Value { get; set; }
        public int Max_Discount_Amount { get; set; }

        public bool Is_Redeem_Allowed { get; set; }

        public virtual Product Product { get; set; }
    }
}
