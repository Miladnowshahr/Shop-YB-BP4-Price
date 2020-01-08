using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ShopYB.Models
{
    [Table("Account")]
    public partial class Account
    {
        public Account()
        {
            RoleAccounts = new HashSet<RoleAccount>();
            Invoices = new HashSet<Invoice>();
            Addresses = new HashSet<Address>();
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<RoleAccount> RoleAccounts { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Invoice> Invoices { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }


    }
}
