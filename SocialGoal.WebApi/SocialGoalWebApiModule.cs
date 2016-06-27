using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace SocialGoal
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SocialGoalApplicationModule))]
    public class SocialGoalWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SocialGoalApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
