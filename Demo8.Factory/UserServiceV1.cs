using System.Threading.Tasks;

namespace Demo8.Factory
{
    public class UserServiceV1 : IUserService
    {
        public Task<bool> FinishedTrialPeriod(User user)
        {
            return Task.FromResult(true);
        }
    }
}