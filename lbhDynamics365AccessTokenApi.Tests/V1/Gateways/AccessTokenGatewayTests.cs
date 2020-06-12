using System;
using System.Net;
using System.Net.Http;
using System.Web;
using AutoFixture;
using FluentAssertions;
using lbhDynamics365AccessTokenApi.V1.Boundary;
using lbhDynamics365AccessTokenApi.V1.Gateways;
using NUnit.Framework;

namespace lbhDynamics365AccessTokenApi.Tests.V1.Gateways
{
    [TestFixture]
    public class AccessTokenGatewayTests : DatabaseTests
    {
        private IAccessTokenGateway _classUnderTest;
        private HttpClient _client;
        private HttpMessageHandlerMock _messageHandlerMock;

        [SetUp]
        public void Setup()
        {
            _messageHandlerMock = new HttpMessageHandlerMock();
            _client = new HttpClient(_messageHandlerMock);
            _classUnderTest = new AccessTokenGateway(_client);
        }

        [TearDown]
        public void DisposeHttpListeners()
        {
            _client.Dispose();
            _messageHandlerMock.Dispose();
        }

        [Test]
        public void GatewayImplementsBoundaryInterface()
        {
            _classUnderTest.Should().BeOfType<AccessTokenGateway>();
        }

        [Test]
        public void GetAccessTokenReturnsAnAccessTokenResponse()
        {
            var response = _classUnderTest.GetAccessToken();

            response.Should().BeOfType<AccessTokenResponse>();
        }

        // This test may or may not be valid
        // [Test]
        // public void GetAccessTokenRWithoutUriReturnsAnExecption
        // {}
    }
}
