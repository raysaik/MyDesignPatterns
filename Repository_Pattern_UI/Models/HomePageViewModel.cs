using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository_pattern_Models;
namespace Repository_Pattern_UI.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<UserBillSummaryModel> ubsModels;

        private Dictionary<int, string> designations;

        public Dictionary<int, string> Designations { get => designations; set => designations = value; }
    }
}