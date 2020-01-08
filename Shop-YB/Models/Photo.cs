using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ShopYB.Models
{
    [Table("Photo")]
    public partial class Photo
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int ProductId { get; set; }
        public bool Featured { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Product Product { get; set; }
        
    }
}
