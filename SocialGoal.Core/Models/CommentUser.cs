using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace SocialGoal.Models
{
    public class CommentUser
    {
        public int CommentUserId { get; set; }
        public int CommentId { get; set; }
        public string UserId { get; set; }  
    }
}