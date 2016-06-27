using System.Web.Mvc;

namespace SocialGoal.Web.Controllers
{
    public class HomeController : SocialGoalControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}