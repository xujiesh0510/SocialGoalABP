using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class SupportInvitationConfiguration : EntityTypeConfiguration<SupportInvitation>
    {
        public SupportInvitationConfiguration()
        {
            Property(s => s.GoalId).IsRequired();
            Property(s => s.SentDate).IsRequired();
            Property(s => s.Accepted).IsRequired();
            Property(s => s.FromUserId).IsMaxLength();
            Property(s => s.ToUserId).IsMaxLength();
        }
    }
}
