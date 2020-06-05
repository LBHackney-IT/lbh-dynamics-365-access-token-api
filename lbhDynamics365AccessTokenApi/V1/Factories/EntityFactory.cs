using lbhDynamics365AccessTokenApi.V1.Domain;
using lbhDynamics365AccessTokenApi.V1.Infrastructure;

namespace lbhDynamics365AccessTokenApi.V1.Factories
{
    public static class EntityFactory
    {
        public static Entity ToDomain(this DatabaseEntity databaseEntity)
        {
            return new Entity
            {
                Id = databaseEntity.Id,
                CreatedAt = databaseEntity.CreatedAt,
            };
        }
    }
}
