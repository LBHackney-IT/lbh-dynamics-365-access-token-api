using FluentAssertions;
using lbhDynamics365AccessTokenApi.V1.UseCase;
using NUnit.Framework;

namespace lbhDynamics365AccessTokenApi.Tests.V1.UseCase
{
    [TestFixture]
    public class ThrowOpsErrorUsecaseTests
    {
        [Test]
        public void ThrowsTestOpsErrorException()
        {
            var ex = Assert.Throws<TestOpsErrorException>(
                delegate { ThrowOpsErrorUsecase.Execute(); });

            var expected = "This is a test exception to test our integrations";

            ex.Message.Should().BeEquivalentTo(expected);
        }
    }
}
