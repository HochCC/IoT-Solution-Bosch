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
    public class PalletsController : Controller
    {
        private CLOUD db = new CLOUD();

        // GET: Pallets
        public ActionResult Index()
        {
            return View(db.Pallets.ToList());
        }

        // GET: Pallets/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pallet pallet = db.Pallets.Find(id);
            if (pallet == null)
            {
                return HttpNotFound();
            }
            return View(pallet);
        }

        // GET: Pallets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pallets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Pallet_id,Status,Car_id,Time")] Pallet pallet)
        {
            if (ModelState.IsValid)
            {
                db.Pallets.Add(pallet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pallet);
        }

        // GET: Pallets/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pallet pallet = db.Pallets.Find(id);
            if (pallet == null)
            {
                return HttpNotFound();
            }
            return View(pallet);
        }

        // POST: Pallets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Pallet_id,Status,Car_id,Time")] Pallet pallet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pallet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pallet);
        }

        // GET: Pallets/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pallet pallet = db.Pallets.Find(id);
            if (pallet == null)
            {
                return HttpNotFound();
            }
            return View(pallet);
        }

        // POST: Pallets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pallet pallet = db.Pallets.Find(id);
            db.Pallets.Remove(pallet);
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
