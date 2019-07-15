using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Interfaces;
using RaaMS.Models;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace RaaMS.Services
{
    public class DatabaseService : IDatabaseService
    {
        IConfiguration _iconfiguration;
        public DatabaseService(IConfiguration iconfiguration)
        {
            _iconfiguration = iconfiguration;
        }
        public IDbConnection GetConnection()
        {
            // var connectionString = _iconfiguration.GetConnectionString("RulesServiceConnection");
            var connectionString = _iconfiguration.GetSection("ConnectionStrings:RulesServiceConnection").Value; ;
            var dbConnection = new SqlConnection(connectionString);

            return dbConnection;
        }        

    }
}
