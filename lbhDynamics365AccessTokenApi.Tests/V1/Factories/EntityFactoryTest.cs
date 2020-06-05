using FluentAssertions;
using lbhDynamics365AccessTokenApi.V1.Factories;
using lbhDynamics365AccessTokenApi.V1.Infrastructure;
using NUnit.Framework;

namespace lbhDynamics365AccessTokenApi.Tests.V1.Factories
{
    [TestFixture]
    public class EntityFactoryTest
    {
        [Test]
        public void CanBeCreatedFromDatabaseEntity()
        {
            var databaseEntity = new DatabaseEntity();
            var entity = databaseEntity.ToDomain();

            databaseEntity.Id.Should().Be(entity.Id);
            databaseEntity.CreatedAt.Should().BeSameDateAs(entity.CreatedAt);
        }
    }
}
