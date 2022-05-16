using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Family.Models;

namespace Family.Controllers {
    public class IncomeRecordsController : Controller {
        private SystemDBContextFamily db = new SystemDBContextFamily();
        private HomeController homeController = new HomeController();
        // GET: IncomeRecords
        public ActionResult Index() {
            var incomeRecords = db.IncomeRecords.Include(i => i.IncomeCategory);
            return View(incomeRecords.ToList());
        }

        // GET: IncomeRecords/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeRecords incomeRecords = db.IncomeRecords.Find(id);
            if (incomeRecords == null) {
                return HttpNotFound();
            }
            return View(incomeRecords);
        }

        // GET: IncomeRecords/Create
        public ActionResult Create() {
            ViewBag.IncomeCategoryId = new SelectList(db.IncomeCategories, "Id", "Name");
            return View();
        }

        // POST: IncomeRecords/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IncomeCategoryId,IncomeRecordss,Value,Information")] IncomeRecords incomeRecords) {
            if (ModelState.IsValid) {
                db.IncomeRecords.Add(incomeRecords);
                db.SaveChanges();
                /*-------------------------------------------------------------------------------------------*/
                homeController.HomeBudget += incomeRecords.Value;
                return RedirectToAction("Index");
            }

            ViewBag.IncomeCategoryId = new SelectList(db.IncomeCategories, "Id", "Name", incomeRecords.IncomeCategoryId);
            return View(incomeRecords);
        }

        // GET: IncomeRecords/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeRecords incomeRecords = db.IncomeRecords.Find(id);
            if (incomeRecords == null) {
                return HttpNotFound();
            }
            ViewBag.IncomeCategoryId = new SelectList(db.IncomeCategories, "Id", "Name", incomeRecords.IncomeCategoryId);
            return View(incomeRecords);
        }

        // POST: IncomeRecords/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IncomeCategoryId,IncomeRecordss,Value,Information")] IncomeRecords incomeRecords) {
            if (ModelState.IsValid) {
                db.Entry(incomeRecords).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IncomeCategoryId = new SelectList(db.IncomeCategories, "Id", "Name", incomeRecords.IncomeCategoryId);
            return View(incomeRecords);
        }

        // GET: IncomeRecords/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomeRecords incomeRecords = db.IncomeRecords.Find(id);
            if (incomeRecords == null) {
                return HttpNotFound();
            }
            return View(incomeRecords);
        }

        // POST: IncomeRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            IncomeRecords incomeRecords = db.IncomeRecords.Find(id);
            /*-------------------------------------------------------------------------------------------*/
            homeController.HomeBudget -= incomeRecords.Value;
            db.IncomeRecords.Remove(incomeRecords);
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
