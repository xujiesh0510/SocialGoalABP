using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class GroupUpdate
    {
        public int GroupUpdateId { get; set; }

        public string Updatemsg { get; set; }

        public double? status { get; set; }

        public int GroupGoalId { get; set; }

        public DateTime UpdateDate { get; set; }
        public virtual GroupGoal GroupGoal { get; set; }

       public GroupUpdate()
       {
           UpdateDate = DateTime.Now;
       }
    }
}
