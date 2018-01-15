using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository_pattern_Models;
using System.Web.Mvc;
namespace Repository_Pattern_UI.Models
{
    public class HomePageViewModel
    {
      
        public IEnumerable<UserBillSummaryModel> ubsModels { get; set; }
        public List<SelectListItem> ListOfDesignations { get; set; }
        public string selectedDesignation { get; set; }

        public HomePageViewModel()
        {
            ListOfDesignations = new List<SelectListItem>();
            ListOfDesignations.Add(new SelectListItem() { Selected = true, Text = "All", Value = "" });

        }
    }
}