﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Family.Models;

namespace Family.Controllers {
    public class IncomeCategoriesController : Controller {
        private SystemDBContextFamily db = new SystemDBContextFamily();

        // GET: IncomeCategories
        public ActionResult Index() {
            return View(db.IncomeCategories.ToList());
        }

        // GET: IncomeCategories/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeCategory incomeCategory = db.IncomeCategories.Find(id);
            if (incomeCategory == null) {
                return HttpNotFound();
            }
            return View(incomeCategory);
        }

        // GET: IncomeCategories/Create
        public ActionResult Create() {
            return View();
        }

        // POST: IncomeCategories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Informations")] IncomeCategory incomeCategory) {
            if (ModelState.IsValid) {
                db.IncomeCategories.Add(incomeCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incomeCategory);
        }

        // GET: IncomeCategories/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeCategory incomeCategory = db.IncomeCategories.Find(id);
            if (incomeCategory == null) {
                return HttpNotFound();
            }
            return View(incomeCategory);
        }

        // POST: IncomeCategories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Informations")] IncomeCategory incomeCategory) {
            if (ModelState.IsValid) {
                db.Entry(incomeCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incomeCategory);
        }

        // GET: IncomeCategories/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeCategory incomeCategory = db.IncomeCategories.Find(id);
            if (incomeCategory == null) {
                return HttpNotFound();
            }
            return View(incomeCategory);
        }

        // POST: IncomeCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            IncomeCategory incomeCategory = db.IncomeCategories.Find(id);
            db.IncomeCategories.Remove(incomeCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
