using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
  public  class GroupCommentUser
    {
        public int GroupCommentUserId { get; set; }
        public int GroupCommentId { get; set; }
        public string UserId { get; set; }
    }
}
