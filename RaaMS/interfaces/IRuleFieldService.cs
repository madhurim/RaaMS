using RaaMS.Interfaces;
using RaaMS.Models;
using System.Collections.Generic;

namespace RaaMS.Interfaces
{
    public interface IRuleFieldService
    {
        IEnumerable<RuleField> GetRuleFields(int ruleId);

    }
}