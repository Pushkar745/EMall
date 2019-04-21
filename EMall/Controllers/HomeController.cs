using System.Web.Mvc;

namespace Emall.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult Contact()
        {
        
            return View();
        }
  
        public ActionResult Kitchen()
        {
            return View();
        }
        public ActionResult Care()
        {
            return View();
        }
        public ActionResult Shipping()
        {
            return View();

        }
        public ActionResult Wishlist()
        {
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
    }
}