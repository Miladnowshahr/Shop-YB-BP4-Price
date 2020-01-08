using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("Config")]
    public class Config
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string TermPolicy { get; set; }
        public string Email { get; set; }

        public string Describe { get; set; }
        public string Logo { get; set; }

        public string RecordNumber { get; set; }
    }
}
