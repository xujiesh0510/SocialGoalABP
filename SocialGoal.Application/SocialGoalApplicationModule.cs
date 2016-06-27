using System.Reflection;
using Abp.Modules;

namespace SocialGoal
{
    [DependsOn(typeof(SocialGoalCoreModule))]
    public class SocialGoalApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
