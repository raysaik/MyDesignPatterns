using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository_Pattern_UI.Models
{
    public class EmployeeBillDetails
    {
        private string _empName;
        private double _billAmount;

        public double BillAmount
        {
            get { return _billAmount; }
            set { _billAmount = value; }
        }

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }
    }
}