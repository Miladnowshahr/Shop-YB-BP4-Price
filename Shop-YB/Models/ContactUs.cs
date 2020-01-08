using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("Contactus")]
    public class ContactUs
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public string Subject { get; set; }
        public string Description { get; set; }

        public bool IsRead { get; set; }
    }
}
