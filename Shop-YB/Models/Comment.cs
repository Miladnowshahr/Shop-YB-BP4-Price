using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public int ProductId { get; set; }

        public string Email { get; set; }

        public string Content { get; set; }

       
        public bool Status { get; set; }
        public bool IsRead { get; set; }


        public DateTime Date_Time { get; set; }
        public virtual Product Product { get; set; }

        public virtual ICollection<LikeDislike> LikeDislikes { get; set; }

    }
}
