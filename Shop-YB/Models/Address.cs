using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{

    [Table("Address")]
    public class Address
    {
        public Address()
        {
            Ships = new HashSet<Ship>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]

        public string Address1 { get; set; }
        [Required]

        public string City { get; set; }
        [Required]

        public string State { get; set; }
        [Required]

        public string Phone { get; set; }
        [Required]

        public string Zipcode { get; set; }

        public int AccountId { get; set; }

       


        public virtual Account Account { get; set; }

        public virtual ICollection<Ship> Ships { get; set; }
}
}
