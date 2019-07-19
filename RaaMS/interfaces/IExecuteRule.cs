using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Models;
using RaaMS.Interfaces;

namespace RaaMS.Interfaces
{
    public interface IExecuteRule
    {
        IRuleResult ExecuteRule(Rule theRule, IEnumerable<RuleField> ruleFields );
       // IRuleResult ExecuteRule(Rule theRule, IDictionary<RuleField, RuleFieldValue> ruleFields);
        //IRuleResult ExecuteRuleSet(IEnumerable<Rule> ruleSet);

       /* public static List<T> CreateList<T>(params T[] items)
        {
            List<T> result = new List<T>();

            foreach (T item in items)

            {

                result.Add(item);

            }

            return result;

        }

        var something = new { Name = "Paul", Age = 25, Sex = 'M' };

        var somethingElse = new { Name = "RudeDog2", Age = 26, Sex = 'M' };

        var list = CreateList(something, somethingElse);*/

    }
}
