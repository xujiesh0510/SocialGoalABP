using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
   public class ApplicationUserConfiguration:EntityTypeConfiguration<ApplicationUser>
   {
       public ApplicationUserConfiguration()
       {
           Property(c => c.Email).IsRequired();
           Property(c => c.FirstName).IsRequired();
           Property(c => c.LastName).IsRequired();
           Property(c => c.Email).HasMaxLength(250);
       }
   }
}
