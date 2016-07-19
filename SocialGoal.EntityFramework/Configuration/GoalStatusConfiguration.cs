using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class GoalStatusConfiguration : EntityTypeConfiguration<GoalStatus>
    {
        public GoalStatusConfiguration()
        {
            Property(s => s.GoalStatusType).HasMaxLength(50);
        }
    }
}