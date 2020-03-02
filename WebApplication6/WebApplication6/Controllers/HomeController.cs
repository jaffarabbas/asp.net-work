using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        dallal obj = new dallal();
        // GET: Home
        public ActionResult Index()
        {
            var nn = obj.Imad.ToList();
            return View(nn);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]


        public ActionResult Create()
        {
            
            return View(nn);
        }
    }
}