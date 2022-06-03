using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sloth.Entities;
using Sloth.Entities.Concrete;

namespace Sloth.WebApp.Areas.Admin.Controllers
{
    public class CorparatesController : Controller
    {
        private SlothContext db = new SlothContext();

        // GET: Admin/Corparates
        public ActionResult Index()
        {
            return View(db.Corparates.ToList());
        }

        // GET: Admin/Corparates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Corparate corparate = db.Corparates.Find(id);
            if (corparate == null)
            {
                return HttpNotFound();
            }
            return View(corparate);
        }

        // GET: Admin/Corparates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Corparates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,Text")] Corparate corparate)
        {
            if (ModelState.IsValid)
            {
                db.Corparates.Add(corparate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(corparate);
        }

        // GET: Admin/Corparates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Corparate corparate = db.Corparates.Find(id);
            if (corparate == null)
            {
                return HttpNotFound();
            }
            return View(corparate);
        }

        // POST: Admin/Corparates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,Text")] Corparate corparate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(corparate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(corparate);
        }

        // GET: Admin/Corparates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Corparate corparate = db.Corparates.Find(id);
            if (corparate == null)
            {
                return HttpNotFound();
            }
            return View(corparate);
        }

        // POST: Admin/Corparates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Corparate corparate = db.Corparates.Find(id);
            db.Corparates.Remove(corparate);
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
