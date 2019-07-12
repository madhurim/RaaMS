using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Interfaces;
using RaaMS.Models;
using Dapper;

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
        public async Task<IEnumerable<Models.Rule>> GetRules()
        {
            string sql = "SELECT TOP 10 * FROM Rules";
            

            using (var connection = _databaseService.GetConnection())
            {
                var rules = await connection.QueryAsync<Models.Rule>(sql);
                return rules;
            }
            
        }

    }
}
