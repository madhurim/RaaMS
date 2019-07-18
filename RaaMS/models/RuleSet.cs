using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaaMS.Models
{
    public class RuleSet
    {
        public int RuleSetId { get; set; }
        public IDictionary<Rule, int> TheRules { get; set; }

    }
}
