using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5;

namespace WebApplication5.Controllers
{
    public class pokkkksController : Controller
    {
        private moydEntities db = new moydEntities();

        // GET: pokkkks
        public ActionResult Index()
        {
            return View(db.pokkkks.ToList());
        }

        // GET: pokkkks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pokkkk pokkkk = db.pokkkks.Find(id);
            if (pokkkk == null)
            {
                return HttpNotFound();
            }
            return View(pokkkk);
        }

        // GET: pokkkks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pokkkks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,age")] pokkkk pokkkk)
        {
            if (ModelState.IsValid)
            {
                db.pokkkks.Add(pokkkk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pokkkk);
        }

        // GET: pokkkks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pokkkk pokkkk = db.pokkkks.Find(id);
            if (pokkkk == null)
            {
                return HttpNotFound();
            }
            return View(pokkkk);
        }

        // POST: pokkkks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,age")] pokkkk pokkkk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pokkkk).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pokkkk);
        }

        // GET: pokkkks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pokkkk pokkkk = db.pokkkks.Find(id);
            if (pokkkk == null)
            {
                return HttpNotFound();
            }
            return View(pokkkk);
        }

        // POST: pokkkks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pokkkk pokkkk = db.pokkkks.Find(id);
            db.pokkkks.Remove(pokkkk);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
