using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
   public class FollowUserConfiguration:EntityTypeConfiguration<FollowUser>
   {
       public FollowUserConfiguration()
       {
           Property(s => s.Accepted).IsRequired();
           Property(s => s.AddDate).IsRequired();
       }
   }
}
