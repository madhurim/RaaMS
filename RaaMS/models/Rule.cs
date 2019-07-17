using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RaaMS.Models
{
    public class Rule 
    {
        public int RuleId { get; set; }
        public string RuleName { get; set; }
        public string RuleDescription { get; set; }
        public string RuleStatement { get; set; }
        public string EvaluationStatement { get; set; }
        public Boolean IsActive { get; set; }
        public string YesOutcome { get; set; }
        public string NoOutcome { get; set; }

    }
}
