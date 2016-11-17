using System.Web.Mvc;

namespace Tracker.Controllers.MVC
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            ViewBag.Message = "Resume Selection";

            return View();
        }
        public ActionResult Skills()
        {
            ViewBag.Message = "Skills Selection";

            return View();
        }

    }
}