using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Models;

namespace RaaMS.Interfaces
{
    public interface IRuleSetService
    {
        Task<IEnumerable<Rule>> GetRuleSet(String RuleSetName);
    }
}
