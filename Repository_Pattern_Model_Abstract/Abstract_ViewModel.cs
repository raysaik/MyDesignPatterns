using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Repository_Pattern_Model_Abstract
{
    public abstract class Abstract_ViewModel
    {
        public abstract IEnumerable<IUserBillSummaryModel> ubsModels { get; set; }
        public abstract List<SelectListItem> ListOfDesignations { get; set; }

        public abstract string selectedDesignation { get; set; }

        public Abstract_ViewModel()
        {
            ListOfDesignations = new List<SelectListItem>();
            ListOfDesignations.Add(new SelectListItem() { Selected = true, Text = "All", Value = "" });
        }

    }
}
