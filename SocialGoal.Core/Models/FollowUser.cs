using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
    public class FollowUser
    {
        public int FollowUserId { get; set; }
        public string ToUserId { get; set; }
        public string FromUsreId { get; set; }
        public bool Accepted { get; set; }
        public DateTime AddDate { get; set; }
        public virtual ApplicationUser ToUser { get; set; }
        public virtual ApplicationUser FromUser { get; set; }
    }
}
