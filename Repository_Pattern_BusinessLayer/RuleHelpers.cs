using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Repository_Pattern_BusinessLayer
{
    public static class RuleHelpers
    {
        private static IList<IRule> rules;
        static RuleHelpers()
        {
            rules = new List<IRule>();
        }
        public static IList<IRule> InitializeRuleEngine()
        {
            List<Type> types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IRule))).ToList();
            foreach (var type in types)
            {
                rules.Add((IRule)Activator.CreateInstance(type));
            }
            //var abcd = (from t in Assembly.GetExecutingAssembly().GetTypes()
            //            where t.GetInterfaces().Contains(typeof(IRule))
            //            select (IRule)Activator.CreateInstance(t)).ToList();
            return rules;

        }
    }
}
