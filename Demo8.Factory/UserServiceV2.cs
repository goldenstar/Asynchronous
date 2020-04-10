using System;
using System.Threading.Tasks;

namespace Demo8.Factory
{
    public class UserServiceV2 : IUserService
    {
        public async Task<bool> FinishedTrialPeriod(User user)
        {
            DateTime endTrialPeriodDate = await GetEndTrialPeriodDate(user);

            return endTrialPeriodDate < DateTime.Now;
        }

        private async Task<DateTime> GetEndTrialPeriodDate(User user)
        {
            await Task.Delay(300);

            return DateTime.Now.AddDays(5);
        }
    }
}