using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ps_13.Data;
using Ps_13.Models;

namespace Ps_13.Controllers
{
    public class Cricket_TeamsController : Controller
    {
        private Ps_13Context db = new Ps_13Context();

        // GET: Cricket_Teams
        public ActionResult Index()
        {
            return View(db.Cricket_Teams.ToList());
        }

        // GET: Cricket_Teams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricket_Teams cricket_Teams = db.Cricket_Teams.Find(id);
            if (cricket_Teams == null)
            {
                return HttpNotFound();
            }
            return View(cricket_Teams);
        }

        // GET: Cricket_Teams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cricket_Teams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeamId,TeamName,NOWC")] Cricket_Teams cricket_Teams)
        {
            if (ModelState.IsValid)
            {
                db.Cricket_Teams.Add(cricket_Teams);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cricket_Teams);
        }

        // GET: Cricket_Teams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricket_Teams cricket_Teams = db.Cricket_Teams.Find(id);
            if (cricket_Teams == null)
            {
                return HttpNotFound();
            }
            return View(cricket_Teams);
        }

        // POST: Cricket_Teams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TeamId,TeamName,NOWC")] Cricket_Teams cricket_Teams)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cricket_Teams).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cricket_Teams);
        }

        // GET: Cricket_Teams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricket_Teams cricket_Teams = db.Cricket_Teams.Find(id);
            if (cricket_Teams == null)
            {
                return HttpNotFound();
            }
            return View(cricket_Teams);
        }

        // POST: Cricket_Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cricket_Teams cricket_Teams = db.Cricket_Teams.Find(id);
            db.Cricket_Teams.Remove(cricket_Teams);
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
