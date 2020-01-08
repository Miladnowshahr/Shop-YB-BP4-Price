using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    [Table("LikeDislike")]
    public class LikeDislike
    {
        public int Id { get; set; }

        public string UserIp { get; set; }

        public bool Status { get; set; }

        public int CommentId { get; set; }

        public virtual Comment Comment { get; set; }
    }
}
