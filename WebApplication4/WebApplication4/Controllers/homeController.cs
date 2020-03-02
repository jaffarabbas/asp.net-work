using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Class1 a)
        {
            if(ModelState.IsValid == true)
            {
                ViewData["mm"] = "<script>alert('Success')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}