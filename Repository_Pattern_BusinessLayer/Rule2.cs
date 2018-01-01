using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_BusinessLayer
{
    public class Rule2 : IRule
    {
        public string RuleName
        {
            get
            {
                return "HouseKeepingRule";
            }

        }

        public string RuleDescription
        {
            get
            {
                //This should read from the rule book
                return "Housekeeping reimbursement policy based on payment mode";
            }
        }


        private string _grade;
        private double _amount;
        private string _designation;
        private double _amountPaidInCash;
        public double RuleImplementation(params dynamic[] param1)
        {
            _grade = param1[0];
            _amount = param1[1];
            _designation = param1[2];
            _amountPaidInCash = param1[3];
            if (_designation.Equals("Housekeeping")) {
                _amount = _amount + _amountPaidInCash;
            }
            return _amount;
        }
    }
}
