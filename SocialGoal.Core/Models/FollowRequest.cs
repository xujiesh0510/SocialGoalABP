using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class FollowRequest
    {
        public int FollowRequestId { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public bool Accepted { get; set; }
    }
}
