using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Interfaces;
using RaaMS.Models;
using Dapper;
using System.Data;

namespace RaaMS.Services
{
    public class RuleFieldService : IRuleFieldService
    {
        readonly IDatabaseService _databaseService;
        public RuleFieldService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<IEnumerable<RuleField>> GetRuleFields(int ruleId)
        {

            using (var connection = _databaseService.GetConnection())
            {
                /* var allrulefields = await connection.QueryAsync<RuleField>(sql);

                 var rulefields =
                       from r in allrulefields
                       where r.RuleId == ruleId
                       select r;*/

                var queryParameters = new DynamicParameters();
                queryParameters.Add("@RuleId", ruleId);

                var rulefields = await connection.QueryAsync<RuleField>(
                    "usp_getrulefields", queryParameters, commandType: CommandType.StoredProcedure);

                return rulefields;
            }
           
        }
    }
}
