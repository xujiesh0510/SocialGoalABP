﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
   public class GroupUserConfiguration:EntityTypeConfiguration<GroupUser>
    {
        public GroupUserConfiguration()
        {
            Property(g => g.GroupId).IsRequired();
            Property(g => g.UserId).IsRequired().IsMaxLength();
            Property(g => g.Admin).IsRequired();
            Property(g => g.AddedDate).IsRequired();
        }
    }
}
