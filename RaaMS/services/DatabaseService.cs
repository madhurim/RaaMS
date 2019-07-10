using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using RaaMS.Interfaces;

namespace RaaMS.Services
{
    public class DatabaseService : IDatabaseService
    {
        public IDbConnection GetConnection()
        {
            throw new NotImplementedException();
        }

    }
}
