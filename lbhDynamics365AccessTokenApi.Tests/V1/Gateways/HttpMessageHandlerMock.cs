using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace lbhDynamics365AccessTokenApi.Tests.V1.Gateways
{
    class HttpMessageHandlerMock : HttpMessageHandler
    {
        private const string _message = @"{
    ""result"": ""token"",
    ""id"": 2065,
    ""exception"": null,
    ""status"": 5,
    ""isCanceled"": false,
    ""isCompleted"": true,
    ""creationOptions"": 0,
    ""asyncState"": null,
    ""isFaulted"": false
}";

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken) =>
            Task.FromResult(
                new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(_message)
                }
            );
    }
}
