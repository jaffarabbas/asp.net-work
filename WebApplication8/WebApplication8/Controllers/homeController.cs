using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class homeController : Controller
    {
        connect obj = new connect();
        // GET: home
        public ActionResult Index()
        {
            var man = obj.mady.ToList();
            return View(man);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(table a)
        {
            obj.mady.Add(a);
            int n = obj.SaveChanges();
            if(n > 0)
            {
                TempData["res"] = "Data entered succ";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["res"] = "Data not entered succ";
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var man = obj.mady.Where(a => a.id == id).FirstOrDefault();
            return View(man);
        }
        [HttpPost]
        public ActionResult Edit(table a)
        {
            obj.Entry(a).State = EntityState.Modified;
            int n = obj.SaveChanges();
            if (n > 0)
            {
                TempData["res"] = "Data edit succ";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["res"] = "Data not edit succ";
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var delid = obj.mady.Where(model => model.id == id).FirstOrDefault();
            if(delid != null)
            {
                obj.Entry(delid).State = EntityState.Deleted;
                int c = obj.SaveChanges();
                if(c > 0)
                {
                    TempData["rest"] = "Data edit succ";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["rest"] = "Data edit succ";
                }
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var check = obj.mady.Where(a => a.id == id).FirstOrDefault();
            return View(check);
        }
    }
}