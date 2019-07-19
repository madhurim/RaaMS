using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using RaaMS.Interfaces;
using RaaMS.Models;
using Rule = RaaMS.Models.Rule;

namespace RaaMS.Services
{
    public class RuleSetService: IRuleSetService
    {
        readonly IDatabaseService _databaseService;
        public RuleSetService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<IEnumerable<Rule>> GetRuleSet(String RuleSetName)
        {
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@RuleSetName", RuleSetName);

            using (var connection = _databaseService.GetConnection())
            {
               return await connection.QueryAsync<Rule>(
                "usp_getruleset",queryParameters,commandType: CommandType.StoredProcedure);             

            }
        }

    }
}
