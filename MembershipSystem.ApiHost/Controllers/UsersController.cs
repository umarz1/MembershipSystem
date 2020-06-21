using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Dapper;
using MembershipSystem.ApiContract;
using MembershipSystem.ApiHost.DataStore.Sql.Model;
using MemberSystem.ApiContract;
using MemberSystem.ApiContract.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MembershipSystem.ApiHost.Controllers
{
    [ApiController]
    [Route("")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet("users/{cardId}")]
        public async Task<IActionResult> GetUser(string cardId)
        {
            var user = new User();
            using (IDbConnection db = new SqlConnection("Data Source=(local);Integrated Security=True; Database=MembershipSystem;"))
            {
                user =  await db.QueryFirstOrDefaultAsync<User>("SELECT * FROM CardUsers  WHERE CardId = @CardId",
                    new { CardId = cardId });
            }

            return Ok(user);
        }

        [HttpPost("users")]
        public async Task<IActionResult> CreateUser([FromBody] UserDetails userDetails)
        {
            string query = @"INSERT INTO CardUsers
                       (CardId
                       , EmployeeId
                       , Name
                       , Email
                       , Mobile)
            VALUES
                       ('FyDJ0lbYcPkzp2Ja'
                       , @EmployeeId
                       , @Name
                       , @Email
                       , @Mobile)";

            try
            {
                using (IDbConnection connection = new SqlConnection("Data Source=(local);Integrated Security=True; Database=MembershipSystem;"))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        var affectedRows = await connection.ExecuteAsync(query,
                            new
                            {
                                EmployeeId = userDetails.EmployeeId,
                                Name = userDetails.Name,
                                Email = userDetails.Email,
                                Mobile = userDetails.Mobile
                            },
                            transaction: transaction);

                        transaction.Commit();
                    }
                }
            }
            catch(SqlException ex) when (ex.Number ==2627)
            {

                //throw new OperationException(new ErrorTypeInfo("USER_ALREADY_EXISTS", "User already exists").ToErrorDetail());

                //throw new HttpResponseException(HttpStatusCode.NotFound);

                //HttpResponseException
            };



            return Ok();
        }
    }
}
