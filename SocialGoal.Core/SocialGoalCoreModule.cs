using System.Reflection;
using Abp.Modules;

namespace SocialGoal
{
    public class SocialGoalCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
