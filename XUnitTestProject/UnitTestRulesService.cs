using System;
using Xunit;
using RaaMS.Services;
using RaaMS.Interfaces;
using NSubstitute;
using System.Data.SqlClient;

namespace XUnitTestProject
{
    public class UnitTestRulesService
    {
        RuleService ruleService;
        public UnitTestRulesService()
        {
            var databaseService = Substitute.For<IDatabaseService>();
            ruleService = new RuleService(databaseService);
            databaseService
            .GetConnection();
           

        }
        [Fact]
        public void TestGetRules()
        {

        }
    }
}
