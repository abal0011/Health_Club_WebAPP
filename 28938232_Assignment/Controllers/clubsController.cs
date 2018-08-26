using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _28938232_Assignment.Models;

namespace _28938232_Assignment.Controllers
{
    public class clubsController : Controller
    {
        private Club_Model db = new Club_Model();

        // GET: clubs
        public ActionResult Index()
        {
            return View(db.clubs.ToList());
        }

        // GET: clubs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            club club = db.clubs.Find(id);
            if (club == null)
            {
                return HttpNotFound();
            }
            return View(club);
        }

        // GET: clubs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: clubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,location,Description,Contact")] club club)
        {
            if (ModelState.IsValid)
            {
                db.clubs.Add(club);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(club);
        }

        // GET: clubs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            club club = db.clubs.Find(id);
            if (club == null)
            {
                return HttpNotFound();
            }
            return View(club);
        }

        // POST: clubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,location,Description,Contact")] club club)
        {
            if (ModelState.IsValid)
            {
                db.Entry(club).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(club);
        }

        // GET: clubs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            club club = db.clubs.Find(id);
            if (club == null)
            {
                return HttpNotFound();
            }
            return View(club);
        }

        // POST: clubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            club club = db.clubs.Find(id);
            db.clubs.Remove(club);
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
