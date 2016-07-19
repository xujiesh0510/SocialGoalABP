using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class GoalUpdate
    {
        public int UpdateId { get; set; }
        public string Updatemsg { get; set; }
        public int GoalId { get; set; }
        public DateTime DateOfUpdate { get; set; }
        public GoalUpdate()
        {
            DateOfUpdate = DateTime.Now;
        }
    }
}
