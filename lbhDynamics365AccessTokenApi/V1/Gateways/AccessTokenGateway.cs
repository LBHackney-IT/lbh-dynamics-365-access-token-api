using System;
using System.Net.Http;
using lbhDynamics365AccessTokenApi.V1.Boundary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lbhDynamics365AccessTokenApi.V1.Gateways
{
    public class AccessTokenGateway : IAccessTokenGateway
    {
        private readonly Uri _authorizationUri;
        private readonly HttpClient _client;
        public AccessTokenGateway(HttpClient client)
        {
            _authorizationUri = new Uri(Environment.GetEnvironmentVariable("CRM_AUTH_URI") ?? "http://example.com");
            _client = client;
        }

        public AccessTokenResponse GetAccessToken()
        {
            var token = JsonConvert.DeserializeObject<JObject>(_client
                .GetAsync(_authorizationUri)
                .Result
                .Content
                .ReadAsStringAsync()
                .Result
            );

            _client.Dispose();

            return new AccessTokenResponse(token["result"].ToString(), DateTime.Now);
        }
    }
}
