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
        public string RuleExpression { get; set; }
        public Boolean IsActive { get; set; }

    }
}
