using Abp.Web.Mvc.Controllers;

namespace SocialGoal.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class SocialGoalControllerBase : AbpController
    {
        protected SocialGoalControllerBase()
        {
            LocalizationSourceName = SocialGoalConsts.LocalizationSourceName;
        }
    }
}