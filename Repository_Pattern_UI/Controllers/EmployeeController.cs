using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository_Pattern_UI.Models;
using Repository = Repository_pattern_Repository;
using ViewModel = Repository_pattern_Models;

namespace Repository_Pattern_UI.Controllers
{
    public class EmployeeController : Controller
    {
        //private RepositoryPattern_DBEntities db = new RepositoryPattern_DBEntities();

        //
        // GET: /Employee/
        private Repository.BillRepository billRepository;


        public EmployeeController()
        {
            billRepository = new Repository.BillRepository();
        }

        public ActionResult Index()
        {
            return RedirectToAction("GetBillDetailsForAllDirectors");
        }

        public ActionResult GetBillDetailsForAllDirectors()
        {
           IEnumerable<ViewModel.UserBillSummaryModel> ubsModel =  billRepository.GetEmployeeBillDetailsByDesignation("Director");
           return View(ubsModel);
        }

        //
        // GET: /Employee/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    tbl_Employee tbl_employee = db.tbl_Employee.Find(id);
        //    if (tbl_employee == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_employee);
        //}

        ////
        //// GET: /Employee/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /Employee/Create

        //[HttpPost]
        //public ActionResult Create(tbl_Employee tbl_employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.tbl_Employee.Add(tbl_employee);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(tbl_employee);
        //}

        ////
        //// GET: /Employee/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    tbl_Employee tbl_employee = db.tbl_Employee.Find(id);
        //    if (tbl_employee == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_employee);
        //}

        ////
        //// POST: /Employee/Edit/5

        //[HttpPost]
        //public ActionResult Edit(tbl_Employee tbl_employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(tbl_employee).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(tbl_employee);
        //}

        ////
        //// GET: /Employee/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    tbl_Employee tbl_employee = db.tbl_Employee.Find(id);
        //    if (tbl_employee == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_employee);
        //}

        ////
        //// POST: /Employee/Delete/5

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tbl_Employee tbl_employee = db.tbl_Employee.Find(id);
        //    db.tbl_Employee.Remove(tbl_employee);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}