using System.Web.Mvc;

namespace santwel.poc.Web.Controllers
{
    public class HomeController : pocControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}