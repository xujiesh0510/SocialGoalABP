using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
   public class CommentUserConfiguration:EntityTypeConfiguration<CommentUser>
   {
       public CommentUserConfiguration()
       {
           Property(s => s.CommentId).IsRequired();
           Property(s => s.UserId).IsRequired();
       }
   }
}
