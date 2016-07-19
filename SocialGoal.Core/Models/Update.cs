using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class Update
    {
        public int UpdateId { get; set; }
        public string Updatemsg { get; set; }
        public double? status { get; set; }
        public int GoalId { get; set; }

        public DateTime UpdateDate { get; set; }

        public virtual Goal Goal { get; set; }

       public Update()
        {
            UpdateDate = DateTime.Now;
        }
    }
}
