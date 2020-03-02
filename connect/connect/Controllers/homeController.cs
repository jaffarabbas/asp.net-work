using connect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace connect.Controllers
{
    public class homeController : Controller
    {
        main obj = new main();
        public ActionResult Index()
        {
            var obb = obj.Objk.ToList();
           
            return View(obb);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(empy a)
        {
            obj.Objk.Add(a);
            int o = obj.SaveChanges();

            if(o > 0)
            {
                TempData["rest"] = "Data Entered Succesfully";
                return RedirectToAction("index");
            }
            else
            {
                TempData["rest"] = "Error In Data";
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = obj.Objk.Where(a => a.id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]

        public ActionResult Edit(empy e)
        {
            obj.Entry(e).State = EntityState.Modified;
            int o = obj.SaveChanges();

            if (o > 0)
            {
                TempData["res"] = "Data Ubdated Succesfully";
                return RedirectToAction("index");
            }
            else
            {
                TempData["res"] = "Error In Upadte";
            }
            return View();
        }
    }
}