using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
   public class FollowRequestConfiguration:EntityTypeConfiguration<FollowRequest>
   {
       public FollowRequestConfiguration()
       {
           Property(f => f.FromUserId).IsRequired();
           Property(f => f.ToUserId).IsRequired();
           Property(f => f.Accepted).IsRequired();
       }
    }
}
