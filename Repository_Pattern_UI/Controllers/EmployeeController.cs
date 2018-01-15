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
        //private IEnumerable<ViewModel.UserBillSummaryModel> ubsModel = null;


        public EmployeeController()
        {
            billRepository = new Repository.BillRepository();
        }

        public ActionResult Index()
        {
            HomePageViewModel viewModel = new HomePageViewModel();
            viewModel.ubsModels = billRepository.GetAllEmployeeBillDetails();
            var _allDesignations = billRepository.GetAllEmployeeDesignations();
            foreach (string s in _allDesignations)
            {
                viewModel.ListOfDesignations.Add(new SelectListItem() { Text = s, Value = s });
            }
            ViewBag.Title = "GetAllEmployeeBillDetails";
            return View(viewModel);
        }

        public ActionResult GetBillDetailsForAllDirectors()
        {
           IEnumerable<ViewModel.UserBillSummaryModel> ubsModel = billRepository.GetEmployeeBillDetailsByDesignation("Technitian");
           return View(ubsModel);
        }

        public ActionResult FilterByDesgnation(HomePageViewModel viewModel)
        {
            viewModel.ubsModels = billRepository.GetEmployeeBillDetailsByDesignation(viewModel.selectedDesignation);
            var _allDesignations = billRepository.GetAllEmployeeDesignations();
            foreach (string s in _allDesignations)
            {
                viewModel.ListOfDesignations.Add(new SelectListItem() { Text = s, Value = s });
            }
            ViewBag.Title = string.Format("GetAll{0}'sBillDetails", viewModel.selectedDesignation);
            return View("Index", viewModel);
        }
    }
}