using MembershipSystem.ApiHost;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace MemberSystem.ApiHost.Tests
{
    public class GetUsers
    : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public GetUsers(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }


        [Fact]
        public async Task Valid_Request_Returns_Users()
        {
            // Arrange
            var client = _factory.CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"/users");

            // Act
            var response = await client.SendAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

