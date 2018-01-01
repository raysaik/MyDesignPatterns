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
        private IEnumerable<ViewModel.UserBillSummaryModel> ubsModel = null;


        public EmployeeController()
        {
            billRepository = new Repository.BillRepository();
        }

        public ActionResult Index()
        {
            ubsModel = billRepository.GetAllEmployeeBillDetails();
            ViewBag.Title = "GetAllEmployeeBillDetails";
            return View(ubsModel);
           // return RedirectToAction("GetBillDetailsForAllDirectors");
        }

        public ActionResult GetBillDetailsForAllDirectors()
        {
           IEnumerable<ViewModel.UserBillSummaryModel> ubsModel = billRepository.GetEmployeeBillDetailsByDesignation("Technitian");
           return View(ubsModel);
        }
    }
}