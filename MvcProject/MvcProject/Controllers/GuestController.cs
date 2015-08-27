using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class GuestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateFeedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFeedback(FormCollection form)
        {
            return View();
        }
    }
}