using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class CommentConfiguration : EntityTypeConfiguration<Comment>
    {
        public CommentConfiguration()
        {
            Property(s => s.CommentText).HasMaxLength(250);
        }
    }
}