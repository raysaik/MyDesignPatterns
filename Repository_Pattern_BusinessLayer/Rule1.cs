using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_BusinessLayer
{
    public class Rule1 : IRule
    {

        public string RuleName
        {
            get
            {
                return "GradeRule";
            }

        }

        public string RuleDescription
        {
            get
            {
                //This should read from the rule book
                return "Oil amount to be paid based on grade";
            }
        }

        private string _grade;
        private double _amount;
        public double RuleImplementation(params dynamic[] param1)
        {
            _grade = param1[0];
            _amount = param1[1];
            switch (_grade)
            {
                case "A":
                    return (_amount * 20) / 100;
                case "B":
                    return (_amount * 50) / 100;
                case "C":
                default:
                    return _amount;
                case "D":
                    return 0;
            }
        }
    }
}