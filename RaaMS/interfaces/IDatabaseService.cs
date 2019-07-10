using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
//using Dapper;


namespace RaaMS.Interfaces
{
    public interface IDatabaseService
    {
        IDbConnection GetConnection();
    }
}
