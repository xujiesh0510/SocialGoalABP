using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class GroupCommentConfiguration : EntityTypeConfiguration<GroupComment>
    {
        public GroupCommentConfiguration()
        {
            Property(g => g.GroupUpdateId).IsRequired();
            Property(g => g.CommentText).IsMaxLength();
            Property(g => g.CommentDate).IsRequired();
        }
    }
}