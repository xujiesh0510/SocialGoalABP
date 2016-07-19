using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace SocialGoal.Models
{
    public class GoalStatus : Entity
    {
        public int GoalStatusId { get; set; }
        public string GoalStatusType { get; set; }
    }
}