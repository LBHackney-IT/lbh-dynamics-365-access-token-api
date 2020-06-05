
namespace lbhDynamics365AccessTokenApi.V1.UseCase
{
    public static class ThrowOpsErrorUsecase
    {
        public static void Execute()
        {
            throw new TestOpsErrorException();
        }
    }
}
