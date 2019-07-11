using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Interfaces;
using RaaMS.Models;
using Dapper;


namespace RaaMS.Services
{
    public class DatabaseService : IDatabaseService
    {
        public IDbConnection GetConnection()
        {
            var connectionString = "Data Source=localhost;Initial Catalog=RulesServices;Integrated Security=True";
            var dbConnection = new SqlConnection(connectionString);

            return dbConnection;
        }
        public IEnumerable<Models.Rule> GetRules()
        {
            string sql = "SELECT TOP 10 * FROM Rules";

            using (var connection = GetConnection())
            {
                var rules = connection.Query<Models.Rule>(sql).ToList();                
            }

            return null;
        }

    }
}
