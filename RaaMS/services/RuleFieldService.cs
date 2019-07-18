using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Interfaces;
using RaaMS.Models;
using Dapper;

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
            string sql = "SELECT * FROM RuleField";

            using (var connection = _databaseService.GetConnection())
            {
                var allrulefields = await connection.QueryAsync<RuleField>(sql);

                var rulefields =
                      from r in allrulefields
                      where r.RuleId == ruleId
                      select r;

                return rulefields;
            }
           
        }
    }
}
