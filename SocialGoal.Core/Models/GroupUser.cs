using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class GroupUser
    {
        public GroupUser()
        {
            AddedDate = DateTime.Now;
        }
        public int GroupUserId { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }
        public bool Admin { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
