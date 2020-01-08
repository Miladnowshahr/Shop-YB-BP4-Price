using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.Models
{
    public class UserRewardPoint
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Reward_Points { get; set; }

        public string Reward_Type { get; set; }
        public string OPeration_Type { get; set; }
        public DateTime Create_Date { get; set;}
        public DateTime Expairy_Date{ get; set; }
    }
}
