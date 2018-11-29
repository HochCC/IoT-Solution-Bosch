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
    public class TurnoverBoxesController : Controller
    {
        private CLOUD db = new CLOUD();
        private CLOUD db2 = new CLOUD();
        // GET: TurnoverBoxes
        public ActionResult Index()
        {
            return View(db.TurnoverBox0.ToList());
        } 

        // GET: TurnoverBoxes
        public ActionResult iotindex()
        {
            /*
            var sqlview = from m in db2.sqlview1
                          orderby m.Car_id
                          select m;
            return View(sqlview);
            */
            var sqlview = from m in db2.sqlview1
                          orderby m.Car_id
                          select m;
            return View(sqlview);
        }

        public ActionResult Distribution()
        {
            return View(db.TurnoverBox0.ToList());
        }


        public ActionResult pqr(string id)
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
        public ActionResult pqr([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
            }

            return View(turnoverBox0);
        }

        [HttpPost]
        public ActionResult pqr2([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
            }

            return View(turnoverBox0);
        }

        [HttpPost]
        public ActionResult pqr3([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
            }

            return View(turnoverBox0);
        }

        [HttpPost]
        public ActionResult pqr4([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
            }

            return View(turnoverBox0);
        }

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

        public ActionResult onepoint( )
        { 
            return View( ); 
        }  

        public ActionResult monitor()
        {
            return View();
        }

        public ActionResult WHplanning()
        {
            return View();
        }

        public ActionResult fee()
        {
            return View();
        }

        public ActionResult fee2()
        {
            return View();
        }

        public ActionResult fee3()
        {
            return View();
        }

        public ActionResult sftry()
        {
            return View();
        }

        public ActionResult credit()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult TSP()
        {
            return View();
        }

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

        public ActionResult InuseEdit(string id)
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
        public ActionResult InuseEdit([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turnoverBox0);
        }

        public ActionResult FreeEdit(string id)
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
        public ActionResult FreeEdit([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turnoverBox0);
        }

        public ActionResult BrokenEdit(string id)
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
        public ActionResult BrokenEdit([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turnoverBox0);
        }

        public ActionResult OvercyclelifeEdit(string id)
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
        public ActionResult OvercyclelifeEdit([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turnoverBox0);
        }

        public ActionResult RepairingEdit(string id)
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
        public ActionResult RepairingEdit([Bind(Include = "Turnoverbox_id,Status,Time,Enduser,Pallet_id")] TurnoverBox0 turnoverBox0)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turnoverBox0).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turnoverBox0);
        }

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
