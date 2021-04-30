using System.Web.Mvc;

namespace TP_Pizza.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}