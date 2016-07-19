using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class GroupUpdateUserConfiguration : EntityTypeConfiguration<GroupUpdateUser>
    {
        public GroupUpdateUserConfiguration()
        {
            Property(g => g.GroupUpdateUserId).IsRequired();
            Property(g => g.UserId).IsRequired();
        }
    }
}
