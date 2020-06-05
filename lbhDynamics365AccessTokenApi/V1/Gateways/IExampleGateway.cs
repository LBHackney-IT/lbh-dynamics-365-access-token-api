using lbhDynamics365AccessTokenApi.V1.Domain;

namespace lbhDynamics365AccessTokenApi.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);
    }
}
