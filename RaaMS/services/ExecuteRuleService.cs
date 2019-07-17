using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Interfaces;
using RaaMS.Models;

namespace RaaMS.Services
{
    public class ExecuteRuleService : IExecuteRule
    {
        
        protected readonly  IRuleService _ruleService;
        protected readonly IRuleFieldService _ruleFieldService;
        public ExecuteRuleService(IRuleService ruleService,IRuleFieldService ruleFieldService)
        {
            _ruleService = ruleService;
            _ruleFieldService = ruleFieldService;
        }
        public IRuleResult ExecuteRule(Rule theRule,IEnumerable<RuleField> ruleFields)
        {
            string ruleStatement = theRule.EvaluationStatement;
            string yesOutcome = theRule.YesOutcome;
            string noOutcome = theRule.NoOutcome;

            return null;
        }
    }
}
