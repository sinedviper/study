using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Family.Models;

namespace Family.Controllers {
    public class ExpensesCategoriesController : Controller {
        private SystemDBContextFamily db = new SystemDBContextFamily();

        // GET: ExpensesCategories
        public ActionResult Index() {
            return View(db.ExpensesCategoryy.ToList());
        }

        // GET: ExpensesCategories/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpensesCategory expensesCategory = db.ExpensesCategoryy.Find(id);
            if (expensesCategory == null) {
                return HttpNotFound();
            }
            return View(expensesCategory);
        }

        // GET: ExpensesCategories/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ExpensesCategories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] ExpensesCategory expensesCategory) {
            if (ModelState.IsValid) {
                db.ExpensesCategoryy.Add(expensesCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expensesCategory);
        }

        // GET: ExpensesCategories/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpensesCategory expensesCategory = db.ExpensesCategoryy.Find(id);
            if (expensesCategory == null) {
                return HttpNotFound();
            }
            return View(expensesCategory);
        }

        // POST: ExpensesCategories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] ExpensesCategory expensesCategory) {
            if (ModelState.IsValid) {
                db.Entry(expensesCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expensesCategory);
        }

        // GET: ExpensesCategories/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExpensesCategory expensesCategory = db.ExpensesCategoryy.Find(id);
            if (expensesCategory == null) {
                return HttpNotFound();
            }
            return View(expensesCategory);
        }

        // POST: ExpensesCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            ExpensesCategory expensesCategory = db.ExpensesCategoryy.Find(id);
            db.ExpensesCategoryy.Remove(expensesCategory);
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
