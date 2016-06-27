using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialGoal.Models;

namespace SocialGoal.Configuration
{
    public class MetricConfiguration : EntityTypeConfiguration<Metric>
    {
        public MetricConfiguration()
        {
            Property(s => s.MetricId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //Property(s => s.MetricId).IsRequired();
           // Property(s => s.Note).HasColumnName("MyNote");
            Property(s => s.Type).HasColumnType("varchar").HasMaxLength(200);
            
        }
    }
}