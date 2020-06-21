using MembershipSystem.ApiHost.DataStore.Sql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipSystem.ApiHost.DataStore.Sql.Requests
{
    public class GetUser : ISqlQuery<User>
    {
        public string UserId { get; set; }
    }
}
