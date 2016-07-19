using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class GroupInvitationConfiguration : EntityTypeConfiguration<GroupInvitation>
    {
        public GroupInvitationConfiguration()
        {
            Property(g => g.FromUserId).IsMaxLength();
            Property(g => g.ToUserId).IsMaxLength();
            Property(g => g.GroupId).IsRequired();
            Property(g => g.SentDate).IsRequired();
            Property(g => g.Accepted).IsRequired();
        }
    }
}