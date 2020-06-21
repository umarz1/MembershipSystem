using MembershipSystem.ApiHost.DataStore.Sql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipSystem.ApiHost.DataStore
{
    public interface ISqlUnitOfWork :IDisposable
    {
        SqlTransaction Transaction { get; }
        Task Commit();
        Task<T> ExecuteRequest<T>(ISqlQuery<T> request);
    }
}
