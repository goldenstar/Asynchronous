using System.Threading.Tasks;

namespace Demo8.Factory
{
    public class UserServiceV1 : IUserService
    {
        public Task<bool> FinishedTrialPeriod(User user)
        {
            bool result = true;

            return Task.FromResult(result);
        }

        public ValueTask<int> GetFreeDays(User user)
        {
            int value = 5;

            return new ValueTask<int>(value);
        }
    }
}