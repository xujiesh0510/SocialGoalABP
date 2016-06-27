using Abp.Web.Mvc.Views;

namespace SocialGoal.Web.Views
{
    public abstract class SocialGoalWebViewPageBase : SocialGoalWebViewPageBase<dynamic>
    {

    }

    public abstract class SocialGoalWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SocialGoalWebViewPageBase()
        {
            LocalizationSourceName = SocialGoalConsts.LocalizationSourceName;
        }
    }
}