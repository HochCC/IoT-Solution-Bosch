using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Connecting.Models;

namespace Connecting.Controllers
{
    public class CompsController : Controller
    {
        private CLOUD db = new CLOUD();

        // GET: Comps
        public ActionResult Index()
        {
            return View(db.Comps.ToList());
        }

        // GET: Comps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comp comp = db.Comps.Find(id);
            if (comp == null)
            {
                return HttpNotFound();
            }
            return View(comp);
        }

        // GET: Comps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Time,Turnoverboxes,Company")] Comp comp)
        {
            if (ModelState.IsValid)
            {
                db.Comps.Add(comp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comp);
        }

        // GET: Comps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comp comp = db.Comps.Find(id);
            if (comp == null)
            {
                return HttpNotFound();
            }
            return View(comp);
        }

        // POST: Comps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Time,Turnoverboxes,Company")] Comp comp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comp);
        }

        // GET: Comps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comp comp = db.Comps.Find(id);
            if (comp == null)
            {
                return HttpNotFound();
            }
            return View(comp);
        }

        // POST: Comps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comp comp = db.Comps.Find(id);
            db.Comps.Remove(comp);
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
