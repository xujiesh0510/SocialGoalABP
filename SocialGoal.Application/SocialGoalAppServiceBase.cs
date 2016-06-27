using Abp.Application.Services;

namespace SocialGoal
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SocialGoalAppServiceBase : ApplicationService
    {
        protected SocialGoalAppServiceBase()
        {
            LocalizationSourceName = SocialGoalConsts.LocalizationSourceName;
        }
    }
}