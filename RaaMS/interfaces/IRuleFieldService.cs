using RaaMS.Interfaces;
using RaaMS.Models;
using System.Collections.Generic;
using Dapper;
using System.Threading.Tasks;

namespace RaaMS.Interfaces
{
    public interface IRuleFieldService
    {
        Task<IEnumerable<RuleField>> GetRuleFields(int ruleId);

    }
}