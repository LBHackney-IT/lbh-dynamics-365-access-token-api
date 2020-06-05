using lbhDynamics365AccessTokenApi.V1.Domain;
using lbhDynamics365AccessTokenApi.V1.Factories;
using lbhDynamics365AccessTokenApi.V1.Infrastructure;

namespace lbhDynamics365AccessTokenApi.V1.Gateways
{
    public class ExampleGateway : IExampleGateway
    {
        private readonly DatabaseContext _databaseContext;

        public ExampleGateway(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Entity GetEntityById(int id)
        {
            var result = _databaseContext.DatabaseEntities.Find(id);

            return (result != null) ?
                result.ToDomain() :
                null;
        }
    }
}
