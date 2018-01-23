using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository_pattern_Models;
using System.Web.Mvc;
using Repository_Pattern_Model_Abstract;

namespace Repository_Pattern_UI.Models
{
    public class HomePageViewModel : Abstract_ViewModel
    {
      
        public override IEnumerable<IUserBillSummaryModel> ubsModels { get; set; }
        public override List<SelectListItem> ListOfDesignations { get; set; }
        public override string selectedDesignation { get; set; }

        public HomePageViewModel()
        {
            //ListOfDesignations = new List<SelectListItem>();
            //ListOfDesignations.Add(new SelectListItem() { Selected = true, Text = "All", Value = "" });

        }
    }
}