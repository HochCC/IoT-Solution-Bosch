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
    public class TurnoverBox0Controller : Controller
    {
        private CLOUD db = new CLOUD();

        // GET: TurnoverBox0
        public ActionResult Index()
        {
            return View(db.TurnoverBox0.ToList());
        }

        // GET: TurnoverBox0/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TurnoverBox0 turnoverBox0 = db.TurnoverBox0.Find(id);
            if (turnoverBox0 == null)
            {
                return HttpNotFound();
            }
            return View(turnoverBox0);
        }

        // GET: TurnoverBox0/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult onepoint(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TurnoverBox0 turnoverBox0 = db.TurnoverBox0.Find(id);
            if (turnoverBox0 == null)
            {
                return HttpNotFound();
            }
            return View(turnoverBox0);
        }

        // POST: TurnoverBox0/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.TurnoverBox0.Add(turnoverBox0);
                db.SaveChanges();
                return RedirectToAction("Index");
            } 
            return View(turnoverBox0);
        }

        // GET: TurnoverBox0/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TurnoverBox0 turnoverBox0 = db.TurnoverBox0.Find(id);
            if (turnoverBox0 == null)
            {
                return HttpNotFound();
            }
            return View(turnoverBox0);
        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turnoverBox0);
        }

        public ActionResult qredit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TurnoverBox0 turnoverBox0 = db.TurnoverBox0.Find(id);
            if (turnoverBox0 == null)
            {
                return HttpNotFound();
            }
            return View(turnoverBox0);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult qredit([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turnoverBox0);
        }

        // GET: TurnoverBox0/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TurnoverBox0 turnoverBox0 = db.TurnoverBox0.Find(id);
            if (turnoverBox0 == null)
            {
                return HttpNotFound();
            }
            return View(turnoverBox0);
        }

        // POST: TurnoverBox0/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TurnoverBox0 turnoverBox0 = db.TurnoverBox0.Find(id);
            db.TurnoverBox0.Remove(turnoverBox0);
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
