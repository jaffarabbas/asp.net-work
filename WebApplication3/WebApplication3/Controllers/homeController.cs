using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            ViewData["obj"] = "Hello world";

            Class1 obj = new Class1();
            obj.id = 23;
            obj.name = "jaffar";
            obj.man = "hgkhfhjkfkhfk";

            ViewData["obb"] = obj;
            return View();
        }

        
    }
}