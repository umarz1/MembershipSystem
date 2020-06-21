using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using MembershipSystem.ApiHost.DataStore.Sql.Model;
using MembershipSystem.ApiHost.DataStore.Sql.Requests;

namespace MembershipSystem.ApiHost.DataStore.Sql.Handlers
{
    public class GetUserHandler: ISqlQueryHandler<GetUser, User>
    {
        public Task<User> Execute(SqlTransaction transaction, GetUser request)
        {
            var query = @"
SELECT 
    u.UserId,
    u.Name
FROM Users u
WHERE u.UserId = @UserId";

            return transaction.Connection.QueryFirstOrDefaultAsync<User>(
                query,
                new { request.UserId },
                transaction);
        }
    }
}
