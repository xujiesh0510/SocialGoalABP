using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;
namespace SocialGoal.Configuration
{
    public class GroupConfiguration : EntityTypeConfiguration<Group>
    {
        public GroupConfiguration()
        {
            Property(s => s.GroupName).HasMaxLength(50);
            Property(g => g.CreatedDate).IsRequired();
            Property(g => g.Description).IsMaxLength();
        }
    }
}