using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("PayMethod")]
    public class PayMethod
    {
        public int Id { get; set; }
        public string Method { get; set; }

        public string Description { get; set; }


        public virtual ICollection<Payment> Payments { get; set; }
    }
}
