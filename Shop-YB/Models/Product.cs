using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace ShopYB.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            Photos = new HashSet<Photo>();
            InvoiceDetails = new HashSet<InvoiceDetails>();
            Comments = new HashSet<Comment>();
            ProductPrices = new HashSet<ProductPrice>();
            ProductDiscounts = new HashSet<ProductDiscount>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        //[AllowHtml]
        public string Details { get; set; }

        public bool Featured { get; set; }

        public int Price { get; set; }
        public int View { get; set; }

        public int CategoryId { get; set; }


        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Category Category { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Photo> Photos { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Comment> Comments { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<PDiscount> PDiscounts { get; set; }
    }
}
