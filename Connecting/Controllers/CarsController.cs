using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Connecting.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Connecting.Controllers
{
    public class CarsController : Controller
    {
        private CLOUD db = new CLOUD();
        //private MVCPallet db2 = new MVCPallet();
        //private MVCTurnoverbox db3 = new MVCTurnoverbox();

        // GET: Cars
        public ActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        public ActionResult jie()
        {
            return View();
        }

        /*
        public ActionResult T3()
        { 
            var kk = (from a in db3.TurnoverBoxes
                     join b in db2.Pallets on a.Pallet_id equals b.Pallet_id //join操作
                     join c in db.Cars on b.Car_id equals c.Car_id //join操作
                     where a.Pallet_id == b.Pallet_id && b.Car_id == c.Car_id  // where操作
                     select new T3
                     {       //重新组织列
                         Turnoverbox_id = a.Turnoverbox_id,
                         Pallet_id = a.Pallet_id,
                         Car_id = c.Car_id,
                         Temperature = c.Temperature,
                         Location_x = c.Location_x
                     }); 
            return View(kk.ToList());
        }*/



        // GET: Cars/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Car_id,Location_x,Location_y,Temperature,Humidity,Lfrom,Lto,Speed,Time,Status")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car);
        }

        public ActionResult onepoint(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Car_id,Location_x,Location_y,Temperature,Humidity,Lfrom,Lto,Speed,Time,Status")] Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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
