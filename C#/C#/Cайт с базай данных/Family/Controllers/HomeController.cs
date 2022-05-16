using System.Web.Mvc;

namespace Family.Controllers {
    
    public class HomeController : Controller {


        /*-------------------------------------------------------------------------------------------*/
        public int HomeBudget = 0;
        public ActionResult Index() {
            
            return View();
        }

        /*
        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}