using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
   public class GroupUpdateSupportConfiguration : EntityTypeConfiguration<GroupUpdateSupport>
    {
       public GroupUpdateSupportConfiguration()
       {
           Property(g => g.GroupUpdateId).IsRequired();
           Property(g => g.GroupUserId).IsRequired();
           Property(g => g.UpdateSupportedDate).IsRequired();
        }
    }
}
