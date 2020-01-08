using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("InvoiceDetails")]
    public class InvoiceDetails
    {
        public int InvoiceId { get; set; }

        public int ProductId { get; set; }

        public int Price { get; set;  }

        public int Quantity { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Invoice Invoice { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Product Product { get; set; }
    }
}
