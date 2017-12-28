using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Repository_pattern_Models
{
    public class UserBillSummaryModel
    {
        private string _empName;
        private double _billAmount;
        private double _billToBePaidByEmployee;
        private string _empDesignation;

        [Display(Name="Total Bill",Description="Amount billed by Oil provider")]
        public double BillAmount
        {
            get { return _billAmount; }
            set { _billAmount = value; }
        }

        [Required]
        [Display(Name = "Employee Name", Description = "Name who apllied the bill")]
        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }

        [Display(Name = "Amount to be paid by Employee", Description = "Amount that is not reimbursed")]
        public double BillToBePaidByEmployee
        {
            get { return _billToBePaidByEmployee; }
            set { _billToBePaidByEmployee = value; }
        }

        [Display(Name = "Designation")]
        public string EmpDesignation
        {
            get { return _empDesignation; }
            set { _empDesignation = value; }
        }
    }
}
