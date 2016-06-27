using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Abp.EntityFramework;
using Castle.MicroKernel.Registration;
using SocialGoal.Models;

namespace SocialGoal.EntityFramework
{
    public class SocialGoalDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SocialGoalDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SocialGoalDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SocialGoalDbContext since ABP automatically handles it.
         */
        public SocialGoalDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }


        //在这边将FluentAPI 注入到 上下文
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Entity<Metric>().HasKey(s => s.MetricId);
            modelBuilder.Entity<Metric>().Ignore(s => s.Note);
            #region index
            modelBuilder.Entity<Metric>().Property(s => s.MetricId).HasColumnAnnotation("Index", new IndexAttribute());
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
