﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
   public class GroupCommentUserConfiguration:EntityTypeConfiguration<GroupCommentUser>
   {
       public GroupCommentUserConfiguration()
       {
           Property(s => s.GroupCommentId).IsRequired();
           Property(s => s.UserId).IsRequired();
       }
   }
}
