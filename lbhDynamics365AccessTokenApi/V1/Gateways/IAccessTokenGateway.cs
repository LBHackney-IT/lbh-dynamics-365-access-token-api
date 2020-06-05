using lbhDynamics365AccessTokenApi.V1.Boundary;

namespace lbhDynamics365AccessTokenApi.V1.Gateways
{
    public interface IAccessTokenGateway
    {
        AccessTokenResponse GetAccessToken();
    }
}
