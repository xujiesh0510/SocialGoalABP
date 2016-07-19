﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class GroupGoalConfiguration : EntityTypeConfiguration<GroupGoal>
    {
        public GroupGoalConfiguration()
        {
            Property(g => g.GroupId).IsRequired();
            Property(g => g.GoalName).HasMaxLength(50);
            Property(g => g.Description).HasMaxLength(100);
            Property(g => g.StartDate).IsRequired();
            Property(g => g.EndDate).IsRequired();
            Property(g => g.GoalStatusId).IsRequired();
            Property(g => g.GroupUserId).IsRequired();
        }
    }
}
