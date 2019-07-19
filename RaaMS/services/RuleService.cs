using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Interfaces;
using RaaMS.Models;
using Dapper;
using System.Data;
using Rule = RaaMS.Models.Rule;

namespace RaaMS.Services
{
    public class RuleService : IRuleService
    {
        readonly IDatabaseService _databaseService;
        public RuleService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Rule GetRule(int ruleid)
        {
            return null;
        }
        public async Task<IEnumerable<Rule>> GetRules()
        {
        
            using (var connection = _databaseService.GetConnection())
            {
               
                var rules = await connection.QueryAsync<Rule>(
                    "usp_getrules", commandType: CommandType.StoredProcedure);

               
               // var rules = await connection.QueryAsync<Models.Rule>(sql);

              /*  var activeRules =
                    from r in rules
                    where r.IsActive = true
                    select r;*/

                return rules;
            }
            
        }

    }
}
