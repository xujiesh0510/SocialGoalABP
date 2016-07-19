using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
    public class Goal
    {
        public int GoalId { get; set; }

        public string GoalName { set; get; }

        public string Desc { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double? Target { get; set; }

        public bool GoalType { get; set; }

        public int? MetricId { get; set; }
        public int GoalStatusId { get; set; }
        public string UserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Metric Metric { get; set; }

        public virtual GoalStatus GoalStatus { get; set; }
        public virtual ICollection<Support> Supports { get; set; }

        public Goal()
        {
            CreatedDate = DateTime.Now;
            GoalStatusId = 1;
        }
    }
}