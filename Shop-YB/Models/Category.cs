using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ShopYB.Models
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            InverseParents = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public int? ParentId { get; set; }

        public virtual Category Parent { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Category> InverseParents { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<Product> Products { get; set; }

        public virtual ICollection<ProductCategoryDiscount> ProductCategoryDiscounts { get; set; }
    }
}
