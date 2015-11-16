using System.Web.Mvc;

namespace portal3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Negocio()
        {
            ViewBag.Message = "Your config page.";

            return View();
        }
        public ActionResult Acerca()
        {
            ViewBag.Message = "Your config page.";

            return View();
        }
        public ActionResult Contacto()
        {
            ViewBag.Message = "Your config page.";

            return View();
        }
    }
}