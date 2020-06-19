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
    public class GetWeatherForcast
    : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public GetWeatherForcast(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }


        [Fact]
        public async Task Valid_Request_Returns_Weather_Forcast()
        {
            // Arrange
            var client = _factory.CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"https://localhost:44344/weatherforecast");

            // Act
            var response = await client.SendAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

