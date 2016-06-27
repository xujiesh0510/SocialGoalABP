using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int UpdateId { get; set; }
        public DateTime CommentDate { get; set; }
        public virtual Update Update { get; set; }
        public Comment()
        {
            CommentDate = DateTime.Now;
        }
    }
}
