using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("Ship")]
    public class Ship
    {

        [Key]
        public int AddressId { get; set; }
        [Key]
        public int InvoiceId { get; set; }

        public int Price { get; set; }

        public int ShipMethod { get; set; }

        public virtual Address Address { get; set; }
        public virtual Invoice Invoice { get; set; }

    }
}
