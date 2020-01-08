using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("Invoice")]
    public class Invoice
    {
        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
            
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public int Status { get; set; }

        public int AccountId { get; set; }

        public virtual Account Account { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }

        public virtual Ship Ships { get; set; }

        public virtual Payment Payments { get; set; }

    }
}
