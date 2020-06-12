using System;

namespace lbhDynamics365AccessTokenApi.V1.Boundary
{
    public class AccessTokenResponse
    {
        public string Token { get; set; }
        public DateTime GeneratedAt { get; set; }

        public AccessTokenResponse(string token, DateTime generatedAt)
        {
            Token = token;
            GeneratedAt = generatedAt;
        }
    }
}
