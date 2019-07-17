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
    }
}
