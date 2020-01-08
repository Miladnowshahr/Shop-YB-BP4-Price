using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("Payment")]
    public class Payment
    {
        public int Id { get; set; }
        public int PayMethodId { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }

        public int AccountId { get; set; }
        public int InvoiceId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Invoice Invoice { get; set; }

        public virtual PayMethod PayMethods { get; set; }


    }
}
