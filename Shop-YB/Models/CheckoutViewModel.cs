using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    public class CheckoutViewModel
    {
        public int TotalPrice { get; set; }

        public int Id { get; set; }

        public int Pay { get; set; }

        public int ShipMethod { get; set; }

    }
}
