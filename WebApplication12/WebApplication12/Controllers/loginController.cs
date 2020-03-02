using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class loginController : Controller
    {
        firstEntities obj = new firstEntities();
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(fuck a)
        {
            if(ModelState.IsValid == true)
            {
                obj.fucks.Add(a);
                int m = obj.SaveChanges();
                if(m > 0)
                {
                    TempData["res"] = "Succesfully Sign in";
                    ModelState.Clear();
                }
                else
                {
                    TempData["res"] = "Error in Sign in";
                }
            }
            return View();
        }
    }
}