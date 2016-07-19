using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class GroupRequest
    {
        public int GroupRequestId { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }
        public bool Accepted { get; set; }
    }
}
