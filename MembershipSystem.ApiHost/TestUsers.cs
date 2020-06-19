using MemberSystem.ApiContract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipSystem.ApiHost
{
    public class TestUsers
    {
        public static List<UserDto> Users = new List<UserDto>()
        {
            new UserDto
            {
                EmployeeId = "1234",
                Name = "Abdul Khan",
                Mobile = "07545445553",
                Email = "abdul1@hotmail.com"
            },
             new UserDto
            {
                EmployeeId = "1234",
                Name = "Umar Zahir",
                Mobile = "07545445553",
                Email = "umar@hotmail.com"
            },
              new UserDto
            {
                EmployeeId = "1234",
                Name = "Tom Johnson",
                Mobile = "07545445553",
                Email = "tom@hotmail.com"
            },
        };
    }
}
