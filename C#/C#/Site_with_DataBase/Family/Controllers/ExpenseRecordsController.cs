using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Family.Models;

namespace Family.Controllers {
    public class ExpenseRecordsController : Controller {
        private SystemDBContextFamily db = new SystemDBContextFamily();
        private HomeController homeController = new HomeController();

        // GET: ExpenseRecords
        public ActionResult Index() {
            var expenseRecords = db.ExpenseRecords.Include(e => e.ExpensesCategory);
            return View(expenseRecords.ToList());
        }

        // GET: ExpenseRecords/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseRecords expenseRecords = db.ExpenseRecords.Find(id);
            if (expenseRecords == null) {
                return HttpNotFound();
            }
            return View(expenseRecords);
        }

        // GET: ExpenseRecords/Create
        public ActionResult Create() {
            ViewBag.ExpensesCategoryId = new SelectList(db.ExpensesCategoryy, "Id", "Name");
            return View();
        }

        // POST: ExpenseRecords/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ExpensesCategoryId,ExpensesRecords,Value,Details")] ExpenseRecords expenseRecords) {
            if (ModelState.IsValid) {
                /*-------------------------------------------------------------------------------------------*/
                homeController.HomeBudget -= expenseRecords.Value;
                db.ExpenseRecords.Add(expenseRecords);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ExpensesCategoryId = new SelectList(db.ExpensesCategoryy, "Id", "Name", expenseRecords.ExpensesCategoryId);
            return View(expenseRecords);
        }

        // GET: ExpenseRecords/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseRecords expenseRecords = db.ExpenseRecords.Find(id);
            if (expenseRecords == null) {
                return HttpNotFound();
            }
            ViewBag.ExpensesCategoryId = new SelectList(db.ExpensesCategoryy, "Id", "Name", expenseRecords.ExpensesCategoryId);
            return View(expenseRecords);
        }

        // POST: ExpenseRecords/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ExpensesCategoryId,ExpensesRecords,Value,Details")] ExpenseRecords expenseRecords) {
            if (ModelState.IsValid) {
                db.Entry(expenseRecords).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ExpensesCategoryId = new SelectList(db.ExpensesCategoryy, "Id", "Name", expenseRecords.ExpensesCategoryId);
            return View(expenseRecords);
        }

        // GET: ExpenseRecords/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpenseRecords expenseRecords = db.ExpenseRecords.Find(id);
            if (expenseRecords == null) {
                return HttpNotFound();
            }
            return View(expenseRecords);
        }

        // POST: ExpenseRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            ExpenseRecords expenseRecords = db.ExpenseRecords.Find(id);
            /*-------------------------------------------------------------------------------------------*/
            homeController.HomeBudget += expenseRecords.Value;
            
            db.ExpenseRecords.Remove(expenseRecords);
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
