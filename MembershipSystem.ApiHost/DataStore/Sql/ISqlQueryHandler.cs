using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipSystem.ApiHost.DataStore.Sql
{
    public interface ISqlQueryHandler<TRequest, TResult>
        where TRequest : ISqlQuery<TResult>
    {
        Task<TResult> Execute(SqlTransaction transaction, TRequest request);
    }
}
