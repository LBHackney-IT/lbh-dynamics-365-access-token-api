using AutoFixture;
using FluentAssertions;
using lbhDynamics365AccessTokenApi.Tests.V1.Helper;
using lbhDynamics365AccessTokenApi.V1.Domain;
using lbhDynamics365AccessTokenApi.V1.Gateways;
using NUnit.Framework;

namespace lbhDynamics365AccessTokenApi.Tests.V1.Gateways
{
    [TestFixture]
    public class ExampleGatewayTests : DatabaseTests
    {
        private Fixture _fixture = new Fixture();
        private ExampleGateway _classUnderTest;

        [SetUp]
        public void Setup()
        {
            _classUnderTest = new ExampleGateway(DatabaseContext);
        }

        [Test]
        public void GatewayImplementsBoundaryInterface()
        {
            Assert.NotNull(_classUnderTest is IExampleGateway);
        }

        [Test]
        public void GetEntityByIdReturnsEmptyArray()
        {
            var response = _classUnderTest.GetEntityById(123);

            response.Should().BeNull();
        }

        [Test]
        public void GetEntityByIdReturnsCorrectResponse()
        {
            var entity = _fixture.Create<Entity>();
            var databaseEntity = DatabaseEntityHelper.CreateDatabaseEntityFrom(entity);

            DatabaseContext.DatabaseEntities.Add(databaseEntity);
            DatabaseContext.SaveChanges();

            var response = _classUnderTest.GetEntityById(databaseEntity.Id);

            databaseEntity.Id.Should().Be(response.Id);
            databaseEntity.CreatedAt.Should().BeSameDateAs(response.CreatedAt);
        }
    }
}
