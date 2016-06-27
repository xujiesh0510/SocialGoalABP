using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using SocialGoal.EntityFramework;

namespace SocialGoal
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(SocialGoalCoreModule))]
    public class SocialGoalDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<SocialGoalDbContext>(null);
        }
    }
}
