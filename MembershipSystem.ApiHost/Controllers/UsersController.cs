using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembershipSystem.ApiContract;
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

        [HttpGet("users")]
        public IEnumerable<UserDto> Get()
        {
            var users = TestUsers.Users;
            return users;
        }
    }
}
