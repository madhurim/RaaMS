using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Models;

namespace RaaMS.Interfaces
{
    public interface IRuleService
    {
        Rule GetRule(int ruleid);
        Task<IEnumerable<Rule>> GetRules();
    }
}
