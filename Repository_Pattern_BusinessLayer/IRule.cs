using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_BusinessLayer
{
    public interface IRule
    {
        string RuleName { get; }
        string RuleDescription { get;}
        double RuleImplementation(params dynamic[] param1);
    }
}
