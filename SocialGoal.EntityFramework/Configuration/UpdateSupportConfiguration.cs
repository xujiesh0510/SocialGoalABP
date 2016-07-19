using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class UpdateSupportConfiguration : EntityTypeConfiguration<UpdateSupport>
    {
        public UpdateSupportConfiguration()
        {
            Property(u => u.UpdateId).IsRequired();
            Property(u => u.UserId).IsMaxLength();
            Property(u => u.UpdateSupportedDate).IsRequired();
        }
    }
}
