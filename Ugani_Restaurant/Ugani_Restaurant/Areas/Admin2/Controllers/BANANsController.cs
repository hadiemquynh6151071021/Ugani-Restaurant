using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ugani_Restaurant.Models;

namespace Ugani_Restaurant.Areas.Admin2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BANANsController : Controller
    {
        private UGANI_1Entities db = new UGANI_1Entities();

        // GET: Admin2/BANANs
        public ActionResult Index()
        {
            var bANANs = db.BANANs.Include(b => b.LOAIKHONGGIAN);
            return View(bANANs.ToList());
        }

        // GET: Admin2/BANANs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BANAN bANAN = db.BANANs.Find(id);
            if (bANAN == null)
            {
                return HttpNotFound();
            }
            return View(bANAN);
        }

        // GET: Admin2/BANANs/Create
        public ActionResult Create()
        {
            ViewBag.MAKHONGGIAN = new SelectList(db.LOAIKHONGGIANs, "MALOAIKHONGGIAN", "TENLOAIKHONGGIAN");
            return View();
        }

        // POST: Admin2/BANANs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MABAN,MAKHONGGIAN")] BANAN bANAN)
        {
            if (ModelState.IsValid)
            {
                db.BANANs.Add(bANAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MAKHONGGIAN = new SelectList(db.LOAIKHONGGIANs, "MALOAIKHONGGIAN", "TENLOAIKHONGGIAN", bANAN.MAKHONGGIAN);
            return View(bANAN);
        }

        // GET: Admin2/BANANs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BANAN bANAN = db.BANANs.Find(id);
            if (bANAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.MAKHONGGIAN = new SelectList(db.LOAIKHONGGIANs, "MALOAIKHONGGIAN", "TENLOAIKHONGGIAN", bANAN.MAKHONGGIAN);
            return View(bANAN);
        }

        // POST: Admin2/BANANs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MABAN,MAKHONGGIAN")] BANAN bANAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bANAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MAKHONGGIAN = new SelectList(db.LOAIKHONGGIANs, "MALOAIKHONGGIAN", "TENLOAIKHONGGIAN", bANAN.MAKHONGGIAN);
            return View(bANAN);
        }

        // GET: Admin2/BANANs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BANAN bANAN = db.BANANs.Find(id);
            if (bANAN == null)
            {
                return HttpNotFound();
            }
            return View(bANAN);
        }

        // POST: Admin2/BANANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BANAN bANAN = db.BANANs.Find(id);
            db.BANANs.Remove(bANAN);
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
