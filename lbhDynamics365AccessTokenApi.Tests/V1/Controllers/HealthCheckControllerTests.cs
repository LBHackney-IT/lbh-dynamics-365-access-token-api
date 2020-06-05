using System.Collections.Generic;
using FluentAssertions;
using lbhDynamics365AccessTokenApi.V1.Controllers;
using lbhDynamics365AccessTokenApi.V1.UseCase;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace lbhDynamics365AccessTokenApi.Tests.V1.Controllers
{

    [TestFixture]
    public class HealthCheckControllerTests
    {
        private HealthCheckController _classUnderTest;


        [SetUp]
        public void SetUp()
        {
            _classUnderTest = new HealthCheckController();
        }

        [Test]
        public void ReturnsResponseWithStatus()
        {
            var expected = new Dictionary<string, object> { { "success", true } };
            var response = _classUnderTest.HealthCheck() as OkObjectResult;

            response.Should().NotBeNull();
            response.StatusCode.Should().Be(200);
            response.Value.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void ThrowErrorThrows()
        {
            Assert.Throws<TestOpsErrorException>(_classUnderTest.ThrowError);
        }
    }
}
